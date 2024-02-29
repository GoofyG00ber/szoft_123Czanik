namespace _3.hét
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int meret = 36;

            Size = new Size(meret*21, meret * 22);

            for (int sor = 0; sor < 20; sor++)
            {
                for (int oszlop = 0; oszlop < 20; oszlop++)
                {
                    SzamoloGomb p = new SzamoloGomb();
                    Controls.Add(p);
                    p.Height = meret;
                    p.Width = meret;
                    p.Left = meret * oszlop;
                    p.Top = meret * sor;
                }
            }
        }
    }
}