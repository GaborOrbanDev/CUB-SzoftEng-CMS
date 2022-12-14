namespace CMS
{
    partial class ÚjRovat
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
            this.label1 = new System.Windows.Forms.Label();
            this.rovatCím = new System.Windows.Forms.TextBox();
            this.mégse = new System.Windows.Forms.Button();
            this.hozzáadás = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(354, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Új rovat";
            // 
            // rovatCím
            // 
            this.rovatCím.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rovatCím.Location = new System.Drawing.Point(126, 211);
            this.rovatCím.Name = "rovatCím";
            this.rovatCím.Size = new System.Drawing.Size(527, 23);
            this.rovatCím.TabIndex = 1;
            this.rovatCím.TextChanged += new System.EventHandler(this.rovatCím_TextChanged);
            // 
            // mégse
            // 
            this.mégse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.mégse.Location = new System.Drawing.Point(126, 369);
            this.mégse.Name = "mégse";
            this.mégse.Size = new System.Drawing.Size(75, 23);
            this.mégse.TabIndex = 2;
            this.mégse.Text = "Mégse";
            this.mégse.UseVisualStyleBackColor = true;
            this.mégse.Click += new System.EventHandler(this.mégse_Click);
            // 
            // hozzáadás
            // 
            this.hozzáadás.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.hozzáadás.Enabled = false;
            this.hozzáadás.Location = new System.Drawing.Point(578, 369);
            this.hozzáadás.Name = "hozzáadás";
            this.hozzáadás.Size = new System.Drawing.Size(75, 23);
            this.hozzáadás.TabIndex = 3;
            this.hozzáadás.Text = "Hozzáadás";
            this.hozzáadás.UseVisualStyleBackColor = true;
            this.hozzáadás.Click += new System.EventHandler(this.hozzáadás_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ÚjRovat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.hozzáadás);
            this.Controls.Add(this.mégse);
            this.Controls.Add(this.rovatCím);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 500);
            this.MinimumSize = new System.Drawing.Size(816, 500);
            this.Name = "ÚjRovat";
            this.Text = "ÚjRovat";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        public TextBox rovatCím;
        private Button mégse;
        private Button hozzáadás;
        private ErrorProvider errorProvider1;
    }
}