namespace DersNotuBul
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
            this.txt_SinifOrtalaması = new System.Windows.Forms.TextBox();
            this.btn_Hesapla = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_DDAltSinir = new System.Windows.Forms.Label();
            this.lbl_DCAltSinir = new System.Windows.Forms.Label();
            this.lbl_CCAltSinir = new System.Windows.Forms.Label();
            this.lbl_Ortalama = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_KullaniciNotu = new System.Windows.Forms.TextBox();
            this.pnl_Sinirlar = new System.Windows.Forms.Panel();
            this.lbl_AAAltSinir = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_BAAltSinir = new System.Windows.Forms.Label();
            this.lbl_BBAltSinir = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_CBAltSinir = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_Not = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnl_Sinirlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sınıf Ortalaması";
            // 
            // txt_SinifOrtalaması
            // 
            this.txt_SinifOrtalaması.Location = new System.Drawing.Point(143, 71);
            this.txt_SinifOrtalaması.Name = "txt_SinifOrtalaması";
            this.txt_SinifOrtalaması.Size = new System.Drawing.Size(100, 20);
            this.txt_SinifOrtalaması.TabIndex = 1;
            // 
            // btn_Hesapla
            // 
            this.btn_Hesapla.Location = new System.Drawing.Point(306, 88);
            this.btn_Hesapla.Name = "btn_Hesapla";
            this.btn_Hesapla.Size = new System.Drawing.Size(99, 23);
            this.btn_Hesapla.TabIndex = 2;
            this.btn_Hesapla.Text = "Hesapla";
            this.btn_Hesapla.UseVisualStyleBackColor = true;
            this.btn_Hesapla.Click += new System.EventHandler(this.btn_Hesapla_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(147, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "DD Alt Sınır";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(146, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "DC Alt Sınır";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(147, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CC Alt Sınır";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_DDAltSinir
            // 
            this.lbl_DDAltSinir.AutoSize = true;
            this.lbl_DDAltSinir.Location = new System.Drawing.Point(264, 39);
            this.lbl_DDAltSinir.Name = "lbl_DDAltSinir";
            this.lbl_DDAltSinir.Size = new System.Drawing.Size(61, 13);
            this.lbl_DDAltSinir.TabIndex = 6;
            this.lbl_DDAltSinir.Text = "Sınır Değeri";
            // 
            // lbl_DCAltSinir
            // 
            this.lbl_DCAltSinir.AutoSize = true;
            this.lbl_DCAltSinir.Location = new System.Drawing.Point(264, 86);
            this.lbl_DCAltSinir.Name = "lbl_DCAltSinir";
            this.lbl_DCAltSinir.Size = new System.Drawing.Size(61, 13);
            this.lbl_DCAltSinir.TabIndex = 7;
            this.lbl_DCAltSinir.Text = "Sınır Değeri";
            // 
            // lbl_CCAltSinir
            // 
            this.lbl_CCAltSinir.AutoSize = true;
            this.lbl_CCAltSinir.Location = new System.Drawing.Point(264, 127);
            this.lbl_CCAltSinir.Name = "lbl_CCAltSinir";
            this.lbl_CCAltSinir.Size = new System.Drawing.Size(61, 13);
            this.lbl_CCAltSinir.TabIndex = 8;
            this.lbl_CCAltSinir.Text = "Sınır Değeri";
            // 
            // lbl_Ortalama
            // 
            this.lbl_Ortalama.AutoSize = true;
            this.lbl_Ortalama.Location = new System.Drawing.Point(143, 98);
            this.lbl_Ortalama.Name = "lbl_Ortalama";
            this.lbl_Ortalama.Size = new System.Drawing.Size(0, 13);
            this.lbl_Ortalama.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(46, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Kullanıcı Notu";
            // 
            // txt_KullaniciNotu
            // 
            this.txt_KullaniciNotu.Location = new System.Drawing.Point(143, 107);
            this.txt_KullaniciNotu.Name = "txt_KullaniciNotu";
            this.txt_KullaniciNotu.Size = new System.Drawing.Size(100, 20);
            this.txt_KullaniciNotu.TabIndex = 11;
            // 
            // pnl_Sinirlar
            // 
            this.pnl_Sinirlar.Controls.Add(this.lbl_AAAltSinir);
            this.pnl_Sinirlar.Controls.Add(this.label12);
            this.pnl_Sinirlar.Controls.Add(this.lbl_BAAltSinir);
            this.pnl_Sinirlar.Controls.Add(this.lbl_BBAltSinir);
            this.pnl_Sinirlar.Controls.Add(this.label9);
            this.pnl_Sinirlar.Controls.Add(this.label8);
            this.pnl_Sinirlar.Controls.Add(this.lbl_CBAltSinir);
            this.pnl_Sinirlar.Controls.Add(this.label7);
            this.pnl_Sinirlar.Controls.Add(this.lbl_Not);
            this.pnl_Sinirlar.Controls.Add(this.label6);
            this.pnl_Sinirlar.Controls.Add(this.label2);
            this.pnl_Sinirlar.Controls.Add(this.label3);
            this.pnl_Sinirlar.Controls.Add(this.label4);
            this.pnl_Sinirlar.Controls.Add(this.lbl_DDAltSinir);
            this.pnl_Sinirlar.Controls.Add(this.lbl_CCAltSinir);
            this.pnl_Sinirlar.Controls.Add(this.lbl_DCAltSinir);
            this.pnl_Sinirlar.Location = new System.Drawing.Point(21, 169);
            this.pnl_Sinirlar.Name = "pnl_Sinirlar";
            this.pnl_Sinirlar.Size = new System.Drawing.Size(528, 460);
            this.pnl_Sinirlar.TabIndex = 12;
            this.pnl_Sinirlar.Visible = false;
            this.pnl_Sinirlar.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_Sinirlar_Paint);
            // 
            // lbl_AAAltSinir
            // 
            this.lbl_AAAltSinir.AutoSize = true;
            this.lbl_AAAltSinir.Location = new System.Drawing.Point(264, 276);
            this.lbl_AAAltSinir.Name = "lbl_AAAltSinir";
            this.lbl_AAAltSinir.Size = new System.Drawing.Size(61, 13);
            this.lbl_AAAltSinir.TabIndex = 18;
            this.lbl_AAAltSinir.Text = "Sınır Değeri";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(147, 276);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 17;
            this.label12.Text = "AA Alt Sınır";
            // 
            // lbl_BAAltSinir
            // 
            this.lbl_BAAltSinir.AutoSize = true;
            this.lbl_BAAltSinir.Location = new System.Drawing.Point(264, 237);
            this.lbl_BAAltSinir.Name = "lbl_BAAltSinir";
            this.lbl_BAAltSinir.Size = new System.Drawing.Size(61, 13);
            this.lbl_BAAltSinir.TabIndex = 16;
            this.lbl_BAAltSinir.Text = "Sınır Değeri";
            // 
            // lbl_BBAltSinir
            // 
            this.lbl_BBAltSinir.AutoSize = true;
            this.lbl_BBAltSinir.Location = new System.Drawing.Point(264, 200);
            this.lbl_BBAltSinir.Name = "lbl_BBAltSinir";
            this.lbl_BBAltSinir.Size = new System.Drawing.Size(61, 13);
            this.lbl_BBAltSinir.TabIndex = 15;
            this.lbl_BBAltSinir.Text = "Sınır Değeri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(147, 237);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "BA Alt Sınır";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(146, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "BB Alt Sınır";
            // 
            // lbl_CBAltSinir
            // 
            this.lbl_CBAltSinir.AutoSize = true;
            this.lbl_CBAltSinir.Location = new System.Drawing.Point(264, 165);
            this.lbl_CBAltSinir.Name = "lbl_CBAltSinir";
            this.lbl_CBAltSinir.Size = new System.Drawing.Size(61, 13);
            this.lbl_CBAltSinir.TabIndex = 12;
            this.lbl_CBAltSinir.Text = "Sınır Değeri";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(146, 165);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "CB Alt Sınır";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lbl_Not
            // 
            this.lbl_Not.AutoSize = true;
            this.lbl_Not.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_Not.Location = new System.Drawing.Point(196, 388);
            this.lbl_Not.Name = "lbl_Not";
            this.lbl_Not.Size = new System.Drawing.Size(105, 20);
            this.lbl_Not.TabIndex = 10;
            this.lbl_Not.Text = "Not Değeriniz";
            this.lbl_Not.Click += new System.EventHandler(this.lbl_Not_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(196, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 24);
            this.label6.TabIndex = 9;
            this.label6.Text = "Notunuz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 676);
            this.Controls.Add(this.pnl_Sinirlar);
            this.Controls.Add(this.txt_KullaniciNotu);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_Ortalama);
            this.Controls.Add(this.btn_Hesapla);
            this.Controls.Add(this.txt_SinifOrtalaması);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnl_Sinirlar.ResumeLayout(false);
            this.pnl_Sinirlar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_SinifOrtalaması;
        private System.Windows.Forms.Button btn_Hesapla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_DDAltSinir;
        private System.Windows.Forms.Label lbl_DCAltSinir;
        private System.Windows.Forms.Label lbl_CCAltSinir;
        private System.Windows.Forms.Label lbl_Ortalama;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_KullaniciNotu;
        private System.Windows.Forms.Panel pnl_Sinirlar;
        private System.Windows.Forms.Label lbl_Not;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_CBAltSinir;
        private System.Windows.Forms.Label lbl_AAAltSinir;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lbl_BAAltSinir;
        private System.Windows.Forms.Label lbl_BBAltSinir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}

