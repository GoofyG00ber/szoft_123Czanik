namespace Listing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Sor> sorok = new List<Sor>();
            for (int i = 0; i < 10; i++)
            {
                Sor sor = new Sor();
                sor.Sorszam = i;
                sor.Ertek = factorial(i);
                sorok.Add(sor);
            }
            dataGridView1.DataSource = sorok;
        }

        static int factorial(int n)
        {
            if (n > 1)
            {
                return n * factorial(n - 1);
            }
            else
            {
                return 1;
            }
        }
    }
}
