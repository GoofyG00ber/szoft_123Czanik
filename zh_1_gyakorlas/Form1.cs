namespace zh_1_gyakorlas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal a = Convert.ToDecimal(textBox1.Text);
            textBox2.Text = (a * 2).ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Size = new Size(800,600);

            for (int sor = 0; sor < 6; sor++)
            {
                for (int oszlop = 0; oszlop < 6; oszlop++)
                {
                    if ((sor + oszlop) % 2 == 0)
                    {
                        Button b = new Button();
                        b.Width = 100;
                        b.Height = 100;


                        b.Left = 100 * sor;
                        b.Top = 100 * oszlop;

                        b.Text = b.Location.ToString();

                        Controls.Add(b);
                        b.BackColor = Color.Black;
                    }
                    
                }
            }

        }
    }
}
