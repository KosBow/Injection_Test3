namespace Injection_Test2
{
    public partial class Form1 : Form
    {
        private readonly IDatabaseService _databaseService;

        public Form1(IDatabaseService databaseService)
        {
            InitializeComponent();
            _databaseService = databaseService;
        }

        public void Inloggning()
        {
            string user = txtUser.Text;
            string pass = txtPass.Text;

            bool isValidUser = _databaseService.ValidateUser(user, pass);

            if (isValidUser)
                lblStatus.Text = "Du har loggat in";
            else
                lblStatus.Text = "Du är utloggad";
        }

        public void button1_Click(object sender, EventArgs e)
        {
            Inloggning();
        }


    }
}
