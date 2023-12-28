namespace uygulama
{
    partial class Form2
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cmbMahkeme = new ComboBox();
            tbDeger = new TextBox();
            label9 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            tbTanikSayisi = new TextBox();
            tbAvukatSayisi = new TextBox();
            chkMaktu = new CheckBox();
            btnHesapla = new Button();
            listBox1 = new ListBox();
            panel1 = new Panel();
            linkDurusma = new LinkLabel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(13, 69);
            label2.Name = "label2";
            label2.Size = new Size(178, 20);
            label2.TabIndex = 0;
            label2.Text = "DAVA DEĞERİNİ GİRİNİZ:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(13, 127);
            label3.Name = "label3";
            label3.Size = new Size(182, 20);
            label3.TabIndex = 0;
            label3.Text = "BİLİRKİŞİ ÜCRETİ SEÇİNİZ:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(13, 188);
            label4.Name = "label4";
            label4.Size = new Size(173, 20);
            label4.TabIndex = 0;
            label4.Text = "BİLİRKİŞİ SAYISI GİRİNİZ:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(13, 244);
            label5.Name = "label5";
            label5.Size = new Size(159, 20);
            label5.TabIndex = 0;
            label5.Text = "TARAF SAYISI GİRİNİZ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.ButtonFace;
            label6.Location = new Point(15, 297);
            label6.Name = "label6";
            label6.Size = new Size(157, 20);
            label6.TabIndex = 0;
            label6.Text = "TANIK SAYISI GİRİNİZ:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = SystemColors.ButtonFace;
            label7.Location = new Point(13, 353);
            label7.Name = "label7";
            label7.Size = new Size(171, 20);
            label7.TabIndex = 0;
            label7.Text = "AVUKAT SAYISI GİRİNİZ:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = SystemColors.ButtonFace;
            label8.Location = new Point(13, 14);
            label8.Name = "label8";
            label8.Size = new Size(145, 20);
            label8.TabIndex = 0;
            label8.Text = "MAHKEME SEÇİNİZ:";
            // 
            // cmbMahkeme
            // 
            cmbMahkeme.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMahkeme.FormattingEnabled = true;
            cmbMahkeme.ItemHeight = 20;
            cmbMahkeme.Items.AddRange(new object[] { "SULH HUKUK MAHKEMESİ", "İCRA HUKUK MAHKEMESİ", "ASLİYE HUKUK MAHKEMESİ", "AİLE MAHKEMESİ", "İŞ MAHKEMESİ", "KADASTRO MAHKEMESİ", "TÜKETİCİ MAHKEMESİ", "FİKRİ VE SİNAİ HAKLAR HUKUK MAHKEMESİ", "TİCARET MAHKEMESİ", "DENİZCİLİK İHTİSAS MAHKEMESİ" });
            cmbMahkeme.Location = new Point(164, 12);
            cmbMahkeme.Name = "cmbMahkeme";
            cmbMahkeme.Size = new Size(454, 28);
            cmbMahkeme.TabIndex = 2;
            // 
            // tbDeger
            // 
            tbDeger.Location = new Point(197, 66);
            tbDeger.Name = "tbDeger";
            tbDeger.Size = new Size(280, 27);
            tbDeger.TabIndex = 3;
            tbDeger.KeyPress += textBox1_KeyPress;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.ButtonFace;
            label9.Location = new Point(494, 67);
            label9.Name = "label9";
            label9.Size = new Size(27, 23);
            label9.TabIndex = 4;
            label9.Text = "TL";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.ItemHeight = 20;
            comboBox1.Items.AddRange(new object[] { "İcra ve iflas dairelerinde, satış memurluklarında görülen işler için", "Sulh hukuk ve tüketici mahkemelerinde görülen dava ve işler için" });
            comboBox1.Location = new Point(197, 124);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(421, 28);
            comboBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(197, 185);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(159, 27);
            textBox2.TabIndex = 5;
            textBox2.TextChanged += textBox2_TextChanged;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(197, 237);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(159, 27);
            textBox3.TabIndex = 5;
            textBox3.KeyPress += textBox3_KeyPress;
            // 
            // tbTanikSayisi
            // 
            tbTanikSayisi.Location = new Point(197, 294);
            tbTanikSayisi.Name = "tbTanikSayisi";
            tbTanikSayisi.Size = new Size(159, 27);
            tbTanikSayisi.TabIndex = 5;
            tbTanikSayisi.KeyPress += textBox4_KeyPress;
            // 
            // tbAvukatSayisi
            // 
            tbAvukatSayisi.Location = new Point(197, 350);
            tbAvukatSayisi.Name = "tbAvukatSayisi";
            tbAvukatSayisi.Size = new Size(159, 27);
            tbAvukatSayisi.TabIndex = 5;
            tbAvukatSayisi.KeyPress += textBox5_KeyPress;
            // 
            // chkMaktu
            // 
            chkMaktu.AutoSize = true;
            chkMaktu.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            chkMaktu.ForeColor = SystemColors.ButtonFace;
            chkMaktu.Location = new Point(527, 65);
            chkMaktu.Name = "chkMaktu";
            chkMaktu.Size = new Size(90, 27);
            chkMaktu.TabIndex = 6;
            chkMaktu.Text = "MAKTU";
            chkMaktu.UseVisualStyleBackColor = true;
            chkMaktu.CheckedChanged += chkMaktu_CheckedChanged;
            // 
            // btnHesapla
            // 
            btnHesapla.BackColor = Color.Lavender;
            btnHesapla.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnHesapla.Location = new Point(15, 414);
            btnHesapla.Name = "btnHesapla";
            btnHesapla.Size = new Size(406, 68);
            btnHesapla.TabIndex = 7;
            btnHesapla.Text = "Hesapla";
            btnHesapla.UseVisualStyleBackColor = false;
            btnHesapla.Click += btnHesapla_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(476, 158);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(451, 324);
            listBox1.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(listBox1);
            panel1.Controls.Add(btnHesapla);
            panel1.Controls.Add(chkMaktu);
            panel1.Controls.Add(tbAvukatSayisi);
            panel1.Controls.Add(tbTanikSayisi);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(tbDeger);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(cmbMahkeme);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(123, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(947, 501);
            panel1.TabIndex = 9;
            // 
            // linkDurusma
            // 
            linkDurusma.AutoSize = true;
            linkDurusma.BackColor = Color.Transparent;
            linkDurusma.Font = new Font("Times New Roman", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            linkDurusma.ForeColor = Color.White;
            linkDurusma.LinkColor = SystemColors.MenuHighlight;
            linkDurusma.Location = new Point(123, 605);
            linkDurusma.Name = "linkDurusma";
            linkDurusma.Size = new Size(263, 20);
            linkDurusma.TabIndex = 10;
            linkDurusma.TabStop = true;
            linkDurusma.Text = "Duruşma Bilgileri İçin Tıklayınız";
            linkDurusma.VisitedLinkColor = Color.FromArgb(0, 0, 192);
            linkDurusma.LinkClicked += linkDurusma_LinkClicked;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImage = Properties.Resources.Ekran_görüntüsü_2023_12_27_125604;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1156, 713);
            Controls.Add(linkDurusma);
            Controls.Add(panel1);
            DoubleBuffered = true;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "GİDER HESAPLAMA EKRANI";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cmbMahkeme;
        private TextBox tbDeger;
        private Label label9;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox tbTanikSayisi;
        private TextBox tbAvukatSayisi;
        private CheckBox chkMaktu;
        private Button btnHesapla;
        private ListBox listBox1;
        private Panel panel1;
        private LinkLabel linkDurusma;
    }
}