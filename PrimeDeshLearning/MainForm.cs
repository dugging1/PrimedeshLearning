using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeDeshLearning {
	public partial class MainForm : Form {
		private List<PdToEn> qs = new List<PdToEn>();

		public MainForm() {
			InitializeComponent();
			ChrsUsedEn.Text = PdToEn.chrs;
			ChrsUsedPD.Text = PdToEn.chrs;
		}

		private void PD2ENaddN(int n) {
			for(int i=0;i<n;i++)
				qs.Add(new PdToEn(WorkPanel));
		}

		private void PD2EN10_Click(object sender, EventArgs e) => PD2ENaddN(10);
		private void PD2EN100_Click(object sender, EventArgs e) => PD2ENaddN(100);

		private void PDToENMark_Click(object sender, EventArgs e) {
			ResQs.Text = qs.Count.ToString();
			ResCorrect.Text = qs.Select((PdToEn p) => p.Correct).Select((bool b) => Convert.ToInt32(b)).Aggregate((int l, int r) => l+r).ToString();
			WorkPanel.Hide();
			qs.ForEach((PdToEn p) => p.Reveal());
			WorkPanel.Show();
		}

		private void Reset_Click(object sender, EventArgs e) {
			qs = new List<PdToEn>();
			ResQs.Text = "";
			ResCorrect.Text = "";
			WorkPanel.Hide();
			WorkPanel.Controls.Clear();
			WorkPanel.Show();
		}

		private void ChrsUsed_TextChanged(object sender, EventArgs e) {
			TextBox t = (TextBox)sender;
			if (t.Text.Substring(0, t.Text.Length-1).Contains(t.Text[t.Text.Length-1]))
				t.Text = t.Text.Substring(0, t.Text.Length-1);
			else {
				PdToEn.chrs = t.Text;
				ChrsUsedEn.Text = t.Text;
				ChrsUsedPD.Text = t.Text;
			}
		}
	}
}
