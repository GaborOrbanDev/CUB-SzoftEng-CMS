using CMS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMS
{
    public partial class ÚjCikk : Form
    {
        ArticleContext context = new();
        public ÚjCikk()
        {
            InitializeComponent();
            comboBoxColumn.DataSource = context.Columns.ToList();
            comboBoxColumn.DisplayMember = "Name";
        }

        void Validál()
        {
            if(string.IsNullOrEmpty(textBoxTitle.Text) && string.IsNullOrEmpty(richTextBoxText.Text))
            {
                errorProvider1.SetError(textBoxTitle, "Nem lehet üres");
                errorProvider1.SetError(richTextBoxText, "Nem lehet üres");
                hozzáadás.Enabled = false;
            }
            else if(string.IsNullOrEmpty(textBoxTitle.Text))
            {
                errorProvider1.SetError(textBoxTitle, "Nem lehet üres");
                errorProvider1.SetError(richTextBoxText, string.Empty);
                hozzáadás.Enabled = false;
            }
            else if (string.IsNullOrEmpty(richTextBoxText.Text))
            {
                errorProvider1.SetError(textBoxTitle, string.Empty);
                errorProvider1.SetError(richTextBoxText, "Nem lehet üres");
                hozzáadás.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(textBoxTitle, string.Empty);
                errorProvider1.SetError(richTextBoxText, string.Empty);
                hozzáadás.Enabled = true;
            }
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            Validál();
        }

        private void richTextBoxText_TextChanged(object sender, EventArgs e)
        {
            Validál();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void hozzáadás_Click(object sender, EventArgs e)
        {
            DialogResult=DialogResult.OK;
            Close();
        }
    }
}
