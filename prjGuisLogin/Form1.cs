namespace prjGuisLogin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnWelcome_Click(object sender, EventArgs e)
        {
            gbWelcome.Visible = false;
            gbLogin.Visible = true;
            gbRegister.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gbLogin.Location = new Point(0, 0);
            gbRegister.Location = new Point(0, 0);

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User Login = new User();
            Login.Name=txtNameLogin.Text;
            Login.Password=txtPassLogin.Text;
            UserDB user = new UserDB();
            bool bOutput = user.CheckUser(Login);
            if (bOutput)
            {
                MessageBox.Show("Weclome to the new world ");
                Welcome welcome = new Welcome();
                welcome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("You dont exist or don't belong here :) ");
                txtNameLogin.Focus();
            }
        }
    }
}
