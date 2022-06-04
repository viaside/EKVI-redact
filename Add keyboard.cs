using Npgsql;

namespace EKVI_redact
{
    public partial class Add_keyboard : Form
    {
        public Add_keyboard()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            string NameKeyboard = keyboard_name.Text;
            int price = Convert.ToInt32(Price.Text);
            int stock = Convert.ToInt32(Stock.Text);
            var image = LoadImage.Text;
            string description = Description.Text;

            this.Hide();

            String connectionString = "Server=localhost;Port=5432;Database=EVKI_keyboard;User Id=postgres;Password=zxc;";
            NpgsqlConnection npgSqlConnection = new NpgsqlConnection(connectionString);
            npgSqlConnection.Open();
            NpgsqlCommand npgSqlCommand = new NpgsqlCommand("INSERT INTO keyboards(name_keyboard, price, uantity_of_stock, image, description) VALUES (@name, @price, @stock, pg_read_binary_file(@image), @description)", npgSqlConnection);
            npgSqlCommand.Parameters.AddWithValue("@name", NameKeyboard);
            npgSqlCommand.Parameters.AddWithValue("@price", price);
            npgSqlCommand.Parameters.AddWithValue("@stock", stock);
            npgSqlCommand.Parameters.AddWithValue("@image", image);
            npgSqlCommand.Parameters.AddWithValue("@description", description);
            npgSqlCommand.ExecuteNonQuery();
        }

        private void LoadImage_Click(object sender, EventArgs e)
        {
            try
            {
                var dialog = new OpenFileDialog();
                DialogResult result = dialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    MessageBox.Show("File load");
                    LoadImage.Text = Convert.ToString(dialog.FileName);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Add_keyboard_Load(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
