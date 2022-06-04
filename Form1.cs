using Npgsql;


namespace EKVI_redact
{
    public partial class Login : Form
    {

        Password pas = new Password();

        public Login()
        {
            InitializeComponent();
            ChangePass.Hide();
            SavePas.Hide();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            if (pas.CheckPassword(login_text.Text))
            {
                error_text.Hide();
                Hide();
                redact redact = new redact();
                redact.Show();
            }
            else
            {
                error_text.Show();
            }
        }


        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {
            login_text.Hide();
            login_button.Hide();
            ChangePassword.Hide();
            ChangePass.Show();
            SavePas.Show();
        }

        private void SavePas_Click(object sender, EventArgs e)
        {
            if (pas.ChangePassword(ChangePass.Text) == true)
            {
                login_text.Show();
                login_button.Show();
                ChangePassword.Show();
                ChangePass.Hide();
                SavePas.Hide();
            }
            else
            {
                MessageBox.Show("New password is default");
            }
        }
    }
    class Password
    {
        private string Pass;
        private string DefaultPass;
        private NpgsqlConnection npgSqlConnection = null;
        private NpgsqlCommand npgSqlCommand = null;

        public Password()
        {
            DefaultPass = "Password";
            npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;Database=EVKI_keyboard;User Id=postgres;Password=zxc;");
        }

        public bool CheckPassword(string Password)
        {
            npgSqlConnection.Open();
            npgSqlCommand = new NpgsqlCommand("SELECT * FROM password", npgSqlConnection);
            NpgsqlDataReader reader = npgSqlCommand.ExecuteReader();
            reader.Read();

            Pass = reader["password"].ToString();

            npgSqlConnection.Close();

            if (Password == Pass)
            {
                return true;
            }
            else if (Password == DefaultPass)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool ChangePassword(string NewPassword)
        {
            if (NewPassword != DefaultPass)
            {
                Pass = NewPassword;
                npgSqlConnection.Open();
                npgSqlCommand = new NpgsqlCommand("UPDATE password SET password=@NewPassword;", npgSqlConnection);
                npgSqlCommand.Parameters.AddWithValue("@NewPassword", NewPassword);
                npgSqlCommand.ExecuteNonQuery();
                npgSqlConnection.Close();
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}