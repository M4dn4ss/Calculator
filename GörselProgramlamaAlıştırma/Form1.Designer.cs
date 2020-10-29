namespace GörselProgramlamaAlıştırma
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
            this.txt_sayi_giris = new System.Windows.Forms.RichTextBox();
            this.btn_MC = new System.Windows.Forms.Button();
            this.btn_MR = new System.Windows.Forms.Button();
            this.btn_Marti = new System.Windows.Forms.Button();
            this.btn_Meksi = new System.Windows.Forms.Button();
            this.btn_artieksi = new System.Windows.Forms.Button();
            this.btn_gerial = new System.Windows.Forms.Button();
            this.btn_CE = new System.Windows.Forms.Button();
            this.btn_C = new System.Windows.Forms.Button();
            this.btn_karekok = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btn_bol = new System.Windows.Forms.Button();
            this.btn_kare = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btn_carp = new System.Windows.Forms.Button();
            this.btn_birbolu = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.btn_cikar = new System.Windows.Forms.Button();
            this.btn_esittir = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.btn_ondalikvirgul = new System.Windows.Forms.Button();
            this.btn_topla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_sayi_giris
            // 
            this.txt_sayi_giris.Location = new System.Drawing.Point(36, 93);
            this.txt_sayi_giris.Name = "txt_sayi_giris";
            this.txt_sayi_giris.Size = new System.Drawing.Size(294, 52);
            this.txt_sayi_giris.TabIndex = 1;
            this.txt_sayi_giris.Text = "";
            this.txt_sayi_giris.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_MC
            // 
            this.btn_MC.Location = new System.Drawing.Point(36, 179);
            this.btn_MC.Name = "btn_MC";
            this.btn_MC.Size = new System.Drawing.Size(54, 31);
            this.btn_MC.TabIndex = 2;
            this.btn_MC.Text = "MC";
            this.btn_MC.UseVisualStyleBackColor = true;
            this.btn_MC.Click += new System.EventHandler(this.hafiza_islem);
            // 
            // btn_MR
            // 
            this.btn_MR.Location = new System.Drawing.Point(96, 179);
            this.btn_MR.Name = "btn_MR";
            this.btn_MR.Size = new System.Drawing.Size(54, 31);
            this.btn_MR.TabIndex = 3;
            this.btn_MR.Text = "MR";
            this.btn_MR.UseVisualStyleBackColor = true;
            this.btn_MR.Click += new System.EventHandler(this.hafiza_islem);
            // 
            // btn_Marti
            // 
            this.btn_Marti.Location = new System.Drawing.Point(156, 179);
            this.btn_Marti.Name = "btn_Marti";
            this.btn_Marti.Size = new System.Drawing.Size(54, 31);
            this.btn_Marti.TabIndex = 4;
            this.btn_Marti.Text = "M+";
            this.btn_Marti.UseVisualStyleBackColor = true;
            this.btn_Marti.Click += new System.EventHandler(this.hafiza_islem);
            // 
            // btn_Meksi
            // 
            this.btn_Meksi.Location = new System.Drawing.Point(216, 179);
            this.btn_Meksi.Name = "btn_Meksi";
            this.btn_Meksi.Size = new System.Drawing.Size(54, 31);
            this.btn_Meksi.TabIndex = 5;
            this.btn_Meksi.Text = "M-";
            this.btn_Meksi.UseVisualStyleBackColor = true;
            this.btn_Meksi.Click += new System.EventHandler(this.hafiza_islem);
            // 
            // btn_artieksi
            // 
            this.btn_artieksi.Location = new System.Drawing.Point(276, 179);
            this.btn_artieksi.Name = "btn_artieksi";
            this.btn_artieksi.Size = new System.Drawing.Size(54, 31);
            this.btn_artieksi.TabIndex = 6;
            this.btn_artieksi.Text = "+/-";
            this.btn_artieksi.UseVisualStyleBackColor = true;
            this.btn_artieksi.Click += new System.EventHandler(this.btn_artieksi_Click);
            // 
            // btn_gerial
            // 
            this.btn_gerial.Location = new System.Drawing.Point(36, 216);
            this.btn_gerial.Name = "btn_gerial";
            this.btn_gerial.Size = new System.Drawing.Size(114, 31);
            this.btn_gerial.TabIndex = 7;
            this.btn_gerial.Text = "<------";
            this.btn_gerial.UseVisualStyleBackColor = true;
            this.btn_gerial.Click += new System.EventHandler(this.btn_gerial_Click);
            // 
            // btn_CE
            // 
            this.btn_CE.Location = new System.Drawing.Point(156, 216);
            this.btn_CE.Name = "btn_CE";
            this.btn_CE.Size = new System.Drawing.Size(54, 31);
            this.btn_CE.TabIndex = 8;
            this.btn_CE.Text = "CE";
            this.btn_CE.UseVisualStyleBackColor = true;
            this.btn_CE.Click += new System.EventHandler(this.btn_CE_Click);
            // 
            // btn_C
            // 
            this.btn_C.Location = new System.Drawing.Point(216, 216);
            this.btn_C.Name = "btn_C";
            this.btn_C.Size = new System.Drawing.Size(54, 31);
            this.btn_C.TabIndex = 9;
            this.btn_C.Text = "C";
            this.btn_C.UseVisualStyleBackColor = true;
            this.btn_C.Click += new System.EventHandler(this.btn_C_Click);
            // 
            // btn_karekok
            // 
            this.btn_karekok.Location = new System.Drawing.Point(276, 216);
            this.btn_karekok.Name = "btn_karekok";
            this.btn_karekok.Size = new System.Drawing.Size(54, 31);
            this.btn_karekok.TabIndex = 10;
            this.btn_karekok.Text = "✓";
            this.btn_karekok.UseVisualStyleBackColor = true;
            this.btn_karekok.Click += new System.EventHandler(this.diger_islemler);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(36, 253);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(54, 31);
            this.button10.TabIndex = 11;
            this.button10.Text = "7";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(96, 253);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(54, 31);
            this.button11.TabIndex = 12;
            this.button11.Text = "8";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(156, 253);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(54, 31);
            this.button12.TabIndex = 13;
            this.button12.Text = "9";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_bol
            // 
            this.btn_bol.Location = new System.Drawing.Point(216, 253);
            this.btn_bol.Name = "btn_bol";
            this.btn_bol.Size = new System.Drawing.Size(54, 31);
            this.btn_bol.TabIndex = 14;
            this.btn_bol.Text = "/";
            this.btn_bol.UseVisualStyleBackColor = true;
            this.btn_bol.Click += new System.EventHandler(this.dort_islem);
            // 
            // btn_kare
            // 
            this.btn_kare.Location = new System.Drawing.Point(276, 253);
            this.btn_kare.Name = "btn_kare";
            this.btn_kare.Size = new System.Drawing.Size(54, 31);
            this.btn_kare.TabIndex = 15;
            this.btn_kare.Text = "X2";
            this.btn_kare.UseVisualStyleBackColor = true;
            this.btn_kare.Click += new System.EventHandler(this.diger_islemler);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(36, 290);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(54, 31);
            this.button15.TabIndex = 16;
            this.button15.Text = "4";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(96, 290);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(54, 31);
            this.button16.TabIndex = 17;
            this.button16.Text = "5";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(156, 290);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(54, 31);
            this.button17.TabIndex = 18;
            this.button17.Text = "6";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_carp
            // 
            this.btn_carp.Location = new System.Drawing.Point(216, 290);
            this.btn_carp.Name = "btn_carp";
            this.btn_carp.Size = new System.Drawing.Size(54, 31);
            this.btn_carp.TabIndex = 19;
            this.btn_carp.Text = "x";
            this.btn_carp.UseVisualStyleBackColor = true;
            this.btn_carp.Click += new System.EventHandler(this.dort_islem);
            // 
            // btn_birbolu
            // 
            this.btn_birbolu.Location = new System.Drawing.Point(276, 290);
            this.btn_birbolu.Name = "btn_birbolu";
            this.btn_birbolu.Size = new System.Drawing.Size(54, 31);
            this.btn_birbolu.TabIndex = 20;
            this.btn_birbolu.Text = "1/x";
            this.btn_birbolu.UseVisualStyleBackColor = true;
            this.btn_birbolu.Click += new System.EventHandler(this.diger_islemler);
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(36, 327);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(54, 31);
            this.button20.TabIndex = 21;
            this.button20.Text = "1";
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(96, 327);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(54, 31);
            this.button21.TabIndex = 22;
            this.button21.Text = "2";
            this.button21.UseVisualStyleBackColor = true;
            this.button21.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(156, 327);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(54, 31);
            this.button22.TabIndex = 23;
            this.button22.Text = "3";
            this.button22.UseVisualStyleBackColor = true;
            this.button22.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_cikar
            // 
            this.btn_cikar.Location = new System.Drawing.Point(216, 327);
            this.btn_cikar.Name = "btn_cikar";
            this.btn_cikar.Size = new System.Drawing.Size(54, 31);
            this.btn_cikar.TabIndex = 24;
            this.btn_cikar.Text = "-";
            this.btn_cikar.UseVisualStyleBackColor = true;
            this.btn_cikar.Click += new System.EventHandler(this.dort_islem);
            // 
            // btn_esittir
            // 
            this.btn_esittir.Location = new System.Drawing.Point(276, 327);
            this.btn_esittir.Name = "btn_esittir";
            this.btn_esittir.Size = new System.Drawing.Size(54, 68);
            this.btn_esittir.TabIndex = 25;
            this.btn_esittir.Text = "=";
            this.btn_esittir.UseVisualStyleBackColor = true;
            this.btn_esittir.Click += new System.EventHandler(this.btn_esittir_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(36, 364);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(114, 31);
            this.button25.TabIndex = 26;
            this.button25.Text = "0";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.rakam_girisleri);
            // 
            // btn_ondalikvirgul
            // 
            this.btn_ondalikvirgul.Location = new System.Drawing.Point(156, 364);
            this.btn_ondalikvirgul.Name = "btn_ondalikvirgul";
            this.btn_ondalikvirgul.Size = new System.Drawing.Size(54, 31);
            this.btn_ondalikvirgul.TabIndex = 27;
            this.btn_ondalikvirgul.Text = ".";
            this.btn_ondalikvirgul.UseVisualStyleBackColor = true;
            this.btn_ondalikvirgul.Click += new System.EventHandler(this.btn_ondalikvirgul_Click);
            // 
            // btn_topla
            // 
            this.btn_topla.Location = new System.Drawing.Point(216, 364);
            this.btn_topla.Name = "btn_topla";
            this.btn_topla.Size = new System.Drawing.Size(54, 31);
            this.btn_topla.TabIndex = 28;
            this.btn_topla.Text = "+";
            this.btn_topla.UseVisualStyleBackColor = true;
            this.btn_topla.Click += new System.EventHandler(this.dort_islem);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 450);
            this.Controls.Add(this.btn_topla);
            this.Controls.Add(this.btn_ondalikvirgul);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.btn_esittir);
            this.Controls.Add(this.btn_cikar);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.button21);
            this.Controls.Add(this.button20);
            this.Controls.Add(this.btn_birbolu);
            this.Controls.Add(this.btn_carp);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.btn_kare);
            this.Controls.Add(this.btn_bol);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.btn_karekok);
            this.Controls.Add(this.btn_C);
            this.Controls.Add(this.btn_CE);
            this.Controls.Add(this.btn_gerial);
            this.Controls.Add(this.btn_artieksi);
            this.Controls.Add(this.btn_Meksi);
            this.Controls.Add(this.btn_Marti);
            this.Controls.Add(this.btn_MR);
            this.Controls.Add(this.btn_MC);
            this.Controls.Add(this.txt_sayi_giris);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.hafiza_islem);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox txt_sayi_giris;
        private System.Windows.Forms.Button btn_MC;
        private System.Windows.Forms.Button btn_MR;
        private System.Windows.Forms.Button btn_Marti;
        private System.Windows.Forms.Button btn_Meksi;
        private System.Windows.Forms.Button btn_artieksi;
        private System.Windows.Forms.Button btn_gerial;
        private System.Windows.Forms.Button btn_CE;
        private System.Windows.Forms.Button btn_C;
        private System.Windows.Forms.Button btn_karekok;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btn_bol;
        private System.Windows.Forms.Button btn_kare;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btn_carp;
        private System.Windows.Forms.Button btn_birbolu;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button btn_cikar;
        private System.Windows.Forms.Button btn_esittir;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button btn_ondalikvirgul;
        private System.Windows.Forms.Button btn_topla;
    }
}

