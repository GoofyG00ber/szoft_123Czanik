using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HajosTeszt
{
    public partial class Form1 : Form
    {
        List<Kérdés> AktuálisKérdések;
        int MegjelenítettKérdésSzáma = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(1400, 600);

            AktuálisKérdések = KérdésBeolvasás();

            KérdésMegjelenítés(AktuálisKérdések[MegjelenítettKérdésSzáma]);
        }

        private List<Kérdés> KérdésBeolvasás()
        {
            List<Kérdés> kérdések = new List<Kérdés>();

            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine() ?? string.Empty;
                    string[] tömb = sor.Split("\t");

                    if (tömb.Length != 7) continue;

                    Kérdés k = new Kérdés();
                    k.KérdésSzöveg = tömb[1].ToUpper();
                    k.Válasz1 = tömb[2].Trim('"');
                    k.Válasz2 = tömb[3].Trim('"');
                    k.Válasz3 = tömb[4].Trim('"');
                    k.URL = tömb[5];

                    int.TryParse(tömb[6], out int jóválasz);
                    k.HelyesVálasz = jóválasz;

                    kérdések.Add(k);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading questions: " + ex.Message);
            }

            return kérdések;
        }

        private void KérdésMegjelenítés(Kérdés kérdés)
        {
            labelKérdés.Text = kérdés.KérdésSzöveg;
            textBox1.Text = kérdés.Válasz1;
            textBox2.Text = kérdés.Válasz2;
            textBox3.Text = kérdés.Válasz3;

            if (!string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Increment the question counter
            MegjelenítettKérdésSzáma++;

            if (MegjelenítettKérdésSzáma == AktuálisKérdések.Count)
            {
                MegjelenítettKérdésSzáma = 0;
            }

            KérdésMegjelenítés(AktuálisKérdések[MegjelenítettKérdésSzáma]);
        }

        void Színezés()
        {
            //int helyesVálasz = AktuálisKérdések[MegjelenítettKérdésSzáma]
        }
    }

}
