using CMS.Models;

namespace CMS
{
    public partial class Form1 : Form
    {
        ArticleContext context = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            columnsBindingSource.DataSource = context.Columns.ToList();
            CikkekBetöltése();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Biztos, hogy be akarja zárni az ablakot?", "Üzenet", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void textBoxColumn_TextChanged(object sender, EventArgs e)
        {
            RovatokBetöltése();
        }

        private void RovatokBetöltése()
        {
            var rovatok = from r in context.Columns
                          where r.Name.Contains(textBoxColumn.Text)
                          select r;
            columnsBindingSource.DataSource = rovatok.ToList();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            CikkekBetöltése();
        }

        private void CikkekBetöltése()
        {
            var kiválasztott = (Columns)comboBox1.SelectedItem;
            if (kiválasztott is not null)
            {
                var cikkek = from c in context.Articles
                             where c.ColumnId == kiválasztott.ColumnId && c.Title.Contains(textBoxFilter.Text)
                             select c;
                articlesBindingSource.DataSource = cikkek.ToList();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CikkekBetöltése();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var kiválasztott = (Articles)listBoxArticles.SelectedItem;
            if(kiválasztott is not null)
            {
                if(MessageBox.Show($"Biztosan törölni akarja a(z) {kiválasztott.Title} - címû cikket?", "Üzenet", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        context.Articles.Remove(kiválasztott);
                        context.SaveChanges();
                        CikkekBetöltése();
                        MessageBox.Show("Törlés sikeres");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs kijelölt cikk!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ÚjRovat rovat = new();
            if(rovat.ShowDialog() == DialogResult.OK)
            {
                Columns c = new();
                c.Name = rovat.rovatCím.Text;
                try
                {
                    context.Columns.Add(c);
                    context.SaveChanges();
                    RovatokBetöltése();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ÚjCikk cikk = new();
            
            if (cikk.ShowDialog() == DialogResult.OK)
            {
                Articles article = new Articles();
                article.Title = cikk.textBoxTitle.Text;
                article.Text = cikk.richTextBoxText.Text;
                var kiválasztott = (Columns)cikk.comboBoxColumn.SelectedItem;
                article.ColumnId = kiválasztott.ColumnId;
                try
                {
                    context.Articles.Add(article);
                    context.SaveChanges();
                    CikkekBetöltése();
                    MessageBox.Show("Cikk sikeressen hozzáadva!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}