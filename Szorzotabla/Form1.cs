namespace Szorzotabla
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    Button button = new Button();
                    button.Text = Convert.ToString(sor * oszlop);
                    button.Left = sor * 40;
                    button.Top = oszlop * 40;

                    button.Height = 40;
                    button.Width = 40;

                    button.BackColor = Color.FromArgb(sor*10,oszlop*10,140);

                    Controls.Add(button);
                }
            }




        }
    }
}