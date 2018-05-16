namespace Patchwork
{
	partial class SettingsForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.launchButton = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.linkUnityDoc = new System.Windows.Forms.LinkLabel();
			this.label22 = new System.Windows.Forms.Label();
			this.Other = new System.Windows.Forms.GroupBox();
			this.maxQueuedFrames = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.asyncUploadBufferSize = new System.Windows.Forms.TextBox();
			this.asyncUploadTimeSlice = new System.Windows.Forms.TextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.particleRaycastBudget = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.maximumLODLevel = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.lodBias = new System.Windows.Forms.TextBox();
			this.vsyncText = new System.Windows.Forms.Label();
			this.vSyncCount = new System.Windows.Forms.ComboBox();
			this.blendWeights = new System.Windows.Forms.ComboBox();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.shadowCascade2Split = new System.Windows.Forms.TextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.shadowCascades = new System.Windows.Forms.ComboBox();
			this.shadowNearPlaneOffset = new System.Windows.Forms.TextBox();
			this.shadowDistance = new System.Windows.Forms.TextBox();
			this.realtimeReflectionProbes = new System.Windows.Forms.CheckBox();
			this.shadowProjection = new System.Windows.Forms.ComboBox();
			this.shadowResolution = new System.Windows.Forms.ComboBox();
			this.label11 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.shadows = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.f_qualitySelect = new System.Windows.Forms.ComboBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label20 = new System.Windows.Forms.Label();
			this.renderingPath = new System.Windows.Forms.ComboBox();
			this.softParticles = new System.Windows.Forms.CheckBox();
			this.pixelLightCount = new System.Windows.Forms.TextBox();
			this.fullscreen = new System.Windows.Forms.CheckBox();
			this.label8 = new System.Windows.Forms.Label();
			this.resolution = new System.Windows.Forms.ComboBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.anisotropicFiltering = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.masterTextureLimit = new System.Windows.Forms.ComboBox();
			this.antiAliasing = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.unlockH = new System.Windows.Forms.CheckBox();
			this.tumblr = new System.Windows.Forms.CheckBox();
			this.watchFolder = new System.Windows.Forms.CheckBox();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.Other.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// launchButton
			// 
			this.launchButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.launchButton.Location = new System.Drawing.Point(12, 378);
			this.launchButton.Name = "launchButton";
			this.launchButton.Size = new System.Drawing.Size(832, 82);
			this.launchButton.TabIndex = 0;
			this.launchButton.Text = "Launch";
			this.launchButton.UseVisualStyleBackColor = true;
			// 
			// tabControl1
			// 
			this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Location = new System.Drawing.Point(12, 12);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(836, 360);
			this.tabControl1.TabIndex = 4;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.linkUnityDoc);
			this.tabPage1.Controls.Add(this.label22);
			this.tabPage1.Controls.Add(this.Other);
			this.tabPage1.Controls.Add(this.groupBox2);
			this.tabPage1.Controls.Add(this.f_qualitySelect);
			this.tabPage1.Controls.Add(this.groupBox1);
			this.tabPage1.Location = new System.Drawing.Point(4, 25);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(828, 331);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Graphics";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// linkUnityDoc
			// 
			this.linkUnityDoc.AutoSize = true;
			this.linkUnityDoc.Location = new System.Drawing.Point(348, 20);
			this.linkUnityDoc.Name = "linkUnityDoc";
			this.linkUnityDoc.Size = new System.Drawing.Size(377, 17);
			this.linkUnityDoc.TabIndex = 34;
			this.linkUnityDoc.TabStop = true;
			this.linkUnityDoc.Text = "https://docs.unity3d.com/Manual/class-QualitySettings.html";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(90, 20);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(52, 17);
			this.label22.TabIndex = 33;
			this.label22.Text = "Quality";
			// 
			// Other
			// 
			this.Other.Controls.Add(this.maxQueuedFrames);
			this.Other.Controls.Add(this.label14);
			this.Other.Controls.Add(this.label19);
			this.Other.Controls.Add(this.label18);
			this.Other.Controls.Add(this.asyncUploadBufferSize);
			this.Other.Controls.Add(this.asyncUploadTimeSlice);
			this.Other.Controls.Add(this.label17);
			this.Other.Controls.Add(this.particleRaycastBudget);
			this.Other.Controls.Add(this.label16);
			this.Other.Controls.Add(this.maximumLODLevel);
			this.Other.Controls.Add(this.label15);
			this.Other.Controls.Add(this.lodBias);
			this.Other.Controls.Add(this.vsyncText);
			this.Other.Controls.Add(this.vSyncCount);
			this.Other.Controls.Add(this.blendWeights);
			this.Other.Controls.Add(this.label13);
			this.Other.Location = new System.Drawing.Point(561, 47);
			this.Other.Name = "Other";
			this.Other.Size = new System.Drawing.Size(257, 271);
			this.Other.TabIndex = 6;
			this.Other.TabStop = false;
			this.Other.Text = "Other";
			// 
			// maxQueuedFrames
			// 
			this.maxQueuedFrames.Location = new System.Drawing.Point(125, 89);
			this.maxQueuedFrames.Name = "maxQueuedFrames";
			this.maxQueuedFrames.Size = new System.Drawing.Size(121, 22);
			this.maxQueuedFrames.TabIndex = 40;
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(13, 87);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(106, 17);
			this.label14.TabIndex = 39;
			this.label14.Text = "Queued frames";
			this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(25, 236);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(95, 17);
			this.label19.TabIndex = 37;
			this.label19.Text = "Tex upl buffer";
			this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(10, 207);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(110, 17);
			this.label18.TabIndex = 36;
			this.label18.Text = "Tex upload slice";
			this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// asyncUploadBufferSize
			// 
			this.asyncUploadBufferSize.Location = new System.Drawing.Point(126, 234);
			this.asyncUploadBufferSize.Name = "asyncUploadBufferSize";
			this.asyncUploadBufferSize.Size = new System.Drawing.Size(121, 22);
			this.asyncUploadBufferSize.TabIndex = 35;
			// 
			// asyncUploadTimeSlice
			// 
			this.asyncUploadTimeSlice.Location = new System.Drawing.Point(126, 204);
			this.asyncUploadTimeSlice.Name = "asyncUploadTimeSlice";
			this.asyncUploadTimeSlice.Size = new System.Drawing.Size(121, 22);
			this.asyncUploadTimeSlice.TabIndex = 34;
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(15, 176);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(105, 17);
			this.label17.TabIndex = 33;
			this.label17.Text = "Particle raycast";
			this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// particleRaycastBudget
			// 
			this.particleRaycastBudget.Location = new System.Drawing.Point(126, 173);
			this.particleRaycastBudget.Name = "particleRaycastBudget";
			this.particleRaycastBudget.Size = new System.Drawing.Size(121, 22);
			this.particleRaycastBudget.TabIndex = 28;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(53, 147);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(66, 17);
			this.label16.TabIndex = 32;
			this.label16.Text = "Max LOD";
			this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// maximumLODLevel
			// 
			this.maximumLODLevel.Location = new System.Drawing.Point(126, 145);
			this.maximumLODLevel.Name = "maximumLODLevel";
			this.maximumLODLevel.Size = new System.Drawing.Size(121, 22);
			this.maximumLODLevel.TabIndex = 31;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(53, 120);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(67, 17);
			this.label15.TabIndex = 30;
			this.label15.Text = "LOD bias";
			this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// lodBias
			// 
			this.lodBias.Location = new System.Drawing.Point(126, 117);
			this.lodBias.Name = "lodBias";
			this.lodBias.Size = new System.Drawing.Size(121, 22);
			this.lodBias.TabIndex = 28;
			// 
			// vsyncText
			// 
			this.vsyncText.AutoSize = true;
			this.vsyncText.Location = new System.Drawing.Point(66, 57);
			this.vsyncText.Name = "vsyncText";
			this.vsyncText.Size = new System.Drawing.Size(53, 17);
			this.vsyncText.TabIndex = 29;
			this.vsyncText.Text = "V-Sync";
			this.vsyncText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// vSyncCount
			// 
			this.vSyncCount.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.vSyncCount.FormattingEnabled = true;
			this.vSyncCount.Items.AddRange(new object[] {
            "0 (off)",
            "1 frame",
            "2 frames",
            "3 frames",
            "4 frames"});
			this.vSyncCount.Location = new System.Drawing.Point(125, 54);
			this.vSyncCount.Name = "vSyncCount";
			this.vSyncCount.Size = new System.Drawing.Size(121, 24);
			this.vSyncCount.TabIndex = 28;
			// 
			// blendWeights
			// 
			this.blendWeights.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.blendWeights.FormattingEnabled = true;
			this.blendWeights.Items.AddRange(new object[] {
            "One bone",
            "Two bones",
            "Four bones"});
			this.blendWeights.Location = new System.Drawing.Point(125, 22);
			this.blendWeights.Name = "blendWeights";
			this.blendWeights.Size = new System.Drawing.Size(121, 24);
			this.blendWeights.TabIndex = 28;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(24, 26);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(95, 17);
			this.label13.TabIndex = 28;
			this.label13.Text = "Blend weights";
			this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.shadowCascade2Split);
			this.groupBox2.Controls.Add(this.label12);
			this.groupBox2.Controls.Add(this.shadowCascades);
			this.groupBox2.Controls.Add(this.shadowNearPlaneOffset);
			this.groupBox2.Controls.Add(this.shadowDistance);
			this.groupBox2.Controls.Add(this.realtimeReflectionProbes);
			this.groupBox2.Controls.Add(this.shadowProjection);
			this.groupBox2.Controls.Add(this.shadowResolution);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.shadows);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(289, 47);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(266, 271);
			this.groupBox2.TabIndex = 5;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Shadows";
			// 
			// shadowCascade2Split
			// 
			this.shadowCascade2Split.Location = new System.Drawing.Point(128, 203);
			this.shadowCascade2Split.Name = "shadowCascade2Split";
			this.shadowCascade2Split.Size = new System.Drawing.Size(121, 22);
			this.shadowCascade2Split.TabIndex = 29;
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(22, 205);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(103, 17);
			this.label12.TabIndex = 28;
			this.label12.Text = "2-cascade split";
			this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// shadowCascades
			// 
			this.shadowCascades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.shadowCascades.FormattingEnabled = true;
			this.shadowCascades.Items.AddRange(new object[] {
            "0",
            "2",
            "4"});
			this.shadowCascades.Location = new System.Drawing.Point(128, 173);
			this.shadowCascades.Name = "shadowCascades";
			this.shadowCascades.Size = new System.Drawing.Size(121, 24);
			this.shadowCascades.TabIndex = 27;
			// 
			// shadowNearPlaneOffset
			// 
			this.shadowNearPlaneOffset.Location = new System.Drawing.Point(127, 144);
			this.shadowNearPlaneOffset.Name = "shadowNearPlaneOffset";
			this.shadowNearPlaneOffset.Size = new System.Drawing.Size(121, 22);
			this.shadowNearPlaneOffset.TabIndex = 26;
			// 
			// shadowDistance
			// 
			this.shadowDistance.Location = new System.Drawing.Point(127, 114);
			this.shadowDistance.Name = "shadowDistance";
			this.shadowDistance.Size = new System.Drawing.Size(121, 22);
			this.shadowDistance.TabIndex = 23;
			// 
			// realtimeReflectionProbes
			// 
			this.realtimeReflectionProbes.AutoSize = true;
			this.realtimeReflectionProbes.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.realtimeReflectionProbes.Location = new System.Drawing.Point(3, 236);
			this.realtimeReflectionProbes.Name = "realtimeReflectionProbes";
			this.realtimeReflectionProbes.Size = new System.Drawing.Size(141, 21);
			this.realtimeReflectionProbes.TabIndex = 12;
			this.realtimeReflectionProbes.Text = "Reflection probes";
			this.realtimeReflectionProbes.UseVisualStyleBackColor = true;
			// 
			// shadowProjection
			// 
			this.shadowProjection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.shadowProjection.FormattingEnabled = true;
			this.shadowProjection.Items.AddRange(new object[] {
            "Close fit",
            "Stable fit"});
			this.shadowProjection.Location = new System.Drawing.Point(127, 84);
			this.shadowProjection.Name = "shadowProjection";
			this.shadowProjection.Size = new System.Drawing.Size(121, 24);
			this.shadowProjection.TabIndex = 22;
			// 
			// shadowResolution
			// 
			this.shadowResolution.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.shadowResolution.FormattingEnabled = true;
			this.shadowResolution.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High",
            "Very high"});
			this.shadowResolution.Location = new System.Drawing.Point(127, 54);
			this.shadowResolution.Name = "shadowResolution";
			this.shadowResolution.Size = new System.Drawing.Size(121, 24);
			this.shadowResolution.TabIndex = 21;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(52, 176);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(70, 17);
			this.label11.TabIndex = 20;
			this.label11.Text = "Cascades";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(21, 146);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(101, 17);
			this.label10.TabIndex = 19;
			this.label10.Text = "Near plane ofs";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(59, 116);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(63, 17);
			this.label9.TabIndex = 18;
			this.label9.Text = "Distance";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(51, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(71, 17);
			this.label5.TabIndex = 17;
			this.label5.Text = "Projection";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(14, 57);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(109, 17);
			this.label4.TabIndex = 16;
			this.label4.Text = "Shadowmap res";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// shadows
			// 
			this.shadows.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.shadows.FormattingEnabled = true;
			this.shadows.Items.AddRange(new object[] {
            "Disable",
            "Hard only",
            "All"});
			this.shadows.Location = new System.Drawing.Point(127, 23);
			this.shadows.Name = "shadows";
			this.shadows.Size = new System.Drawing.Size(121, 24);
			this.shadows.TabIndex = 15;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(2, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 17);
			this.label2.TabIndex = 14;
			this.label2.Text = "Dynamic shadows";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// f_qualitySelect
			// 
			this.f_qualitySelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.f_qualitySelect.FormattingEnabled = true;
			this.f_qualitySelect.Items.AddRange(new object[] {
            "Custom",
            "Mode 0",
            "Mode 1",
            "Mode 2"});
			this.f_qualitySelect.Location = new System.Drawing.Point(148, 17);
			this.f_qualitySelect.Name = "f_qualitySelect";
			this.f_qualitySelect.Size = new System.Drawing.Size(121, 24);
			this.f_qualitySelect.TabIndex = 0;
			// 
			// groupBox1
			// 
			this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.groupBox1.Controls.Add(this.label20);
			this.groupBox1.Controls.Add(this.renderingPath);
			this.groupBox1.Controls.Add(this.softParticles);
			this.groupBox1.Controls.Add(this.pixelLightCount);
			this.groupBox1.Controls.Add(this.fullscreen);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.resolution);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.anisotropicFiltering);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.masterTextureLimit);
			this.groupBox1.Controls.Add(this.antiAliasing);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Location = new System.Drawing.Point(9, 47);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(273, 271);
			this.groupBox1.TabIndex = 4;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Rendering";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(29, 28);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(106, 17);
			this.label20.TabIndex = 32;
			this.label20.Text = "Rendering path";
			// 
			// renderingPath
			// 
			this.renderingPath.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.renderingPath.FormattingEnabled = true;
			this.renderingPath.Items.AddRange(new object[] {
            "Vertex lit",
            "Forward",
            "Deferred lighting",
            "Deferred shadows"});
			this.renderingPath.Location = new System.Drawing.Point(139, 25);
			this.renderingPath.Name = "renderingPath";
			this.renderingPath.Size = new System.Drawing.Size(121, 24);
			this.renderingPath.TabIndex = 30;
			// 
			// softParticles
			// 
			this.softParticles.AutoSize = true;
			this.softParticles.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.softParticles.Location = new System.Drawing.Point(43, 235);
			this.softParticles.Name = "softParticles";
			this.softParticles.Size = new System.Drawing.Size(112, 21);
			this.softParticles.TabIndex = 31;
			this.softParticles.Text = "Soft particles";
			this.softParticles.UseVisualStyleBackColor = true;
			// 
			// pixelLightCount
			// 
			this.pixelLightCount.Location = new System.Drawing.Point(139, 115);
			this.pixelLightCount.Name = "pixelLightCount";
			this.pixelLightCount.Size = new System.Drawing.Size(121, 22);
			this.pixelLightCount.TabIndex = 28;
			// 
			// fullscreen
			// 
			this.fullscreen.AutoSize = true;
			this.fullscreen.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.fullscreen.Location = new System.Drawing.Point(60, 56);
			this.fullscreen.Name = "fullscreen";
			this.fullscreen.Size = new System.Drawing.Size(95, 21);
			this.fullscreen.TabIndex = 13;
			this.fullscreen.Text = "Fullscreen";
			this.fullscreen.UseVisualStyleBackColor = true;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(34, 146);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(101, 17);
			this.label8.TabIndex = 11;
			this.label8.Text = "Texture quality";
			// 
			// resolution
			// 
			this.resolution.FormattingEnabled = true;
			this.resolution.Location = new System.Drawing.Point(139, 83);
			this.resolution.Name = "resolution";
			this.resolution.Size = new System.Drawing.Size(121, 24);
			this.resolution.TabIndex = 3;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(29, 117);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(106, 17);
			this.label7.TabIndex = 10;
			this.label7.Text = "Pixel light count";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 86);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(119, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "Screen resolution";
			// 
			// anisotropicFiltering
			// 
			this.anisotropicFiltering.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.anisotropicFiltering.FormattingEnabled = true;
			this.anisotropicFiltering.Items.AddRange(new object[] {
            "Disable",
            "Auto",
            "Forced"});
			this.anisotropicFiltering.Location = new System.Drawing.Point(139, 173);
			this.anisotropicFiltering.Name = "anisotropicFiltering";
			this.anisotropicFiltering.Size = new System.Drawing.Size(121, 24);
			this.anisotropicFiltering.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(7, 176);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(128, 17);
			this.label6.TabIndex = 8;
			this.label6.Text = "Anisotropic filtering";
			// 
			// masterTextureLimit
			// 
			this.masterTextureLimit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.masterTextureLimit.FormattingEnabled = true;
			this.masterTextureLimit.Items.AddRange(new object[] {
            "Full res",
            "1/2 res",
            "1/4 res",
            "1/8 res"});
			this.masterTextureLimit.Location = new System.Drawing.Point(139, 143);
			this.masterTextureLimit.Name = "masterTextureLimit";
			this.masterTextureLimit.Size = new System.Drawing.Size(121, 24);
			this.masterTextureLimit.TabIndex = 7;
			// 
			// antiAliasing
			// 
			this.antiAliasing.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.antiAliasing.FormattingEnabled = true;
			this.antiAliasing.Items.AddRange(new object[] {
            "None",
            "2x",
            "4x",
            "8x",
            "16x",
            "32x"});
			this.antiAliasing.Location = new System.Drawing.Point(139, 203);
			this.antiAliasing.Name = "antiAliasing";
			this.antiAliasing.Size = new System.Drawing.Size(121, 24);
			this.antiAliasing.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(87, 206);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(46, 17);
			this.label3.TabIndex = 2;
			this.label3.Text = "MSAA";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.watchFolder);
			this.tabPage2.Controls.Add(this.tumblr);
			this.tabPage2.Controls.Add(this.unlockH);
			this.tabPage2.Location = new System.Drawing.Point(4, 25);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(828, 331);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Game settings";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// unlockH
			// 
			this.unlockH.AutoSize = true;
			this.unlockH.Location = new System.Drawing.Point(20, 27);
			this.unlockH.Name = "unlockH";
			this.unlockH.Size = new System.Drawing.Size(199, 21);
			this.unlockH.TabIndex = 0;
			this.unlockH.Text = "Debug H (less exp checks)";
			this.unlockH.UseVisualStyleBackColor = true;
			// 
			// tumblr
			// 
			this.tumblr.AutoSize = true;
			this.tumblr.Location = new System.Drawing.Point(20, 55);
			this.tumblr.Name = "tumblr";
			this.tumblr.Size = new System.Drawing.Size(447, 21);
			this.tumblr.TabIndex = 1;
			this.tumblr.Text = "Allow both sexes in single gender card selection (editor, freeH etc)";
			this.tumblr.UseVisualStyleBackColor = true;
			// 
			// watchFolder
			// 
			this.watchFolder.AutoSize = true;
			this.watchFolder.Location = new System.Drawing.Point(20, 83);
			this.watchFolder.Name = "watchFolder";
			this.watchFolder.Size = new System.Drawing.Size(313, 21);
			this.watchFolder.TabIndex = 2;
			this.watchFolder.Text = "Watch card folders for changes during select";
			this.watchFolder.UseVisualStyleBackColor = true;
			// 
			// SettingsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(861, 472);
			this.Controls.Add(this.tabControl1);
			this.Controls.Add(this.launchButton);
			this.Name = "SettingsForm";
			this.Text = "Koikatu Patchwork";
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.Other.ResumeLayout(false);
			this.Other.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.GroupBox Other;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.TextBox asyncUploadBufferSize;
		private System.Windows.Forms.TextBox asyncUploadTimeSlice;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox particleRaycastBudget;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.TextBox maximumLODLevel;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.TextBox lodBias;
		private System.Windows.Forms.Label vsyncText;
		private System.Windows.Forms.ComboBox vSyncCount;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.ComboBox shadowCascades;
		private System.Windows.Forms.TextBox shadowNearPlaneOffset;
		private System.Windows.Forms.TextBox shadowDistance;
		private System.Windows.Forms.ComboBox shadowProjection;
		private System.Windows.Forms.ComboBox shadowResolution;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox shadows;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.TextBox pixelLightCount;
		private System.Windows.Forms.CheckBox realtimeReflectionProbes;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox anisotropicFiltering;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ComboBox masterTextureLimit;
		private System.Windows.Forms.Label label3;
		public System.Windows.Forms.CheckBox fullscreen;
		public System.Windows.Forms.ComboBox resolution;
		public System.Windows.Forms.ComboBox f_qualitySelect;
		public System.Windows.Forms.ComboBox antiAliasing;
		public System.Windows.Forms.Button launchButton;
		private System.Windows.Forms.TextBox shadowCascade2Split;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox softParticles;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.ComboBox renderingPath;
		private System.Windows.Forms.TextBox maxQueuedFrames;
		private System.Windows.Forms.ComboBox blendWeights;
		private System.Windows.Forms.LinkLabel linkUnityDoc;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.CheckBox tumblr;
		private System.Windows.Forms.CheckBox unlockH;
		private System.Windows.Forms.CheckBox watchFolder;
	}
}

