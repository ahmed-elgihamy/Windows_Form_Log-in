using Microsoft.VisualBasic.Logging;

namespace Log_in
{
    public partial class Form1 : Form
    {
        int i = 0;
        public Form1()
        {
            InitializeComponent();
            this.MinimumSize = this.Size;
        }

        home h = new home();    

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string user = TextBox1.Text;
            string pass = TextBox2.Text;

            if (user == "Ahmed Mahmoud" && pass == "123")
            {
                this.Hide();
                this.h.ShowDialog();
               
            }
            else if (i == 3)
            {
                MessageBox.Show("You have exhausted the maximum , you can not log in  ");
                this.btnLogn.Enabled = false;

            }
            else
            {
                MessageBox.Show("Try agin", "worning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                i++;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
