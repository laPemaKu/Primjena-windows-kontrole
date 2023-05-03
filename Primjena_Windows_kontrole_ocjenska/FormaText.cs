using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primjena_Windows_kontrole_ocjenska
{
    public partial class FormaText : Form
    {
        public FormaText()
        {
            InitializeComponent();
        }
        string name, description;

        public string Name1 { get => name; set => name = value; }
        public string Description { get => description; set => description = value; }

        private void btnOk_Click(object sender, EventArgs e)
        {
            name = txtProgramName.Text; 
            description = txtProgramDescription.Text;
            DialogResult = DialogResult.OK;
        }
    }
}
