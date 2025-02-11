using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace min
{
    public partial class login : Form
    {
        // Connection string for SQL Server
        private string connectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True";

        public login()
        {
            InitializeComponent();
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Button_Login_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = "SELECT COUNT(*) FROM uesr WHERE username = @username AND password = @password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", user_name.Text);
                        cmd.Parameters.AddWithValue("@password", Password.Text);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            // Login successful
                            MessageBox.Show("تم تسجيل الدخول بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // TODO: Add the form you want to open here
                            // For example:
                            mine mainForm = new mine();
                            mainForm.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("اسم المستخدم أو كلمة المرور غير صحيحة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في الاتصال: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
    }
}
