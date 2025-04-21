using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerControl
{
    public partial class FrmNameEntry : Form
    {
        public string InputText = string.Empty;
        public FrmNameEntry(string title, string prompt)
        {
            InitializeComponent();
            this.Text = title;
            lblNameEntry.Text = prompt;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            InputText = txtName.Text;
            this.DialogResult = DialogResult.OK;

        }
    }
}
