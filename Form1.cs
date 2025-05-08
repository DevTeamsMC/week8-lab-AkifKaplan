namespace hangman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int flag = 0;

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (comboBoxKategori.SelectedItem == null || comboBoxZorluk.SelectedItem == null)
            {
                MessageBox.Show("Lütfen kategori ve zorluk seçin.");
                return;
            }

            string kategori = comboBoxKategori.SelectedItem.ToString();
            string zorluk = comboBoxZorluk.SelectedItem.ToString();
            TimeSpan sure = dateTimePicker1.Value.TimeOfDay;

            string resimTarzi = comboBoxResimTarzi.SelectedItem.ToString();
            Form2 gameForm = new Form2(sure, kategori, zorluk, resimTarzi);
            gameForm.Show();
            this.Hide();
        }
        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            if (flag == 0)
            {
                groupBox1.Visible = false;
                flag = 1;
            }
            else
            {
                groupBox1.Visible = true;
                flag = 0;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxKategori.Items.Add("Tarih");
            comboBoxKategori.Items.Add("Coðrafya");
            comboBoxKategori.Items.Add("Matematik");
            comboBoxKategori.Items.Add("Genel Kültür");
            comboBoxKategori.Items.Add("Karma");

            comboBoxZorluk.Items.Add("Kolay");
            comboBoxZorluk.Items.Add("Orta");
            comboBoxZorluk.Items.Add("Zor");

            comboBoxResimTarzi.Items.Add("Man");
            comboBoxResimTarzi.Items.Add("Balon");
            comboBoxResimTarzi.Items.Add("Yumurta");

            comboBoxZorluk.SelectedIndex = 0;
            comboBoxKategori.SelectedIndex = 4;
            comboBoxResimTarzi.SelectedIndex = 0;
        }

      
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
