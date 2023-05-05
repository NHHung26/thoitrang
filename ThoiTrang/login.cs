using MySql.Data.MySqlClient;
namespace ThoiTrang
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("server=localhost;port=3306;user=root;password=huyhung26082002;database=fashion;");
            try
            {
                conn.Open();
                string tk = txttk.Text;
                string mk = txtmk.Text;
                string mysql = "select * from login where taikhoan='" + tk + "' and matkhau='" + mk + "'";
                MySqlCommand cmd = new MySqlCommand(mysql, conn);
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read() == true)
                {
                    trangchu Tc = new trangchu();
                    Tc.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập thất bại!!",
                       "Thông báo", MessageBoxButtons.OK,
                       MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                DialogResult rs = MessageBox.Show("Bạn thực sự muốn đóng ứng dụng này?",
                   "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (rs == DialogResult.Yes)
                    this.Close();
            }
        }
    }
}