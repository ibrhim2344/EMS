using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace min
{
    public partial class home : Form
    {
        public SqlConnection cn = new SqlConnection(@"server= .\SQLEXPRESS;database=EMS;Integrated security=true");
        public home()
        {
            
            InitializeComponent();
        }

        private void home_Load(object sender, EventArgs e)
        {
           
            // استدعاء الدالة لتعيين الرسالة عند فتح البرنامج
            UpdateGreeting();
            try
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM employees";
                SqlCommand cmd = new SqlCommand(query, cn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Display the count in the label
                lab_emp.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

            try
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM notes";
                SqlCommand cmd = new SqlCommand(query, cn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Display the count in the label
                lab_note.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

            try
            {
                cn.Open();
                string query = "SELECT COUNT(*) FROM ttgoto";
                SqlCommand cmd = new SqlCommand(query, cn);
                int count = Convert.ToInt32(cmd.ExecuteScalar());

                // Display the count in the label
                lb_absence.Text = count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                    cn.Close();
            }

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            UpdateGreeting();

        }
        private void UpdateGreeting()
        {
            DateTime currentTime = DateTime.Now;
            string greeting;

            if (currentTime.Hour >= 17 && currentTime.Hour < 24 || (currentTime.Hour == 0 || currentTime.Hour < 6))
            {
                greeting = "مساء الخير إبراهيم";
            }
            else if (currentTime.Hour >= 6 && currentTime.Hour < 12)
            {
                greeting = "صباح الخير إبراهيم";
            }
            else
            {
                greeting = "مرحبا إبراهيم";
            }

            holle.Text = greeting; // تحديث محتوى الليبل
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            UpdateClock();
        }
        private void UpdateClock()
        {
            // عرض الوقت الحالي بتنسيق الساعة والدقيقة والثانية
            time.Text = DateTime.Now.ToString("hh:mm");
        }
       

        
    }
}
