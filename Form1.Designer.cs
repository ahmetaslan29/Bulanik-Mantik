namespace Bulanık_Mantık___Çamaşır_Makinesi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_calistir = new System.Windows.Forms.Button();
            this.lbhassaslık = new System.Windows.Forms.Label();
            this.lKirlilik = new System.Windows.Forms.Label();
            this.lMiktar = new System.Windows.Forms.Label();
            this.list_göster = new System.Windows.Forms.ListView();
            this.tbhassaslik = new System.Windows.Forms.TrackBar();
            this.tbmiktar = new System.Windows.Forms.TrackBar();
            this.tbkirlilik = new System.Windows.Forms.TrackBar();
            this.lblHassas = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            this.lblKirli = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbhassaslik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmiktar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbkirlilik)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_calistir
            // 
            this.btn_calistir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_calistir.FlatAppearance.BorderSize = 0;
            this.btn_calistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calistir.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calistir.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_calistir.Location = new System.Drawing.Point(24, 363);
            this.btn_calistir.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calistir.Name = "btn_calistir";
            this.btn_calistir.Size = new System.Drawing.Size(202, 62);
            this.btn_calistir.TabIndex = 5;
            this.btn_calistir.Text = "Çalıştır";
            this.btn_calistir.UseVisualStyleBackColor = false;
            this.btn_calistir.Click += new System.EventHandler(this.Button1_Click);
            // 
            // lbhassaslık
            // 
            this.lbhassaslık.AutoSize = true;
            this.lbhassaslık.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbhassaslık.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lbhassaslık.Location = new System.Drawing.Point(63, 126);
            this.lbhassaslık.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbhassaslık.Name = "lbhassaslık";
            this.lbhassaslık.Size = new System.Drawing.Size(83, 26);
            this.lbhassaslık.TabIndex = 1;
            this.lbhassaslık.Text = "Sağlam";
            // 
            // lKirlilik
            // 
            this.lKirlilik.AutoSize = true;
            this.lKirlilik.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lKirlilik.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lKirlilik.Location = new System.Drawing.Point(63, 290);
            this.lKirlilik.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lKirlilik.Name = "lKirlilik";
            this.lKirlilik.Size = new System.Drawing.Size(72, 26);
            this.lKirlilik.TabIndex = 1;
            this.lKirlilik.Text = "Küçük";
            // 
            // lMiktar
            // 
            this.lMiktar.AutoSize = true;
            this.lMiktar.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMiktar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lMiktar.Location = new System.Drawing.Point(63, 209);
            this.lMiktar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lMiktar.Name = "lMiktar";
            this.lMiktar.Size = new System.Drawing.Size(72, 26);
            this.lMiktar.TabIndex = 1;
            this.lMiktar.Text = "Küçük";
            // 
            // list_göster
            // 
            this.list_göster.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.list_göster.Font = new System.Drawing.Font("MV Boli", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_göster.Location = new System.Drawing.Point(252, 13);
            this.list_göster.Margin = new System.Windows.Forms.Padding(4);
            this.list_göster.Name = "list_göster";
            this.list_göster.Size = new System.Drawing.Size(653, 521);
            this.list_göster.TabIndex = 4;
            this.list_göster.UseCompatibleStateImageBehavior = false;
            // 
            // tbhassaslik
            // 
            this.tbhassaslik.Location = new System.Drawing.Point(16, 160);
            this.tbhassaslik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbhassaslik.Maximum = 100;
            this.tbhassaslik.Name = "tbhassaslik";
            this.tbhassaslik.Size = new System.Drawing.Size(221, 56);
            this.tbhassaslik.TabIndex = 8;
            this.tbhassaslik.Value = 100;
            this.tbhassaslik.ValueChanged += new System.EventHandler(this.TrackBar1_ValueChanged);
            // 
            // tbmiktar
            // 
            this.tbmiktar.Location = new System.Drawing.Point(16, 241);
            this.tbmiktar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbmiktar.Maximum = 100;
            this.tbmiktar.Name = "tbmiktar";
            this.tbmiktar.Size = new System.Drawing.Size(221, 56);
            this.tbmiktar.TabIndex = 9;
            this.tbmiktar.Value = 30;
            this.tbmiktar.ValueChanged += new System.EventHandler(this.tbMiktar_ValueChanged);
            // 
            // tbkirlilik
            // 
            this.tbkirlilik.Location = new System.Drawing.Point(16, 322);
            this.tbkirlilik.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbkirlilik.Maximum = 100;
            this.tbkirlilik.Name = "tbkirlilik";
            this.tbkirlilik.Size = new System.Drawing.Size(221, 56);
            this.tbkirlilik.TabIndex = 10;
            this.tbkirlilik.Value = 39;
            this.tbkirlilik.ValueChanged += new System.EventHandler(this.tbKirli_ValueChanged);
            // 
            // lblHassas
            // 
            this.lblHassas.AutoSize = true;
            this.lblHassas.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHassas.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblHassas.Location = new System.Drawing.Point(20, 124);
            this.lblHassas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHassas.Name = "lblHassas";
            this.lblHassas.Size = new System.Drawing.Size(43, 29);
            this.lblHassas.TabIndex = 1;
            this.lblHassas.Text = "5,0";
            this.lblHassas.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblMiktar.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblMiktar.Location = new System.Drawing.Point(20, 207);
            this.lblMiktar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(43, 29);
            this.lblMiktar.TabIndex = 1;
            this.lblMiktar.Text = "3,0";
            this.lblMiktar.Click += new System.EventHandler(this.label5_Click);
            // 
            // lblKirli
            // 
            this.lblKirli.AutoSize = true;
            this.lblKirli.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKirli.ForeColor = System.Drawing.Color.LimeGreen;
            this.lblKirli.Location = new System.Drawing.Point(20, 288);
            this.lblKirli.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblKirli.Name = "lblKirli";
            this.lblKirli.Size = new System.Drawing.Size(43, 29);
            this.lblKirli.TabIndex = 1;
            this.lblKirli.Text = "3,9";
            this.lblKirli.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "hassaslık degeri";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "miktar degeri";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 273);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 22);
            this.label6.TabIndex = 12;
            this.label6.Text = "kirlilik degeri";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 473);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "label3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(922, 547);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_calistir);
            this.Controls.Add(this.tbkirlilik);
            this.Controls.Add(this.tbmiktar);
            this.Controls.Add(this.lKirlilik);
            this.Controls.Add(this.lbhassaslık);
            this.Controls.Add(this.lMiktar);
            this.Controls.Add(this.tbhassaslik);
            this.Controls.Add(this.lblKirli);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblHassas);
            this.Controls.Add(this.list_göster);
            this.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bulanık Mantık";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbhassaslik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbmiktar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbkirlilik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbhassaslık;
        private System.Windows.Forms.Label lKirlilik;
        private System.Windows.Forms.Label lMiktar;
        private System.Windows.Forms.ListView list_göster;
        private System.Windows.Forms.Button btn_calistir;
        private System.Windows.Forms.TrackBar tbhassaslik;
        private System.Windows.Forms.TrackBar tbmiktar;
        private System.Windows.Forms.TrackBar tbkirlilik;
        private System.Windows.Forms.Label lblHassas;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblKirli;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

