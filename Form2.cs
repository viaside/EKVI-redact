using Npgsql;
using System.Data;

namespace EKVI_redact
{
    public partial class redact : Form
    {
        private NpgsqlConnection npgSqlConnection = null;
        private NpgsqlCommand npgSqlCommand = null;

        DataTable dt = new DataTable();
        DataSet ds = new DataSet();

        public redact()
        {
            InitializeComponent();

            npgSqlConnection = new NpgsqlConnection("Server=localhost;Port=5432;Database=EVKI_keyboard;User Id=postgres;Password=zxc;");

            load_date();
        }

        private void load_date()
        {
            string sql = ("SELECT * FROM keyboards ORDER BY ID");
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, npgSqlConnection);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dataGridView2.DataSource = dt;
            for (int i = 0; i < dataGridView2.Columns.Count; i++)
                if (dataGridView2.Columns[i] is DataGridViewImageColumn)
                {
                    ((DataGridViewImageColumn)dataGridView2.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    break;
                }
            npgSqlConnection.Close();

        }
        private void update_data()
        {
            load_date();
        }

        private void update_date_Click(object sender, EventArgs e)
        {
            update_data();
        }

        private void exit(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void add_Click(object sender, EventArgs e)
        {
            Add_keyboard add = new Add_keyboard();
            add.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Delete this string?", "delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;
                        int id = Convert.ToInt32(dataGridView2[0, rowIndex].Value);
                        npgSqlConnection.Open();
                        npgSqlCommand = new NpgsqlCommand("DELETE FROM keyboards WHERE id = @index", npgSqlConnection);
                        npgSqlCommand.Parameters.AddWithValue("@index", id);
                        npgSqlCommand.ExecuteNonQuery();
                        npgSqlConnection.Close();
                    }
                    update_data();
                }
                else if (e.ColumnIndex == 7)
                {
                    if (MessageBox.Show("Update this string?", "update", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        == DialogResult.Yes)
                    {
                        int rowIndex = e.RowIndex;
                        int id = Convert.ToInt32(dataGridView2[0, rowIndex].Value);
                        string nameKeyboard = Convert.ToString(dataGridView2[1, rowIndex].Value);
                        decimal price = Convert.ToDecimal(dataGridView2[2, rowIndex].Value);
                        int stock = Convert.ToInt32(dataGridView2[3, rowIndex].Value);
                        string description = Convert.ToString(dataGridView2[5, rowIndex].Value);

                        npgSqlConnection.Open();
                        npgSqlCommand = new NpgsqlCommand("UPDATE keyboards SET name_keyboard = @name_keyboard, price = @price, uantity_of_stock = @stock, description = @description WHERE id = @id", npgSqlConnection);
                        npgSqlCommand.Parameters.AddWithValue("@name_keyboard", nameKeyboard);
                        npgSqlCommand.Parameters.AddWithValue("@price", price);
                        npgSqlCommand.Parameters.AddWithValue("@stock", stock);
                        npgSqlCommand.Parameters.AddWithValue("@description", description);
                        npgSqlCommand.Parameters.AddWithValue("@id", id);
                        npgSqlCommand.ExecuteNonQuery();
                        npgSqlConnection.Close();

                    }
                    update_data();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            string search;
            if (textBox1.Text == "")
            {
                MessageBox.Show("error");
                load_date();
            }
            else
            {
                search = textBox1.Text;
                string sql = ("SELECT * FROM keyboards WHERE name_keyboard = '" + search + "'");
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, npgSqlConnection);
                ds.Reset();
                da.Fill(ds);
                dt = ds.Tables[0];
                dataGridView2.DataSource = dt;
                for (int i = 0; i < dataGridView2.Columns.Count; i++)
                    if (dataGridView2.Columns[i] is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)dataGridView2.Columns[i]).ImageLayout = DataGridViewImageCellLayout.Zoom;
                        break;
                    }
                npgSqlConnection.Close();
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login log = new Login();
            log.Show();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            npgSqlConnection.Open();
            npgSqlCommand = new NpgsqlCommand("SELECT name_keyboard FROM keyboards", npgSqlConnection);
            NpgsqlDataReader reader = npgSqlCommand.ExecuteReader();

            List<string[]> name = new List<string[]>();

            while (reader.Read())
            {
                name.Add(new string[1]);

                name[name.Count - 1][0] = reader[0].ToString();
            }
            reader.Close();
            npgSqlConnection.Close();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            foreach (string[] s in name)
            {
                source.AddRange(s);
            }
            textBox1.AutoCompleteCustomSource = source;
            textBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            textBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
    }
}
