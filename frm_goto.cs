using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace min
{
    public partial class frm_goto : Form
    {
        Class3 cls = new Class3();
        public frm_goto()
        {
            InitializeComponent();
        }

        private void frm_goto_Load(object sender, EventArgs e)
        {
            cls.SelectAllttgoto(dg_goto);

            if (dg_goto.RowCount > 0)
            {
                Font columnFont = new Font("Cairo", 10, FontStyle.Regular);

                dg_goto.Columns["id_goto"].HeaderText = "م";
                dg_goto.Columns["id_goto"].DefaultCellStyle.Font = columnFont;
                dg_goto.Columns["id_goto"].Width = 150;



                dg_goto.Columns["date"].HeaderText = "التاريخ";
                dg_goto.Columns["date"].DefaultCellStyle.Font = columnFont;
                dg_goto.Columns["date"].Width = 300;


                dg_goto.Columns["note"].HeaderText = "الملاحظة";
                dg_goto.Columns["note"].DefaultCellStyle.Font = columnFont;
                dg_goto.Columns["note"].Width = 550;

                dg_goto.Columns["absence"].HeaderText = "النوع";
                dg_goto.Columns["absence"].DefaultCellStyle.Font = columnFont;
                dg_goto.Columns["absence"].Width = 430;

                dg_goto.Columns["name_emp"].HeaderText = "الاسم كامل";
                dg_goto.Columns["name_emp"].DefaultCellStyle.Font = columnFont;
                dg_goto.Columns["name_emp"].Width = 400;

                dg_goto.Columns["qasm"].HeaderText = "القسم/الوحدة";
                dg_goto.Columns["qasm"].DefaultCellStyle.Font = columnFont;
                dg_goto.Columns["qasm"].Width = 350;
            }
        }

        private void but_add_emplyee_Click(object sender, EventArgs e)
        {
            add_goto add_goto = new add_goto();
            add_goto.Show();
            add_goto.but_edit.Visible = false;
        }

        private void but_restert_Click(object sender, EventArgs e)
        {
            cls.SelectAllttgoto(dg_goto);
        }

        private void dg_goto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // إخفاء زر الحفظ عند فتح الفورم
                add_goto form = new add_goto();
                form.Show();
                form.but_save.Visible = false;

                form.id_goto.Text = dg_goto.CurrentRow.Cells[0].Value.ToString();
                form.absence.Text = dg_goto.CurrentRow.Cells[1].Value.ToString();
                form.date.Value = Convert.ToDateTime(dg_goto.CurrentRow.Cells[2].Value);
                form.note.Text = dg_goto.CurrentRow.Cells[3].Value.ToString();
                form.name_emp.Text = dg_goto.CurrentRow.Cells[4].Value.ToString();
                form.com_qasm.Text = dg_goto.CurrentRow.Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                // يمكنك تسجيل الخطأ إذا أردت، لكن حالياً يتم تجاهله
                return;
            }

        }

        private void but_delt_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_goto.CurrentRow != null)
                {
                    if (MessageBox.Show("هل تريد حذف هذا السجل؟", "حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                    {
                        int id = Convert.ToInt32(dg_goto.CurrentRow.Cells["id_goto"].Value);
                        cls.Deletettgoto(id);
                        cls.SelectAllttgoto(dg_goto); // Refresh the grid after deletion
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء تحديد صف للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عملية الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void user_name_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = cls.Searchttgoto(user_name.Text);
            dg_goto.DataSource = dt;
        }

        private void txt_date_1_Validated(object sender, EventArgs e)
        {

        }

        private void txt_date_2_Validated(object sender, EventArgs e)
        {
            DataTable dt = cls.betweenttgoto(txt_date_1.Value, txt_date_2.Value);
            dg_goto.DataSource = dt;

        }

        private void but_rpt_goto_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_goto.RowCount == 0)
                {
                    MessageBox.Show("لا يوجد بيانات للعرض", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create DataTable with the same structure as DataGridView
                DataTable dt = new DataTable();

                // تعريف الأعمدة مع تحديد أنها لا تقبل القيم الفارغة للـ id_note
                dt.Columns.Add("id_goto", typeof(int)).AllowDBNull = false;
                dt.Columns.Add("date", typeof(DateTime));
                dt.Columns.Add("note", typeof(string));
                dt.Columns.Add("absence", typeof(string));
                dt.Columns.Add("name_emp", typeof(string));
                

                // نسخ البيانات مع التأكد من عدم وجود قيم فارغة
                foreach (DataGridViewRow row in dg_goto.Rows)
                {
                    if (row.Cells["id_goto"].Value != null)
                    {
                        DataRow dRow = dt.NewRow();
                        dRow["id_goto"] = Convert.ToInt32(row.Cells["id_goto"].Value);
                        dRow["date"] = row.Cells["date"].Value ?? DBNull.Value;
                        dRow["note"] = row.Cells["note"].Value ?? DBNull.Value;
                        dRow["absence"] = row.Cells["absence"].Value ?? DBNull.Value;
                        dRow["name_emp"] = row.Cells["name_emp"].Value ?? DBNull.Value;
                        dt.Rows.Add(dRow);
                    }
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا يوجد بيانات صالحة للعرض في التقرير", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create and show the report form with filtered data
                rpt_goto reportForm = new rpt_goto();
                reportForm.FilteredData = dt;
                reportForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء إنشاء التقرير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ser_qasem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cls.SearchttgotoByDepartment(ser_qasem.Text);
                dg_goto.DataSource = dt;

                // If search box is empty, show all employees
                if (string.IsNullOrWhiteSpace(ser_qasem.Text))
                {
                    cls.SelectAllttgoto(dg_goto);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_goto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        
        
    }
}
