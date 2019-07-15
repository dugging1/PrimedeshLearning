namespace PrimeDeshLearning {
	partial class PdToEn {
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.PD = new System.Windows.Forms.TextBox();
			this.INP = new System.Windows.Forms.TextBox();
			this.Answer = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// PD
			// 
			this.PD.BackColor = System.Drawing.SystemColors.Control;
			this.PD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.PD.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.PD.Font = new System.Drawing.Font("PrimeDesh", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.PD.Location = new System.Drawing.Point(3, 3);
			this.PD.Name = "PD";
			this.PD.ReadOnly = true;
			this.PD.ShortcutsEnabled = false;
			this.PD.Size = new System.Drawing.Size(21, 22);
			this.PD.TabIndex = 0;
			this.PD.TabStop = false;
			// 
			// INP
			// 
			this.INP.BackColor = System.Drawing.SystemColors.Control;
			this.INP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.INP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.INP.Location = new System.Drawing.Point(30, 3);
			this.INP.Name = "INP";
			this.INP.ShortcutsEnabled = false;
			this.INP.Size = new System.Drawing.Size(22, 23);
			this.INP.TabIndex = 1;
			this.INP.TextChanged += new System.EventHandler(this.INP_TextChanged);
			// 
			// Answer
			// 
			this.Answer.BackColor = System.Drawing.SystemColors.Control;
			this.Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Answer.Location = new System.Drawing.Point(76, 3);
			this.Answer.Name = "Answer";
			this.Answer.ReadOnly = true;
			this.Answer.Size = new System.Drawing.Size(22, 23);
			this.Answer.TabIndex = 2;
			this.Answer.TabStop = false;
			this.Answer.Visible = false;
			// 
			// PdToEn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.Controls.Add(this.Answer);
			this.Controls.Add(this.INP);
			this.Controls.Add(this.PD);
			this.Name = "PdToEn";
			this.Size = new System.Drawing.Size(101, 31);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox PD;
		private System.Windows.Forms.TextBox INP;
		private System.Windows.Forms.TextBox Answer;
	}
}
