namespace Domaci4
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Imeknjigetxt = new System.Windows.Forms.TextBox();
            this.Imepiscatxt = new System.Windows.Forms.TextBox();
            this.Isbntxt = new System.Windows.Forms.TextBox();
            this.Godinatxt = new System.Windows.Forms.TextBox();
            this.Stranicetxt = new System.Windows.Forms.TextBox();
            this.DgKnjige = new System.Windows.Forms.DataGridView();
            this.Dodajbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgKnjige)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ime knjige:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ime pisca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "ISBN broj:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Godina izdanja:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 135);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Broj stranica:";
            // 
            // Imeknjigetxt
            // 
            this.Imeknjigetxt.Location = new System.Drawing.Point(137, 25);
            this.Imeknjigetxt.Name = "Imeknjigetxt";
            this.Imeknjigetxt.Size = new System.Drawing.Size(195, 20);
            this.Imeknjigetxt.TabIndex = 5;
            // 
            // Imepiscatxt
            // 
            this.Imepiscatxt.Location = new System.Drawing.Point(137, 52);
            this.Imepiscatxt.Name = "Imepiscatxt";
            this.Imepiscatxt.Size = new System.Drawing.Size(195, 20);
            this.Imepiscatxt.TabIndex = 6;
            // 
            // Isbntxt
            // 
            this.Isbntxt.Location = new System.Drawing.Point(137, 78);
            this.Isbntxt.Name = "Isbntxt";
            this.Isbntxt.Size = new System.Drawing.Size(195, 20);
            this.Isbntxt.TabIndex = 7;
            // 
            // Godinatxt
            // 
            this.Godinatxt.Location = new System.Drawing.Point(137, 109);
            this.Godinatxt.Name = "Godinatxt";
            this.Godinatxt.Size = new System.Drawing.Size(195, 20);
            this.Godinatxt.TabIndex = 8;
            // 
            // Stranicetxt
            // 
            this.Stranicetxt.Location = new System.Drawing.Point(137, 135);
            this.Stranicetxt.Name = "Stranicetxt";
            this.Stranicetxt.Size = new System.Drawing.Size(195, 20);
            this.Stranicetxt.TabIndex = 9;
            // 
            // DgKnjige
            // 
            this.DgKnjige.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DgKnjige.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgKnjige.Location = new System.Drawing.Point(12, 161);
            this.DgKnjige.Name = "DgKnjige";
            this.DgKnjige.Size = new System.Drawing.Size(540, 150);
            this.DgKnjige.TabIndex = 10;
            // 
            // Dodajbtn
            // 
            this.Dodajbtn.Location = new System.Drawing.Point(449, 132);
            this.Dodajbtn.Name = "Dodajbtn";
            this.Dodajbtn.Size = new System.Drawing.Size(75, 23);
            this.Dodajbtn.TabIndex = 11;
            this.Dodajbtn.Text = "Dodaj";
            this.Dodajbtn.UseVisualStyleBackColor = true;
            this.Dodajbtn.Click += new System.EventHandler(this.Dodajbtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 328);
            this.Controls.Add(this.Dodajbtn);
            this.Controls.Add(this.DgKnjige);
            this.Controls.Add(this.Stranicetxt);
            this.Controls.Add(this.Godinatxt);
            this.Controls.Add(this.Isbntxt);
            this.Controls.Add(this.Imepiscatxt);
            this.Controls.Add(this.Imeknjigetxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Biblioteka";
            ((System.ComponentModel.ISupportInitialize)(this.DgKnjige)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Imeknjigetxt;
        private System.Windows.Forms.TextBox Imepiscatxt;
        private System.Windows.Forms.TextBox Isbntxt;
        private System.Windows.Forms.TextBox Godinatxt;
        private System.Windows.Forms.TextBox Stranicetxt;
        private System.Windows.Forms.DataGridView DgKnjige;
        private System.Windows.Forms.Button Dodajbtn;
    }
}

