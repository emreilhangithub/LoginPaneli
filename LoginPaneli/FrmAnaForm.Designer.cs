
namespace LoginPaneli
{
    partial class FrmAnaForm
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
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblKullaniciId = new System.Windows.Forms.Label();
            this.lblKullaniciSifre = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(463, 159);
            this.lblKullaniciAdi.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(85, 29);
            this.lblKullaniciAdi.TabIndex = 0;
            this.lblKullaniciAdi.Text = "label1";
            // 
            // lblKullaniciId
            // 
            this.lblKullaniciId.AutoSize = true;
            this.lblKullaniciId.Location = new System.Drawing.Point(463, 258);
            this.lblKullaniciId.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKullaniciId.Name = "lblKullaniciId";
            this.lblKullaniciId.Size = new System.Drawing.Size(85, 29);
            this.lblKullaniciId.TabIndex = 1;
            this.lblKullaniciId.Text = "label2";
            // 
            // lblKullaniciSifre
            // 
            this.lblKullaniciSifre.AutoSize = true;
            this.lblKullaniciSifre.Location = new System.Drawing.Point(463, 380);
            this.lblKullaniciSifre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblKullaniciSifre.Name = "lblKullaniciSifre";
            this.lblKullaniciSifre.Size = new System.Drawing.Size(85, 29);
            this.lblKullaniciSifre.TabIndex = 2;
            this.lblKullaniciSifre.Text = "label3";
            // 
            // lblTarih
            // 
            this.lblTarih.AutoSize = true;
            this.lblTarih.Location = new System.Drawing.Point(169, 46);
            this.lblTarih.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(74, 29);
            this.lblTarih.TabIndex = 3;
            this.lblTarih.Text = "Tarih";
            // 
            // lblSaat
            // 
            this.lblSaat.AutoSize = true;
            this.lblSaat.Location = new System.Drawing.Point(463, 46);
            this.lblSaat.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(65, 29);
            this.lblSaat.TabIndex = 4;
            this.lblSaat.Text = "Saat";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 380);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "Kullanıcı Şifresi=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 258);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Kulannıcı Idsi=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 29);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı=";
            // 
            // FrmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 500);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblKullaniciSifre);
            this.Controls.Add(this.lblKullaniciId);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "FrmAnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblKullaniciId;
        private System.Windows.Forms.Label lblKullaniciSifre;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}