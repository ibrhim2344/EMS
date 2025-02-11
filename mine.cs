using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using min.notvisen;
using System.Data.SqlClient;

namespace min
{
    public partial class mine : Form
    {
        public mine()
        {
            InitializeComponent();
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("هل تريد إغلاق البرنامج؟", "تأكيد الإغلاق", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void but_mins_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }

        private void min_Load(object sender, EventArgs e)
        {
            
           
            // تعيين خصائص النموذج
            this.FormBorderStyle = FormBorderStyle.None;
            this.StartPosition = FormStartPosition.Manual;
            this.Top = 1;
            this.Left = 0;
            this.Width = Screen.PrimaryScreen.WorkingArea.Width;
            this.Height = Screen.PrimaryScreen.WorkingArea.Height;
            

            // إغلاق جميع النوافذ داخل pnl_cintr
            foreach (Form form in pnl_cintr.Controls.OfType<Form>())
            {
                form.Close();
            }

            // فتح النافذة الجديدة
            home home = new home(); // استبدل هذا بالنافذة التي تريد فتحها
            home.TopLevel = false;
            home.FormBorderStyle = FormBorderStyle.None;
            home.Dock = DockStyle.Fill;
            pnl_cintr.Controls.Add(home);
            home.Show();
            notiv notiv = new notiv();
            notiv.TopMost = true; // جعل النافذة في المقدمة
            notiv.Show();

           
        }

        private void GunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void but_em_Click(object sender, EventArgs e)
        {
            foreach (Form form in pnl_cintr.Controls.OfType<Form>())
            {
                form.Close();
            }

            employees employees = new employees();
            employees.TopLevel = false;
            employees.FormBorderStyle = FormBorderStyle.None;
            employees.Dock = DockStyle.Fill;
            pnl_cintr.Controls.Add(employees);
            employees.Show();

        }

        private void but_note_Click(object sender, EventArgs e)
        {
            foreach (Form form in pnl_cintr.Controls.OfType<Form>())
            {
                form.Close();
            }

            notes notes = new notes();
            notes.TopLevel = false;
            notes.FormBorderStyle = FormBorderStyle.None;
            notes.Dock = DockStyle.Fill;
            pnl_cintr.Controls.Add(notes);
            notes.Show();
        }

        private void but_go_back_Click(object sender, EventArgs e)
        {
            foreach (Form form in pnl_cintr.Controls.OfType<Form>())
            {
                form.Close();
            }

            frm_goto employees = new frm_goto();
            employees.TopLevel = false;
            employees.FormBorderStyle = FormBorderStyle.None;
            employees.Dock = DockStyle.Fill;
            pnl_cintr.Controls.Add(employees);
            employees.Show();
        }

        private void pnl_cintr_Paint(object sender, PaintEventArgs e)
        {

        }

        private void but_around_Click(object sender, EventArgs e)
        {
            info add_nots = new info();
            add_nots.Show();
        
        }

        private void but_home_Click(object sender, EventArgs e)
        {
            foreach (Form form in pnl_cintr.Controls.OfType<Form>())
            {
                form.Close();
            }

            home employees = new home();
            employees.TopLevel = false;
            employees.FormBorderStyle = FormBorderStyle.None;
            employees.Dock = DockStyle.Fill;
            pnl_cintr.Controls.Add(employees);
            employees.Show();

        }

        private void but_Backup_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=.\\SQLEXPRESS;Initial Catalog=EMS;Integrated Security=True"))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;

                    SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                    saveFileDialog1.Filter = "Backup File|*.bak";
                    saveFileDialog1.Title = "حدد مسار النسخ الاحتياطي";

                    if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            cmd.CommandText = "BACKUP DATABASE EMS TO DISK = '" + saveFileDialog1.FileName + "'";
                            con.Open();
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("تم إنشاء النسخة الاحتياطية بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("حدث خطأ أثناء إنشاء النسخة الاحتياطية: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("لم يتم تحديد مسار النسخ الاحتياطي!", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_qasm frm_qasm = new frm_qasm();
            frm_qasm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Form form in pnl_cintr.Controls.OfType<Form>())
            {
                form.Close();
            }

            Record notes = new Record();
            notes.TopLevel = false;
            notes.FormBorderStyle = FormBorderStyle.None;
            notes.Dock = DockStyle.Fill;
            pnl_cintr.Controls.Add(notes);
            notes.Show();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    foreach (Form form in pnl_cintr.Controls.OfType<Form>())
        //    {
        //        form.Close();
        //    }

        //    frm_Entry_Time_Attandance employees = new frm_Entry_Time_Attandance();
        //    employees.TopLevel = false;
        //    employees.FormBorderStyle = FormBorderStyle.None;
        //    employees.Dock = DockStyle.Fill;
        //    pnl_cintr.Controls.Add(employees);
        //    employees.Show();
        ////}
    }
}
