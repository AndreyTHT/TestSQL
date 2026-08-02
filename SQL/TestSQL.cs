using System.Data;

namespace SQL
{
    public partial class TestSQL : Form
    {
        public TestSQL()
        {
            InitializeComponent();
        }

        private async void executeBtn_Click(object sender, EventArgs e)
        {
            string sql = textOfSQL.Text;

            try
            {
                if (rbExecute.Checked)
                {
                    int res = await SqlConnect.ExecuteAsync(sql);
                    MessageBox.Show($"Затронуто строк: {res}");
                }
                else if (rbSelect.Checked)
                {
                    dataGridView.DataSource = null; 
                    DataTable table = await SqlConnect.SelectAsync(sql);
                    dataGridView.DataSource = table;
                }
                else
                {
                    var res = await SqlConnect.GetScalarAsync(sql);
                    MessageBox.Show($"Результат: {res}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            dataGridView.DataSource = null;
        }
    }
}