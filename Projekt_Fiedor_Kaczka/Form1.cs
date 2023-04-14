namespace Projekt_Fiedor_Kaczka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            roundButton1.MouseEnter += OnMouseEnterButton1;
            roundButton1.MouseLeave += OnMouseLeaveButton1;
        }
        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            roundButton1.BackColor = Color.FromArgb(96, 44, 184);
            roundButton1.ForeColor = Color.White;
           
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            roundButton1.BackColor = SystemColors.ButtonHighlight;
            roundButton1.ForeColor = Color.FromArgb(96, 44, 184);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
                MessageBox.Show("Uzupe�nij wszystkie pola!", "B��d");
            else if (textBox1.Text == "admin" && textBox2.Text == "admin")
            {
                Home h = new Home();
                h.Show();
                this.Hide();
            }
            else 
            {
                MessageBox.Show("Poda�e� nieprawid�owe dane! Spr�buj ponownie.","B��d");
            }
            
        }
    }
}