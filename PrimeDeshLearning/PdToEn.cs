using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeDeshLearning {
	public partial class PdToEn : UserControl {
		public static string chrs = "qwertyuiopasdfghjklzxcvbnm";
		private static Random rand = new Random();
		private string chr;

		public bool Correct { get => mark(); }

		public PdToEn(Control parent) {
			InitializeComponent();
			parent.Controls.Add(this);
			chr = chrs[rand.Next(chrs.Length)].ToString().ToUpper();
			PD.Text = chr;
			Answer.Text = chr;
		}

		private void INP_TextChanged(object sender, EventArgs e) {
			if (((TextBox)sender).Text.Length > 1)
				((TextBox)sender).Text = ((TextBox)sender).Text.Substring(0, 1);
		}

		public void Reveal() {
			Answer.Show();
			if (Correct)
				Answer.BackColor = Color.Green;
			else
				Answer.BackColor = Color.Red;
		}

		private static string[] sames = { "UV", "QK" };
		private bool mark() {
			if (INP.Text.Length == 0)
				return false;
			char inp = INP.Text.ToUpper()[0];
			char ans = chr.ToUpper()[0];
			foreach (string s in sames) {
				if (s.Contains(ans) && s.Contains(inp))
					return true;
			}
			return inp.Equals(ans);
		}
	}
}
