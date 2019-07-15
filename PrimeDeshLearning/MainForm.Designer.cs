namespace PrimeDeshLearning {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.WorkControlSplitPanel = new System.Windows.Forms.SplitContainer();
			this.WorkPanel = new System.Windows.Forms.FlowLayoutPanel();
			this.ChrsOtherSplitPanel = new System.Windows.Forms.SplitContainer();
			this.ChrsUsedPanel = new System.Windows.Forms.GroupBox();
			this.ChrsUsedTablePanel = new System.Windows.Forms.TableLayoutPanel();
			this.ChrsUsedEn = new System.Windows.Forms.TextBox();
			this.ChrsUsedPD = new System.Windows.Forms.TextBox();
			this.ChrsUsedPDLbl = new System.Windows.Forms.Label();
			this.ChrsUsedENLbl = new System.Windows.Forms.Label();
			this.PD2ENOtherSplitPanel = new System.Windows.Forms.SplitContainer();
			this.PD2ENPanel = new System.Windows.Forms.GroupBox();
			this.PD2EN100 = new System.Windows.Forms.Button();
			this.PDToENMark = new System.Windows.Forms.Button();
			this.PD2EN10 = new System.Windows.Forms.Button();
			this.ResultsOtherSplitPanel = new System.Windows.Forms.SplitContainer();
			this.ResultsPanel = new System.Windows.Forms.GroupBox();
			this.Reset = new System.Windows.Forms.Button();
			this.ResQs = new System.Windows.Forms.TextBox();
			this.ResSlashLbl = new System.Windows.Forms.Label();
			this.ResCorrect = new System.Windows.Forms.TextBox();
			this.ResCorrectLbl = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.WorkControlSplitPanel)).BeginInit();
			this.WorkControlSplitPanel.Panel1.SuspendLayout();
			this.WorkControlSplitPanel.Panel2.SuspendLayout();
			this.WorkControlSplitPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ChrsOtherSplitPanel)).BeginInit();
			this.ChrsOtherSplitPanel.Panel1.SuspendLayout();
			this.ChrsOtherSplitPanel.Panel2.SuspendLayout();
			this.ChrsOtherSplitPanel.SuspendLayout();
			this.ChrsUsedPanel.SuspendLayout();
			this.ChrsUsedTablePanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.PD2ENOtherSplitPanel)).BeginInit();
			this.PD2ENOtherSplitPanel.Panel1.SuspendLayout();
			this.PD2ENOtherSplitPanel.Panel2.SuspendLayout();
			this.PD2ENOtherSplitPanel.SuspendLayout();
			this.PD2ENPanel.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ResultsOtherSplitPanel)).BeginInit();
			this.ResultsOtherSplitPanel.Panel2.SuspendLayout();
			this.ResultsOtherSplitPanel.SuspendLayout();
			this.ResultsPanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// WorkControlSplitPanel
			// 
			this.WorkControlSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.WorkControlSplitPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.WorkControlSplitPanel.Location = new System.Drawing.Point(0, 0);
			this.WorkControlSplitPanel.Name = "WorkControlSplitPanel";
			// 
			// WorkControlSplitPanel.Panel1
			// 
			this.WorkControlSplitPanel.Panel1.Controls.Add(this.WorkPanel);
			// 
			// WorkControlSplitPanel.Panel2
			// 
			this.WorkControlSplitPanel.Panel2.Controls.Add(this.ChrsOtherSplitPanel);
			this.WorkControlSplitPanel.Size = new System.Drawing.Size(1063, 573);
			this.WorkControlSplitPanel.SplitterDistance = 514;
			this.WorkControlSplitPanel.TabIndex = 0;
			// 
			// WorkPanel
			// 
			this.WorkPanel.AutoScroll = true;
			this.WorkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.WorkPanel.Location = new System.Drawing.Point(0, 0);
			this.WorkPanel.Name = "WorkPanel";
			this.WorkPanel.Size = new System.Drawing.Size(514, 573);
			this.WorkPanel.TabIndex = 0;
			// 
			// ChrsOtherSplitPanel
			// 
			this.ChrsOtherSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChrsOtherSplitPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
			this.ChrsOtherSplitPanel.Location = new System.Drawing.Point(0, 0);
			this.ChrsOtherSplitPanel.Name = "ChrsOtherSplitPanel";
			this.ChrsOtherSplitPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// ChrsOtherSplitPanel.Panel1
			// 
			this.ChrsOtherSplitPanel.Panel1.Controls.Add(this.ChrsUsedPanel);
			// 
			// ChrsOtherSplitPanel.Panel2
			// 
			this.ChrsOtherSplitPanel.Panel2.Controls.Add(this.PD2ENOtherSplitPanel);
			this.ChrsOtherSplitPanel.Size = new System.Drawing.Size(545, 573);
			this.ChrsOtherSplitPanel.SplitterDistance = 109;
			this.ChrsOtherSplitPanel.TabIndex = 0;
			// 
			// ChrsUsedPanel
			// 
			this.ChrsUsedPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.ChrsUsedPanel.Controls.Add(this.ChrsUsedTablePanel);
			this.ChrsUsedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChrsUsedPanel.Location = new System.Drawing.Point(0, 0);
			this.ChrsUsedPanel.Name = "ChrsUsedPanel";
			this.ChrsUsedPanel.Size = new System.Drawing.Size(545, 109);
			this.ChrsUsedPanel.TabIndex = 3;
			this.ChrsUsedPanel.TabStop = false;
			this.ChrsUsedPanel.Text = "Characters Used";
			// 
			// ChrsUsedTablePanel
			// 
			this.ChrsUsedTablePanel.ColumnCount = 2;
			this.ChrsUsedTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
			this.ChrsUsedTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.ChrsUsedTablePanel.Controls.Add(this.ChrsUsedPD, 1, 1);
			this.ChrsUsedTablePanel.Controls.Add(this.ChrsUsedPDLbl, 0, 1);
			this.ChrsUsedTablePanel.Controls.Add(this.ChrsUsedENLbl, 0, 0);
			this.ChrsUsedTablePanel.Controls.Add(this.ChrsUsedEn, 1, 0);
			this.ChrsUsedTablePanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ChrsUsedTablePanel.Location = new System.Drawing.Point(3, 16);
			this.ChrsUsedTablePanel.Name = "ChrsUsedTablePanel";
			this.ChrsUsedTablePanel.RowCount = 2;
			this.ChrsUsedTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.ChrsUsedTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
			this.ChrsUsedTablePanel.Size = new System.Drawing.Size(539, 90);
			this.ChrsUsedTablePanel.TabIndex = 0;
			// 
			// ChrsUsedEn
			// 
			this.ChrsUsedEn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ChrsUsedEn.BackColor = System.Drawing.SystemColors.Control;
			this.ChrsUsedEn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ChrsUsedEn.Location = new System.Drawing.Point(73, 10);
			this.ChrsUsedEn.Name = "ChrsUsedEn";
			this.ChrsUsedEn.Size = new System.Drawing.Size(463, 20);
			this.ChrsUsedEn.TabIndex = 0;
			this.ChrsUsedEn.TextChanged += new System.EventHandler(this.ChrsUsed_TextChanged);
			// 
			// ChrsUsedPD
			// 
			this.ChrsUsedPD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ChrsUsedPD.BackColor = System.Drawing.SystemColors.Control;
			this.ChrsUsedPD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ChrsUsedPD.Font = new System.Drawing.Font("PrimeDesh", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ChrsUsedPD.Location = new System.Drawing.Point(73, 55);
			this.ChrsUsedPD.Name = "ChrsUsedPD";
			this.ChrsUsedPD.Size = new System.Drawing.Size(463, 20);
			this.ChrsUsedPD.TabIndex = 3;
			this.ChrsUsedPD.TextChanged += new System.EventHandler(this.ChrsUsed_TextChanged);
			// 
			// ChrsUsedPDLbl
			// 
			this.ChrsUsedPDLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ChrsUsedPDLbl.AutoSize = true;
			this.ChrsUsedPDLbl.Location = new System.Drawing.Point(3, 58);
			this.ChrsUsedPDLbl.Name = "ChrsUsedPDLbl";
			this.ChrsUsedPDLbl.Size = new System.Drawing.Size(64, 13);
			this.ChrsUsedPDLbl.TabIndex = 2;
			this.ChrsUsedPDLbl.Text = "Prime Desh:";
			// 
			// ChrsUsedENLbl
			// 
			this.ChrsUsedENLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
			this.ChrsUsedENLbl.AutoSize = true;
			this.ChrsUsedENLbl.Location = new System.Drawing.Point(3, 13);
			this.ChrsUsedENLbl.Name = "ChrsUsedENLbl";
			this.ChrsUsedENLbl.Size = new System.Drawing.Size(64, 13);
			this.ChrsUsedENLbl.TabIndex = 1;
			this.ChrsUsedENLbl.Text = "English:";
			// 
			// PD2ENOtherSplitPanel
			// 
			this.PD2ENOtherSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PD2ENOtherSplitPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.PD2ENOtherSplitPanel.Location = new System.Drawing.Point(0, 0);
			this.PD2ENOtherSplitPanel.Name = "PD2ENOtherSplitPanel";
			// 
			// PD2ENOtherSplitPanel.Panel1
			// 
			this.PD2ENOtherSplitPanel.Panel1.Controls.Add(this.PD2ENPanel);
			// 
			// PD2ENOtherSplitPanel.Panel2
			// 
			this.PD2ENOtherSplitPanel.Panel2.Controls.Add(this.ResultsOtherSplitPanel);
			this.PD2ENOtherSplitPanel.Size = new System.Drawing.Size(545, 460);
			this.PD2ENOtherSplitPanel.SplitterDistance = 177;
			this.PD2ENOtherSplitPanel.TabIndex = 0;
			// 
			// PD2ENPanel
			// 
			this.PD2ENPanel.Controls.Add(this.PD2EN100);
			this.PD2ENPanel.Controls.Add(this.PDToENMark);
			this.PD2ENPanel.Controls.Add(this.PD2EN10);
			this.PD2ENPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PD2ENPanel.Location = new System.Drawing.Point(0, 0);
			this.PD2ENPanel.Name = "PD2ENPanel";
			this.PD2ENPanel.Size = new System.Drawing.Size(177, 460);
			this.PD2ENPanel.TabIndex = 1;
			this.PD2ENPanel.TabStop = false;
			this.PD2ENPanel.Text = "Prime Desh to English";
			// 
			// PD2EN100
			// 
			this.PD2EN100.Location = new System.Drawing.Point(6, 77);
			this.PD2EN100.Name = "PD2EN100";
			this.PD2EN100.Size = new System.Drawing.Size(75, 23);
			this.PD2EN100.TabIndex = 2;
			this.PD2EN100.TabStop = false;
			this.PD2EN100.Text = "+100";
			this.PD2EN100.UseVisualStyleBackColor = true;
			this.PD2EN100.Click += new System.EventHandler(this.PD2EN100_Click);
			// 
			// PDToENMark
			// 
			this.PDToENMark.Location = new System.Drawing.Point(6, 19);
			this.PDToENMark.Name = "PDToENMark";
			this.PDToENMark.Size = new System.Drawing.Size(75, 23);
			this.PDToENMark.TabIndex = 1;
			this.PDToENMark.TabStop = false;
			this.PDToENMark.Text = "Mark";
			this.PDToENMark.UseVisualStyleBackColor = true;
			this.PDToENMark.Click += new System.EventHandler(this.PDToENMark_Click);
			// 
			// PD2EN10
			// 
			this.PD2EN10.Location = new System.Drawing.Point(6, 48);
			this.PD2EN10.Name = "PD2EN10";
			this.PD2EN10.Size = new System.Drawing.Size(75, 23);
			this.PD2EN10.TabIndex = 0;
			this.PD2EN10.TabStop = false;
			this.PD2EN10.Text = "+10";
			this.PD2EN10.UseVisualStyleBackColor = true;
			this.PD2EN10.Click += new System.EventHandler(this.PD2EN10_Click);
			// 
			// ResultsOtherSplitPanel
			// 
			this.ResultsOtherSplitPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ResultsOtherSplitPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
			this.ResultsOtherSplitPanel.Location = new System.Drawing.Point(0, 0);
			this.ResultsOtherSplitPanel.Name = "ResultsOtherSplitPanel";
			this.ResultsOtherSplitPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// ResultsOtherSplitPanel.Panel2
			// 
			this.ResultsOtherSplitPanel.Panel2.Controls.Add(this.ResultsPanel);
			this.ResultsOtherSplitPanel.Size = new System.Drawing.Size(364, 460);
			this.ResultsOtherSplitPanel.SplitterDistance = 315;
			this.ResultsOtherSplitPanel.TabIndex = 0;
			// 
			// ResultsPanel
			// 
			this.ResultsPanel.Controls.Add(this.Reset);
			this.ResultsPanel.Controls.Add(this.ResQs);
			this.ResultsPanel.Controls.Add(this.ResSlashLbl);
			this.ResultsPanel.Controls.Add(this.ResCorrect);
			this.ResultsPanel.Controls.Add(this.ResCorrectLbl);
			this.ResultsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.ResultsPanel.Location = new System.Drawing.Point(0, 0);
			this.ResultsPanel.Name = "ResultsPanel";
			this.ResultsPanel.Size = new System.Drawing.Size(364, 141);
			this.ResultsPanel.TabIndex = 2;
			this.ResultsPanel.TabStop = false;
			this.ResultsPanel.Text = "Results";
			// 
			// Reset
			// 
			this.Reset.Location = new System.Drawing.Point(6, 52);
			this.Reset.Name = "Reset";
			this.Reset.Size = new System.Drawing.Size(75, 23);
			this.Reset.TabIndex = 4;
			this.Reset.TabStop = false;
			this.Reset.Text = "Reset";
			this.Reset.UseVisualStyleBackColor = true;
			this.Reset.Click += new System.EventHandler(this.Reset_Click);
			// 
			// ResQs
			// 
			this.ResQs.BackColor = System.Drawing.SystemColors.Control;
			this.ResQs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ResQs.Location = new System.Drawing.Point(120, 26);
			this.ResQs.Name = "ResQs";
			this.ResQs.ReadOnly = true;
			this.ResQs.Size = new System.Drawing.Size(39, 20);
			this.ResQs.TabIndex = 3;
			this.ResQs.TabStop = false;
			// 
			// ResSlashLbl
			// 
			this.ResSlashLbl.AutoSize = true;
			this.ResSlashLbl.Location = new System.Drawing.Point(102, 28);
			this.ResSlashLbl.Name = "ResSlashLbl";
			this.ResSlashLbl.Size = new System.Drawing.Size(12, 13);
			this.ResSlashLbl.TabIndex = 2;
			this.ResSlashLbl.Text = "/";
			// 
			// ResCorrect
			// 
			this.ResCorrect.BackColor = System.Drawing.SystemColors.Control;
			this.ResCorrect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ResCorrect.Location = new System.Drawing.Point(57, 26);
			this.ResCorrect.Name = "ResCorrect";
			this.ResCorrect.ReadOnly = true;
			this.ResCorrect.Size = new System.Drawing.Size(39, 20);
			this.ResCorrect.TabIndex = 1;
			this.ResCorrect.TabStop = false;
			// 
			// ResCorrectLbl
			// 
			this.ResCorrectLbl.AutoSize = true;
			this.ResCorrectLbl.Location = new System.Drawing.Point(7, 28);
			this.ResCorrectLbl.Name = "ResCorrectLbl";
			this.ResCorrectLbl.Size = new System.Drawing.Size(44, 13);
			this.ResCorrectLbl.TabIndex = 0;
			this.ResCorrectLbl.Text = "Correct:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1063, 573);
			this.Controls.Add(this.WorkControlSplitPanel);
			this.Name = "MainForm";
			this.Text = "Prime Desh Teacher";
			this.WorkControlSplitPanel.Panel1.ResumeLayout(false);
			this.WorkControlSplitPanel.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WorkControlSplitPanel)).EndInit();
			this.WorkControlSplitPanel.ResumeLayout(false);
			this.ChrsOtherSplitPanel.Panel1.ResumeLayout(false);
			this.ChrsOtherSplitPanel.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ChrsOtherSplitPanel)).EndInit();
			this.ChrsOtherSplitPanel.ResumeLayout(false);
			this.ChrsUsedPanel.ResumeLayout(false);
			this.ChrsUsedTablePanel.ResumeLayout(false);
			this.ChrsUsedTablePanel.PerformLayout();
			this.PD2ENOtherSplitPanel.Panel1.ResumeLayout(false);
			this.PD2ENOtherSplitPanel.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.PD2ENOtherSplitPanel)).EndInit();
			this.PD2ENOtherSplitPanel.ResumeLayout(false);
			this.PD2ENPanel.ResumeLayout(false);
			this.ResultsOtherSplitPanel.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.ResultsOtherSplitPanel)).EndInit();
			this.ResultsOtherSplitPanel.ResumeLayout(false);
			this.ResultsPanel.ResumeLayout(false);
			this.ResultsPanel.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer WorkControlSplitPanel;
		private System.Windows.Forms.FlowLayoutPanel WorkPanel;
		private System.Windows.Forms.GroupBox PD2ENPanel;
		private System.Windows.Forms.Button PD2EN10;
		private System.Windows.Forms.Button PDToENMark;
		private System.Windows.Forms.GroupBox ResultsPanel;
		private System.Windows.Forms.TextBox ResQs;
		private System.Windows.Forms.Label ResSlashLbl;
		private System.Windows.Forms.TextBox ResCorrect;
		private System.Windows.Forms.Label ResCorrectLbl;
		private System.Windows.Forms.Button Reset;
		private System.Windows.Forms.Button PD2EN100;
		private System.Windows.Forms.GroupBox ChrsUsedPanel;
		private System.Windows.Forms.TextBox ChrsUsedPD;
		private System.Windows.Forms.Label ChrsUsedPDLbl;
		private System.Windows.Forms.Label ChrsUsedENLbl;
		private System.Windows.Forms.TextBox ChrsUsedEn;
		private System.Windows.Forms.SplitContainer ChrsOtherSplitPanel;
		private System.Windows.Forms.SplitContainer PD2ENOtherSplitPanel;
		private System.Windows.Forms.SplitContainer ResultsOtherSplitPanel;
		private System.Windows.Forms.TableLayoutPanel ChrsUsedTablePanel;
	}
}

