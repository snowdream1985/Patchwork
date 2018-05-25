#include <Windows.h>
struct bundle {
	char *name;
	unsigned char *data;
	unsigned int len;
};
static struct bundle bundles[32], *list_bundles[32];
static int len, bundle_count = 0;
static char names[32][64];

__declspec(dllexport)
DWORD WINAPI  GetIpAddrTable(void *p, long *n, BOOL o) {
	return 1;
}

//import
void *(*mono_assembly_open_full)(const char *name, int *stat, BOOL refonly);
void (*mono_register_bundled_assemblies)(void **);
void(*mono_profiler_install)(void *, void *);
void(*mono_profiler_set_events)(int mask);
void(*mono_profiler_install_module)(void *, void *, void *, void *);
void(*mono_profiler_install_assembly)(void *, void *, void *, void *);

void *(*mono_debug_init)(int v);

static int count = 0;
static void hook(void *data, void *img) {
	if (!count++) return;
	mono_profiler_set_events(0);
	for (int i = 0; i < bundle_count; i++)
		mono_assembly_open_full(names[i], NULL, FALSE);
}

static BOOL CALLBACK enum_cb(HMODULE  hModule, _In_ const char *t, const char *name, void *par)
{
	struct bundle *b = &bundles[bundle_count];
	list_bundles[bundle_count] = b;
	b->name = &names[bundle_count][0];
	lstrcpyA(b->name, name);

	HRSRC hres = FindResourceA(hModule, name, MAKEINTRESOURCEA(RT_RCDATA));
	HGLOBAL hglob = LoadResource(hModule, hres);
	void *res_data = (char*)LockResource(hglob);
	if (res_data) {
		b->data = LockResource(hglob);
		b->len = SizeofResource(hModule, hres);
		bundle_count++;
	}
};

BOOL APIENTRY DllMain(HMODULE hModule, DWORD  ul_reason_for_call, LPVOID lpReserved)
{
	wchar_t name[_MAX_PATH + 1];
	if (ul_reason_for_call != DLL_PROCESS_ATTACH)
		return TRUE;
	// load mono
	len = GetModuleFileName(NULL, name, MAX_PATH);
	lstrcpy(name + len - 4, L"_Data\\Mono\\mono.dll");
	HMODULE mono = LoadLibrary(name);
	if (!mono) {
		lstrcpy(name + len - 4 + 5, L"\\EmbedRuntime\\mono.dll");
		mono = LoadLibrary(name);
		if (!mono) {
			MessageBoxA(NULL, "Can't find mono.dll. Is this the right game folder?", "Fatal", MB_OK | MB_ICONASTERISK);
			return FALSE;
		}
	}

	// resolve symbols
#define LOAD(n) \
	n = (void*)GetProcAddress(mono, #n); \
	if (!n) { \
		MessageBoxA(NULL, #n, "Method missing", MB_OK | MB_ICONASTERISK); \
		ExitProcess(1); \
	}
	LOAD(mono_register_bundled_assemblies);
	LOAD(mono_profiler_install_assembly);
	LOAD(mono_assembly_open_full);
	LOAD(mono_profiler_install);
	LOAD(mono_profiler_set_events);
	LOAD(mono_profiler_install_module);
	LOAD(mono_debug_init);

	EnumResourceNamesA(hModule, MAKEINTRESOURCEA(RT_RCDATA), enum_cb, 0);
	if (!bundle_count)
		MessageBoxA(NULL, "No assemblies found to preload", "Error", MB_OK | MB_ICONASTERISK);

	mono_debug_init(1);
	// register bundled assemblies
	mono_register_bundled_assemblies(&list_bundles[0]);

	mono_profiler_install(NULL, NULL);
	mono_profiler_set_events(1 << 2);
	mono_profiler_install_module(&hook, NULL, NULL, NULL);
	return TRUE;
}
