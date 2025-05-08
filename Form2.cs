using System.Text;


namespace hangman
{
    public partial class Form2 : Form
    {
        private string selectedWord;
        private string hint;
        private int score;
        private int wrongGuesses;

        private List<char> guessedLetters = new List<char>();
        private List<char> wrongLetters = new List<char>();


        private TimeSpan _sure;
        private TimeSpan timeLeft;
        private string _kategori;
        private string _zorluk;
        private string _resimTarzi;

        public Form2(TimeSpan sure, string kategori, string zorluk, string resimTarzi)
        {
            InitializeComponent();
            _sure = sure;
            _resimTarzi = resimTarzi;
            _kategori = kategori;
            _zorluk = zorluk;

            StartNewGame();
        }

        public class Soru
        {
            public string Kelime { get; set; }
            public string Ipucu { get; set; }
        }

        public static class SoruTxtYardimcisi
        {
            private static string dosyaYolu = "sorular.txt";

            public static Soru RastgeleSoruGetir(string kategori, string zorluk)
            {
                var uygunSorular = new List<Soru>();

                if (!File.Exists(dosyaYolu))
                {
                    MessageBox.Show("Soru dosyası bulunamadı: " + dosyaYolu);
                    return null;
                }

                foreach (var satir in File.ReadAllLines(dosyaYolu))
                {
                    var parcalar = satir.Split(';');
                    if (parcalar.Length != 4) continue;

                    if (parcalar[0].Equals(kategori, StringComparison.OrdinalIgnoreCase) &&
                        parcalar[1].Equals(zorluk, StringComparison.OrdinalIgnoreCase))
                    {
                        uygunSorular.Add(new Soru
                        {
                            Kelime = parcalar[2],
                            Ipucu = parcalar[3]
                        });
                    }
                }

                if (uygunSorular.Count == 0)
                    return null;

                Random rnd = new Random();
                return uygunSorular[rnd.Next(uygunSorular.Count)];
            }
        }


        private void StartTimer()
        {
            timeLeft = _sure;

            if (questionTimer == null)
            {
                questionTimer.Interval = 1000;
                questionTimer.Tick += questionTimer_Tick;
            }

            questionTimer.Stop();
            questionTimer.Start();
        }



        private void StartNewGame()
        {
            Soru gelenSoru = SoruTxtYardimcisi.RastgeleSoruGetir(_kategori, _zorluk);

            if (gelenSoru != null)
            {
                selectedWord = gelenSoru.Kelime;
                hint = gelenSoru.Ipucu;
            }
            else
            {
                MessageBox.Show("Seçilen kategori ve zorlukta soru bulunamadı.");
                return;
            }

            score = 100;
            wrongGuesses = 0;
            guessedLetters.Clear();
            wrongLetters.Clear();

            lblHint.Text = "";
            lblWrongLetters.Text = "Yanlış Harfler:";
            lblScore.Text = "Puan: " + score.ToString();
            UpdateWordDisplay();
            UpdateHangmanImage();
            BackColor = SystemColors.Control;

            StartTimer();
        }



        private void UpdateWordDisplay()
        {
            StringBuilder sb = new StringBuilder();
            foreach (char c in selectedWord)
            {
                if (guessedLetters.Contains(c))
                    sb.Append(c + " ");
                else
                    sb.Append("_ ");
            }

            lblWord.Text = sb.ToString().Trim();

            if (!lblWord.Text.Contains("_"))
            {
                BackColor = Color.LightGreen;
                questionTimer.Stop();
                MessageBox.Show("Tebrikler! Kazandınız.\nPuan: " + score.ToString(),
                    "", MessageBoxButtons.OK);

                StartNewGame();
            }
        }

        private void UpdateScoreAndDisplay()
        {
            lblScore.Text = "Puan: " + score.ToString();
            lblWrongLetters.Text = "Yanlış Harfler: " + string.Join(", ", wrongLetters);
        }

        private void UpdateHangmanImage()
        {
            int imageIndex = Math.Min(wrongGuesses + 1, 10);

            string fileName;

            if (_resimTarzi == "Balon")
            {

                int tersIndex = 11 - imageIndex;
                fileName = $"{tersIndex}balon.jpg";
            }
            else if (_resimTarzi == "Yumurta")
            {
                int tersIndex = 11 - imageIndex;
                fileName = $"{tersIndex}yumurta.jpg";
            }
            else
            {
                fileName = $"man-{imageIndex:00}.jpg";
            }

            string imagePath = Path.Combine(Application.StartupPath, "Resources", fileName);

            if (File.Exists(imagePath))
            {
                picHangman.Image = Image.FromFile(imagePath);
                picHangman.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (txtGuess.Text.Length != 1) return;

            char guess = char.ToLower(txtGuess.Text[0]);
            txtGuess.Clear();

            if (!char.IsLetter(guess)) return;
            if (guessedLetters.Contains(guess) || wrongLetters.Contains(guess)) return;

            if (selectedWord.Contains(guess))
            {
                guessedLetters.Add(guess);
                UpdateWordDisplay();
            }
            else
            {
                wrongLetters.Add(guess);
                wrongGuesses++;
                score -= 10;

                UpdateScoreAndDisplay();
                UpdateHangmanImage();

                if (wrongGuesses >= 10)
                {
                    BackColor = Color.LightCoral;
                    MessageBox.Show("Kaybettiniz! Kelime: " + selectedWord);
                    StartNewGame();
                }
            }
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Oyun sonlandırılıyor.");
            Form1 anaForm = new Form1();
            anaForm.Show();
            this.Close();

        }

        private void txtGuess_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen sadece harf giriniz!", "Geçersiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblHint.Text = "";
            lblHint.Text = "İpucu: " + hint;
        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {
            if (txtGuess.Text.Length > 1)
            {
                txtGuess.Text = txtGuess.Text.Substring(0, 1);
                txtGuess.SelectionStart = txtGuess.Text.Length;
            }
        }

        private void questionTimer_Tick(object sender, EventArgs e)
        {

            timeLeft = timeLeft.Subtract(TimeSpan.FromSeconds(1));
            
            this.Text = "Kalan Süre: " + timeLeft.ToString(@"mm\:ss");


            if (timeLeft.TotalSeconds <= 0)
            {
                questionTimer.Stop();
                this.BackColor = Color.Red;
                MessageBox.Show("Süre doldu! Soru yanlış kabul edildi.", "Zaman Aşımı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                Form1 anaForm = new Form1();
                anaForm.Show();
                this.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }
    }
}
