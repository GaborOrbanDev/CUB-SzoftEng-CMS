namespace CMS
{
    partial class ÚjCikk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.comboBoxColumn = new System.Windows.Forms.ComboBox();
            this.richTextBoxText = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.hozzáadás = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxTitle.Location = new System.Drawing.Point(12, 12);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(762, 23);
            this.textBoxTitle.TabIndex = 0;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // comboBoxColumn
            // 
            this.comboBoxColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxColumn.FormattingEnabled = true;
            this.comboBoxColumn.Location = new System.Drawing.Point(13, 49);
            this.comboBoxColumn.Name = "comboBoxColumn";
            this.comboBoxColumn.Size = new System.Drawing.Size(762, 23);
            this.comboBoxColumn.TabIndex = 1;
            // 
            // richTextBoxText
            // 
            this.richTextBoxText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxText.Location = new System.Drawing.Point(13, 92);
            this.richTextBoxText.Name = "richTextBoxText";
            this.richTextBoxText.Size = new System.Drawing.Size(762, 308);
            this.richTextBoxText.TabIndex = 2;
            this.richTextBoxText.Text = "";
            this.richTextBoxText.TextChanged += new System.EventHandler(this.richTextBoxText_TextChanged);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(13, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Mégse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // hozzáadás
            // 
            this.hozzáadás.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hozzáadás.Enabled = false;
            this.hozzáadás.Location = new System.Drawing.Point(699, 415);
            this.hozzáadás.Name = "hozzáadás";
            this.hozzáadás.Size = new System.Drawing.Size(75, 23);
            this.hozzáadás.TabIndex = 4;
            this.hozzáadás.Text = "Hozzáadás";
            this.hozzáadás.UseVisualStyleBackColor = true;
            this.hozzáadás.Click += new System.EventHandler(this.hozzáadás_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ÚjCikk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hozzáadás);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBoxText);
            this.Controls.Add(this.comboBoxColumn);
            this.Controls.Add(this.textBoxTitle);
            this.Name = "ÚjCikk";
            this.Text = "ÚjCikk";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public TextBox textBoxTitle;
        public ComboBox comboBoxColumn;
        public RichTextBox richTextBoxText;
        private Button button1;
        private Button hozzáadás;
        private ErrorProvider errorProvider1;
    }
}