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
    public partial class add_nots : Form
    {
        public SqlConnection cn = new SqlConnection(@"server= .\SQLEXPRESS;database=EMS;Integrated security=true");
        Class2 cls = new Class2();
        public add_nots()
        {
            InitializeComponent();
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void but_mins_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void add_nots_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
         
           

        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                // حاول تحويل النص المدخل إلى تاريخ
                DateTime dateValue;
                if (DateTime.TryParse(txt_date.Text, out dateValue))
                {
                    cls.Insertnotes(Convert.ToInt32(id_note.Text), name_emp.Text, dateValue, tixte_note.Text, com_qasm.Text);
                }
                else
                {
                    MessageBox.Show("الرجاء إدخال تاريخ صحيح", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
               cls.Updatenotes(Convert.ToInt32(id_note.Text), name_emp.Text, txt_date.Value, tixte_note.Text, com_qasm.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


            ClearData();
            this.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_note.Text = cls.MaxIdnotes().Rows[0][0].ToString();
            // --------- ضع هذا الكود في حدث اللود او في زر الاضافة

        }

       


        //-----------public void ClearData---------
        public void ClearData()
        {
            id_note.Text = null;
            name_emp.Text = null;
            txt_date.Value = DateTime.Now;
            tixte_note.Text = null;
        }

        private void com_qasm_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        // دالة لتحميل البيانات من قاعدة البيانات إلى الـ ComboBox
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
