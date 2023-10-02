namespace Alışveriş
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
            this.lblBirimfiyat = new System.Windows.Forms.Label();
            this.lblAdet = new System.Windows.Forms.Label();
            this.lblToplamtutar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtAdet = new System.Windows.Forms.TextBox();
            this.txtBirimfiyat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblBirimfiyat
            // 
            this.lblBirimfiyat.AutoSize = true;
            this.lblBirimfiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBirimfiyat.Location = new System.Drawing.Point(19, 34);
            this.lblBirimfiyat.Name = "lblBirimfiyat";
            this.lblBirimfiyat.Size = new System.Drawing.Size(80, 16);
            this.lblBirimfiyat.TabIndex = 0;
            this.lblBirimfiyat.Text = "Birim Fiyat";
            // 
            // lblAdet
            // 
            this.lblAdet.AutoSize = true;
            this.lblAdet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdet.Location = new System.Drawing.Point(60, 82);
            this.lblAdet.Name = "lblAdet";
            this.lblAdet.Size = new System.Drawing.Size(39, 16);
            this.lblAdet.TabIndex = 1;
            this.lblAdet.Text = "Adet";
            // 
            // lblToplamtutar
            // 
            this.lblToplamtutar.AutoSize = true;
            this.lblToplamtutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblToplamtutar.Location = new System.Drawing.Point(110, 152);
            this.lblToplamtutar.Name = "lblToplamtutar";
            this.lblToplamtutar.Size = new System.Drawing.Size(104, 16);
            this.lblToplamtutar.TabIndex = 2;
            this.lblToplamtutar.Text = "Toplam Tutar:";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.DarkOrange;
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.ForeColor = System.Drawing.Color.Red;
            this.btnHesapla.Location = new System.Drawing.Point(242, 50);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(94, 44);
            this.btnHesapla.TabIndex = 3;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtAdet
            // 
            this.txtAdet.Location = new System.Drawing.Point(105, 78);
            this.txtAdet.Name = "txtAdet";
            this.txtAdet.Size = new System.Drawing.Size(100, 20);
            this.txtAdet.TabIndex = 4;
            // 
            // txtBirimfiyat
            // 
            this.txtBirimfiyat.Location = new System.Drawing.Point(105, 33);
            this.txtBirimfiyat.Name = "txtBirimfiyat";
            this.txtBirimfiyat.Size = new System.Drawing.Size(100, 20);
            this.txtBirimfiyat.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(491, 226);
            this.Controls.Add(this.txtBirimfiyat);
            this.Controls.Add(this.txtAdet);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblToplamtutar);
            this.Controls.Add(this.lblAdet);
            this.Controls.Add(this.lblBirimfiyat);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBirimfiyat;
        private System.Windows.Forms.Label lblAdet;
        private System.Windows.Forms.Label lblToplamtutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtAdet;
        private System.Windows.Forms.TextBox txtBirimfiyat;
    }
}

