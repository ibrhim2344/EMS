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
   
    public partial class add_goto : Form
    {
        Class3 cls = new Class3();
        public add_goto()
        {
            InitializeComponent();
        }

        private void add_goto_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_mins_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_goto.Text = cls.MaxIdttgoto().Rows[0][0].ToString();
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                cls.Insertttgoto(Convert.ToInt32(id_goto.Text), date.Value, note.Text, absence.Text, name_emp.Text, com_qasm.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            ClearData();
            
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            try
            {
                cls.Updatettgoto(Convert.ToInt32(id_goto.Text), date.Value, note.Text, absence.Text, name_emp.Text, com_qasm.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




            ClearData();
            this.Close();
        }
        //-----------public void ClearData---------
        public void ClearData()
        {
            id_goto.Text = null;
            date.Value = DateTime.Now;
            note.Text = null;
            absence.Text = null;
            name_emp.Text = null;
        }

        private void com_qasm_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (com_qasm.SelectedItem != null)
                {
                    DataTable dt = cls.FillComboBoxEmployees(com_qasm.SelectedItem.ToString());
                    com_qasm.DataSource = dt;
                    com_qasm.DisplayMember = "txte_qsam";
                    com_qasm.ValueMember = "txte_qsam";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void LoadDataIntoComboBox()
        {
            try
            {
                // سلسلة الاتصال بقاعدة البيانات (تأكد من تعديلها حسب الإعدادات لديك)
                string connectionString = @"Server=.\SQLEXPRESS;Database=EMS;Integrated Security=True;";

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    using (SqlCommand Cmd = new SqlCommand("SelectAllqasm", cn))
                    {
                        Cmd.CommandType = CommandType.StoredProcedure;

                        // فتح الاتصال
                        cn.Open();

                        // إنشاء DataTable لتحميل البيانات
                        DataTable dt = new DataTable();
                        dt.Load(Cmd.ExecuteReader());

                        // التحقق من وجود بيانات وتحميلها في الـ ComboBox
                        if (dt.Rows.Count > 0)
                        {
                            com_qasm.DataSource = dt;
                            com_qasm.ValueMember = "qasm";    // القيمة الفعلية (Value)
                            com_qasm.DisplayMember = "qasm"; // النص الظاهر (Display)
                        }
                       
                    }
                }
            }
            catch (Exception ex)
            {
                // التعامل مع أي أخطاء أثناء الاتصال أو التنفيذ
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message);
            }
        }
    }
}
