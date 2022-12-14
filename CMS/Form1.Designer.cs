namespace CMS
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxColumn = new System.Windows.Forms.TextBox();
            this.textBoxFilter = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.columnsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listBoxArticles = new System.Windows.Forms.ListBox();
            this.articlesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxColumn
            // 
            this.textBoxColumn.Location = new System.Drawing.Point(12, 12);
            this.textBoxColumn.Name = "textBoxColumn";
            this.textBoxColumn.Size = new System.Drawing.Size(202, 23);
            this.textBoxColumn.TabIndex = 0;
            this.textBoxColumn.TextChanged += new System.EventHandler(this.textBoxColumn_TextChanged);
            // 
            // textBoxFilter
            // 
            this.textBoxFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxFilter.Location = new System.Drawing.Point(253, 12);
            this.textBoxFilter.Name = "textBoxFilter";
            this.textBoxFilter.Size = new System.Drawing.Size(200, 23);
            this.textBoxFilter.TabIndex = 1;
            this.textBoxFilter.TextChanged += new System.EventHandler(this.textBoxFilter_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.columnsBindingSource;
            this.comboBox1.DisplayMember = "Name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(11, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 23);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // columnsBindingSource
            // 
            this.columnsBindingSource.DataSource = typeof(CMS.Models.Columns);
            // 
            // listBoxArticles
            // 
            this.listBoxArticles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxArticles.DataSource = this.articlesBindingSource;
            this.listBoxArticles.DisplayMember = "Title";
            this.listBoxArticles.FormattingEnabled = true;
            this.listBoxArticles.ItemHeight = 15;
            this.listBoxArticles.Location = new System.Drawing.Point(254, 54);
            this.listBoxArticles.Name = "listBoxArticles";
            this.listBoxArticles.Size = new System.Drawing.Size(201, 379);
            this.listBoxArticles.TabIndex = 3;
            // 
            // articlesBindingSource
            // 
            this.articlesBindingSource.DataSource = typeof(CMS.Models.Articles);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 89);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(203, 24);
            this.button1.TabIndex = 4;
            this.button1.Text = "Rovat hozzáadása";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 135);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(203, 24);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cikk hozzáadása";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(479, 409);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(252, 24);
            this.button3.TabIndex = 6;
            this.button3.Text = "Cikk törlése";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBoxArticles);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBoxFilter);
            this.Controls.Add(this.textBoxColumn);
            this.MinimumSize = new System.Drawing.Size(768, 489);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.columnsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.articlesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox textBoxColumn;
        private TextBox textBoxFilter;
        private ComboBox comboBox1;
        private ListBox listBoxArticles;
        private Button button1;
        private Button button2;
        private Button button3;
        private BindingSource columnsBindingSource;
        private BindingSource articlesBindingSource;
    }
}