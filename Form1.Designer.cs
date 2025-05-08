namespace hangman
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
            btnStart = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnAyarlar = new Button();
            groupBox1 = new GroupBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            comboBoxResimTarzi = new ComboBox();
            label4 = new Label();
            comboBoxZorluk = new ComboBox();
            label3 = new Label();
            comboBoxKategori = new ComboBox();
            label2 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Transparent;
            btnStart.Font = new Font("Segoe UI", 20F);
            btnStart.Location = new Point(374, 415);
            btnStart.Margin = new Padding(3, 4, 3, 4);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(183, 82);
            btnStart.TabIndex = 0;
            btnStart.Text = "Başla";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.cover2;
            pictureBox1.Location = new Point(-19, -31);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1006, 690);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 20F);
            label1.Location = new Point(308, 256);
            label1.Name = "label1";
            label1.Size = new Size(312, 68);
            label1.TabIndex = 2;
            label1.Text = "Adam Asmaca";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnAyarlar
            // 
            btnAyarlar.Location = new Point(727, 41);
            btnAyarlar.Name = "btnAyarlar";
            btnAyarlar.Size = new Size(94, 29);
            btnAyarlar.TabIndex = 3;
            btnAyarlar.Text = "Ayarlar";
            btnAyarlar.UseVisualStyleBackColor = true;
            btnAyarlar.Click += btnAyarlar_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(comboBoxResimTarzi);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(comboBoxZorluk);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(652, 76);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 251);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Visible = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "\"'00:'mm':'ss'\"";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(6, 195);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(151, 27);
            dateTimePicker1.TabIndex = 7;
            dateTimePicker1.Value = new DateTime(2025, 5, 7, 0, 0, 30, 0);
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 172);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 6;
            label5.Text = "Oyun Süresi";
            // 
            // comboBoxResimTarzi
            // 
            comboBoxResimTarzi.FormattingEnabled = true;
            comboBoxResimTarzi.Location = new Point(6, 126);
            comboBoxResimTarzi.Name = "comboBoxResimTarzi";
            comboBoxResimTarzi.Size = new Size(151, 28);
            comboBoxResimTarzi.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 103);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 3;
            label4.Text = "Resim Tarzı";
            // 
            // comboBoxZorluk
            // 
            comboBoxZorluk.FormattingEnabled = true;
            comboBoxZorluk.Location = new Point(6, 46);
            comboBoxZorluk.Name = "comboBoxZorluk";
            comboBoxZorluk.Size = new Size(151, 28);
            comboBoxZorluk.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 23);
            label3.Name = "label3";
            label3.Size = new Size(51, 20);
            label3.TabIndex = 1;
            label3.Text = "Zorluk";
            // 
            // comboBoxKategori
            // 
            comboBoxKategori.FormattingEnabled = true;
            comboBoxKategori.Location = new Point(374, 380);
            comboBoxKategori.Name = "comboBoxKategori";
            comboBoxKategori.Size = new Size(183, 28);
            comboBoxKategori.TabIndex = 1;
            comboBoxKategori.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Location = new Point(425, 337);
            label2.Name = "label2";
            label2.Size = new Size(85, 31);
            label2.TabIndex = 0;
            label2.Text = "Kategori";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = Properties.Resources.png_transparent_power_button_logo_computer_icons_button_scalable_graphics_crystal_clear_action_exit_miscellaneous_application_software_red_thumbnail;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 26);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 44);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(pictureBox2);
            Controls.Add(label2);
            Controls.Add(comboBoxKategori);
            Controls.Add(groupBox1);
            Controls.Add(btnAyarlar);
            Controls.Add(label1);
            Controls.Add(btnStart);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnStart;
        private PictureBox pictureBox1;
        private Label label1;
        private Button btnAyarlar;
        private GroupBox groupBox1;
        private ComboBox comboBoxKategori;
        private Label label2;
        private ComboBox comboBoxZorluk;
        private Label label3;
        private ComboBox comboBoxResimTarzi;
        private Label label4;
        private Label label5;
        private DateTimePicker dateTimePicker1;
        private PictureBox pictureBox2;
    }
}
