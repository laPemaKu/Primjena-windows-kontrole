using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Primjena_Windows_kontrole_ocjenska
{
    public partial class FormaPrograma : Form
    {
        public FormaPrograma()
        {
            InitializeComponent();
        }

        private void btnRunProgram_Click(object sender, EventArgs e)
        {
            string program = (string)cbxRunProgram.SelectedItem;
            Process.Start(program);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                gbxRunProgram.Visible = true;
            }
            else
            {
                gbxRunProgram.Visible = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtProgramDescription.Clear();
            txtProgramName.Clear();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko drugo dugme", "Obavještenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText frm = new FormaText();
            if(frm.ShowDialog() == DialogResult.OK)
            {
                txtProgramName.AppendText(frm.Name1);
                txtProgramDescription.AppendText(frm.Description);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Da li ste sigurni da želite da zatvorite aplikaciju?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                this.Close();
            }
            
        }
    }
}
