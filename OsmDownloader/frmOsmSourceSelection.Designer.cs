namespace OsmDownloader
{
	public partial class frmOsmSourceSelection
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
            this.tvOsmSources = new System.Windows.Forms.TreeView();
            this.btnReadSources = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsLblOsmSourceUrl = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblDownloadState = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbViewpanorama = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkFiletypePOLY = new System.Windows.Forms.CheckBox();
            this.chkFiletypeHGT = new System.Windows.Forms.CheckBox();
            this.chkFiletypeOSMPBF = new System.Windows.Forms.CheckBox();
            this.chkFiletypeOSM = new System.Windows.Forms.CheckBox();
            this.btnDownload = new System.Windows.Forms.Button();
            this.ckbLatestOnly = new System.Windows.Forms.CheckBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvOsmSources
            // 
            this.tvOsmSources.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tvOsmSources.CheckBoxes = true;
            this.tvOsmSources.Location = new System.Drawing.Point(16, 129);
            this.tvOsmSources.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tvOsmSources.Name = "tvOsmSources";
            this.tvOsmSources.Size = new System.Drawing.Size(788, 543);
            this.tvOsmSources.TabIndex = 0;
            this.tvOsmSources.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterCheck);
            this.tvOsmSources.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.treeView1_NodeMouseHover);
            // 
            // btnReadSources
            // 
            this.btnReadSources.Location = new System.Drawing.Point(16, 15);
            this.btnReadSources.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReadSources.Name = "btnReadSources";
            this.btnReadSources.Size = new System.Drawing.Size(136, 54);
            this.btnReadSources.TabIndex = 1;
            this.btnReadSources.Text = "Read Sources";
            this.btnReadSources.UseVisualStyleBackColor = true;
            this.btnReadSources.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsLblOsmSourceUrl,
            this.toolStripStatusLabel1,
            this.lblDownloadState});
            this.statusStrip1.Location = new System.Drawing.Point(0, 679);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(817, 25);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsLblOsmSourceUrl
            // 
            this.tsLblOsmSourceUrl.Name = "tsLblOsmSourceUrl";
            this.tsLblOsmSourceUrl.Size = new System.Drawing.Size(50, 20);
            this.tsLblOsmSourceUrl.Text = "Ready";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right)));
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(4, 20);
            // 
            // lblDownloadState
            // 
            this.lblDownloadState.Name = "lblDownloadState";
            this.lblDownloadState.Size = new System.Drawing.Size(0, 20);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbViewpanorama);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(160, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(248, 54);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[ Source-Provider ]";
            // 
            // rbViewpanorama
            // 
            this.rbViewpanorama.AutoSize = true;
            this.rbViewpanorama.Location = new System.Drawing.Point(112, 26);
            this.rbViewpanorama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbViewpanorama.Name = "rbViewpanorama";
            this.rbViewpanorama.Size = new System.Drawing.Size(126, 21);
            this.rbViewpanorama.TabIndex = 1;
            this.rbViewpanorama.Text = "View panorama";
            this.rbViewpanorama.UseVisualStyleBackColor = true;
            this.rbViewpanorama.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(9, 25);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(91, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Geofabrik";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ckbLatestOnly);
            this.groupBox2.Controls.Add(this.chkFiletypePOLY);
            this.groupBox2.Controls.Add(this.chkFiletypeHGT);
            this.groupBox2.Controls.Add(this.chkFiletypeOSMPBF);
            this.groupBox2.Controls.Add(this.chkFiletypeOSM);
            this.groupBox2.Location = new System.Drawing.Point(417, 16);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(267, 106);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[ Filetypes ]";
            // 
            // chkFiletypePOLY
            // 
            this.chkFiletypePOLY.AutoSize = true;
            this.chkFiletypePOLY.Location = new System.Drawing.Point(9, 80);
            this.chkFiletypePOLY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFiletypePOLY.Name = "chkFiletypePOLY";
            this.chkFiletypePOLY.Size = new System.Drawing.Size(56, 21);
            this.chkFiletypePOLY.TabIndex = 3;
            this.chkFiletypePOLY.Tag = "poly";
            this.chkFiletypePOLY.Text = "poly";
            this.chkFiletypePOLY.UseVisualStyleBackColor = true;
            // 
            // chkFiletypeHGT
            // 
            this.chkFiletypeHGT.AutoSize = true;
            this.chkFiletypeHGT.Enabled = false;
            this.chkFiletypeHGT.Location = new System.Drawing.Point(124, 23);
            this.chkFiletypeHGT.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFiletypeHGT.Name = "chkFiletypeHGT";
            this.chkFiletypeHGT.Size = new System.Drawing.Size(82, 21);
            this.chkFiletypeHGT.TabIndex = 2;
            this.chkFiletypeHGT.Tag = "zip";
            this.chkFiletypeHGT.Text = "zip (hgt)";
            this.chkFiletypeHGT.UseVisualStyleBackColor = true;
            // 
            // chkFiletypeOSMPBF
            // 
            this.chkFiletypeOSMPBF.AutoSize = true;
            this.chkFiletypeOSMPBF.Checked = true;
            this.chkFiletypeOSMPBF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiletypeOSMPBF.Location = new System.Drawing.Point(9, 52);
            this.chkFiletypeOSMPBF.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFiletypeOSMPBF.Name = "chkFiletypeOSMPBF";
            this.chkFiletypeOSMPBF.Size = new System.Drawing.Size(80, 21);
            this.chkFiletypeOSMPBF.TabIndex = 1;
            this.chkFiletypeOSMPBF.Tag = "osm.pbf";
            this.chkFiletypeOSMPBF.Text = "osm.pbf";
            this.chkFiletypeOSMPBF.UseVisualStyleBackColor = true;
            // 
            // chkFiletypeOSM
            // 
            this.chkFiletypeOSM.AutoSize = true;
            this.chkFiletypeOSM.Checked = true;
            this.chkFiletypeOSM.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkFiletypeOSM.Location = new System.Drawing.Point(9, 25);
            this.chkFiletypeOSM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkFiletypeOSM.Name = "chkFiletypeOSM";
            this.chkFiletypeOSM.Size = new System.Drawing.Size(56, 21);
            this.chkFiletypeOSM.TabIndex = 0;
            this.chkFiletypeOSM.Tag = "osm";
            this.chkFiletypeOSM.Text = "osm";
            this.chkFiletypeOSM.UseVisualStyleBackColor = true;
            // 
            // btnDownload
            // 
            this.btnDownload.Location = new System.Drawing.Point(16, 76);
            this.btnDownload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(136, 46);
            this.btnDownload.TabIndex = 5;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = true;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // ckbLatestOnly
            // 
            this.ckbLatestOnly.AutoSize = true;
            this.ckbLatestOnly.Location = new System.Drawing.Point(124, 52);
            this.ckbLatestOnly.Name = "ckbLatestOnly";
            this.ckbLatestOnly.Size = new System.Drawing.Size(135, 21);
            this.ckbLatestOnly.TabIndex = 4;
            this.ckbLatestOnly.Text = "Geofabrik Latest";
            this.ckbLatestOnly.UseVisualStyleBackColor = true;
            // 
            // frmOsmSourceSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 704);
            this.Controls.Add(this.btnDownload);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnReadSources);
            this.Controls.Add(this.tvOsmSources);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(713, 426);
            this.Name = "frmOsmSourceSelection";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TreeView tvOsmSources;
		private System.Windows.Forms.Button btnReadSources;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel tsLblOsmSourceUrl;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton rbViewpanorama;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.CheckBox chkFiletypePOLY;
		private System.Windows.Forms.CheckBox chkFiletypeHGT;
		private System.Windows.Forms.CheckBox chkFiletypeOSMPBF;
		private System.Windows.Forms.CheckBox chkFiletypeOSM;
		private System.Windows.Forms.Button btnDownload;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
		private System.Windows.Forms.ToolStripStatusLabel lblDownloadState;
        private System.Windows.Forms.CheckBox ckbLatestOnly;
    }
}

