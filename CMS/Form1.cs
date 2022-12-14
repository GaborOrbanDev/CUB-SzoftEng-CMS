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
            CikkekBet�lt�se();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Biztos, hogy be akarja z�rni az ablakot?", "�zenet", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                e.Cancel = true;
                return;
            }
        }

        private void textBoxColumn_TextChanged(object sender, EventArgs e)
        {
            RovatokBet�lt�se();
        }

        private void RovatokBet�lt�se()
        {
            var rovatok = from r in context.Columns
                          where r.Name.Contains(textBoxColumn.Text)
                          select r;
            columnsBindingSource.DataSource = rovatok.ToList();
        }

        private void textBoxFilter_TextChanged(object sender, EventArgs e)
        {
            CikkekBet�lt�se();
        }

        private void CikkekBet�lt�se()
        {
            var kiv�lasztott = (Columns)comboBox1.SelectedItem;
            if (kiv�lasztott is not null)
            {
                var cikkek = from c in context.Articles
                             where c.ColumnId == kiv�lasztott.ColumnId && c.Title.Contains(textBoxFilter.Text)
                             select c;
                articlesBindingSource.DataSource = cikkek.ToList();
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CikkekBet�lt�se();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var kiv�lasztott = (Articles)listBoxArticles.SelectedItem;
            if(kiv�lasztott is not null)
            {
                if(MessageBox.Show($"Biztosan t�r�lni akarja a(z) {kiv�lasztott.Title} - c�m� cikket?", "�zenet", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    try
                    {
                        context.Articles.Remove(kiv�lasztott);
                        context.SaveChanges();
                        CikkekBet�lt�se();
                        MessageBox.Show("T�rl�s sikeres");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("Nincs kijel�lt cikk!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            �jRovat rovat = new();
            if(rovat.ShowDialog() == DialogResult.OK)
            {
                Columns c = new();
                c.Name = rovat.rovatC�m.Text;
                try
                {
                    context.Columns.Add(c);
                    context.SaveChanges();
                    RovatokBet�lt�se();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            �jCikk cikk = new();
            
            if (cikk.ShowDialog() == DialogResult.OK)
            {
                Articles article = new Articles();
                article.Title = cikk.textBoxTitle.Text;
                article.Text = cikk.richTextBoxText.Text;
                var kiv�lasztott = (Columns)cikk.comboBoxColumn.SelectedItem;
                article.ColumnId = kiv�lasztott.ColumnId;
                try
                {
                    context.Articles.Add(article);
                    context.SaveChanges();
                    CikkekBet�lt�se();
                    MessageBox.Show("Cikk sikeressen hozz�adva!");
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}