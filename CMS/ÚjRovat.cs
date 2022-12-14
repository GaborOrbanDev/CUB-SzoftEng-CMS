using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class ÚjRovat : Form
    {
        public ÚjRovat()
        {
            InitializeComponent();
        }

        private void rovatCím_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex("^[A-Z]");
            if (regex.IsMatch(rovatCím.Text))
            {
                errorProvider1.SetError(rovatCím, string.Empty);
                hozzáadás.Enabled = true;
            }
            else
            {
                errorProvider1.SetError(rovatCím, "A rovat címének nagybetűvel kell kezdődnie");
                hozzáadás.Enabled = false;
            }
        }

        private void mégse_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void hozzáadás_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
