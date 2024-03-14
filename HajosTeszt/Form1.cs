using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HajosTeszt
{
    public partial class Form1 : Form
    {
        List<K�rd�s> Aktu�lisK�rd�sek;
        int Megjelen�tettK�rd�sSz�ma = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(1400, 600);

            Aktu�lisK�rd�sek = K�rd�sBeolvas�s();

            K�rd�sMegjelen�t�s(Aktu�lisK�rd�sek[Megjelen�tettK�rd�sSz�ma]);
        }

        private List<K�rd�s> K�rd�sBeolvas�s()
        {
            List<K�rd�s> k�rd�sek = new List<K�rd�s>();

            try
            {
                StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine() ?? string.Empty;
                    string[] t�mb = sor.Split("\t");

                    if (t�mb.Length != 7) continue;

                    K�rd�s k = new K�rd�s();
                    k.K�rd�sSz�veg = t�mb[1].ToUpper();
                    k.V�lasz1 = t�mb[2].Trim('"');
                    k.V�lasz2 = t�mb[3].Trim('"');
                    k.V�lasz3 = t�mb[4].Trim('"');
                    k.URL = t�mb[5];

                    int.TryParse(t�mb[6], out int j�v�lasz);
                    k.HelyesV�lasz = j�v�lasz;

                    k�rd�sek.Add(k);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reading questions: " + ex.Message);
            }

            return k�rd�sek;
        }

        private void K�rd�sMegjelen�t�s(K�rd�s k�rd�s)
        {
            labelK�rd�s.Text = k�rd�s.K�rd�sSz�veg;
            textBox1.Text = k�rd�s.V�lasz1;
            textBox2.Text = k�rd�s.V�lasz2;
            textBox3.Text = k�rd�s.V�lasz3;

            if (!string.IsNullOrEmpty(k�rd�s.URL))
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + k�rd�s.URL);
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
            Megjelen�tettK�rd�sSz�ma++;

            if (Megjelen�tettK�rd�sSz�ma == Aktu�lisK�rd�sek.Count)
            {
                Megjelen�tettK�rd�sSz�ma = 0;
            }

            K�rd�sMegjelen�t�s(Aktu�lisK�rd�sek[Megjelen�tettK�rd�sSz�ma]);
        }

        void Sz�nez�s()
        {
            //int helyesV�lasz = Aktu�lisK�rd�sek[Megjelen�tettK�rd�sSz�ma]
        }
    }

}
