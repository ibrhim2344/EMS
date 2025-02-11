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
    public partial class notes : Form
    {
        Class2 cls = new Class2();
        add_nots form = new add_nots();
        public notes()
        {
            InitializeComponent();
        }

        private void notes_Load(object sender, EventArgs e)
        {
            cls.SelectAllnotes(dg_note);

            if (dg_note.RowCount > 0)
            {
                Font columnFont = new Font("Cairo", 10, FontStyle.Regular);

                dg_note.Columns["id_note"].HeaderText = "م";
                dg_note.Columns["id_note"].DefaultCellStyle.Font = columnFont;
                dg_note.Columns["id_note"].Width = 150;

                dg_note.Columns["name_emp"].HeaderText = "الاسم كامل";
                dg_note.Columns["name_emp"].DefaultCellStyle.Font = columnFont;
                dg_note.Columns["name_emp"].Width = 430;

                dg_note.Columns["txt_date"].HeaderText = "التاريخ";
                dg_note.Columns["txt_date"].DefaultCellStyle.Font = columnFont;
                dg_note.Columns["txt_date"].Width = 300;


                dg_note.Columns["tixte_note"].HeaderText = "الملاحظة";
                dg_note.Columns["tixte_note"].DefaultCellStyle.Font = columnFont;
                dg_note.Columns["tixte_note"].Width = 550;

                dg_note.Columns["qasm"].HeaderText = "القسم/الوحدة";
                dg_note.Columns["qasm"].DefaultCellStyle.Font = columnFont;
                dg_note.Columns["qasm"].Width = 300;


            }

        }

        private void but_restert_note_Click(object sender, EventArgs e)
        {
            cls.SelectAllnotes(dg_note);
        }

        private void but_add_note_Click(object sender, EventArgs e)
        {
            add_nots add_nots = new add_nots();
            add_nots.Show();
            add_nots.but_edit.Visible = false;
        }



        private void but_delt_note_Click(object sender, EventArgs e)
        {
            try
            {
                // تأكد من وجود صف محدد في الجدول
                if (dg_note.CurrentRow != null)
                {
                    // الحصول على معرف الملاحظة من الصف المحدد
                    int noteId = Convert.ToInt32(dg_note.CurrentRow.Cells["id_note"].Value);

                    // عرض رسالة تأكيد الحذف
                    if (MessageBox.Show("هل تريد حذف هذا السجل؟", "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // حذف السجل
                        cls.Deletenotes(noteId);
                        
                        // تحديث الجدول بعد الحذف
                        cls.SelectAllnotes(dg_note);
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء تحديد سجل للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء حذف السجل: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dg_note_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // إخفاء زر الحفظ عند فتح الفورم
                add_nots form = new add_nots();
                form.Show();
                form.but_save.Visible = false;

                form.id_note.Text = dg_note.CurrentRow.Cells[0].Value.ToString();
                form.name_emp.Text = dg_note.CurrentRow.Cells[1].Value.ToString();
                form.txt_date.Value = Convert.ToDateTime(dg_note.CurrentRow.Cells[2].Value);
                form.tixte_note.Text = dg_note.CurrentRow.Cells[3].Value.ToString();
                form.com_qasm.Text = dg_note.CurrentRow.Cells[4].Value.ToString();
            }
            catch (Exception ex)
            {
                return;
            }

        }

        private void txte_sersh_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txte_sersh.Text))
                {
                    // Call the search method from cls instance and assign to DataGridView
                    dg_note.DataSource = cls.Searchnotes(txte_sersh.Text);
                }
                else
                {
                    // If search box is empty, show all notes
                    cls.SelectAllnotes(dg_note);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_date_1_Validated(object sender, EventArgs e)
        {
            try
            {
                UpdateDateSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في تحديد التاريخ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txt_date_2_Validated(object sender, EventArgs e)
        {
            try
            {
                UpdateDateSearch();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في تحديد التاريخ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateDateSearch()
        {
            // تحقق من أن كلا التاريخين صالحين
            if (txt_date_1.Value <= txt_date_2.Value)
            {
                // البحث بين التاريخين
                dg_note.DataSource = cls.betweennotes(txt_date_1.Value, txt_date_2.Value);
            }
            else
            {
                MessageBox.Show("يجب أن يكون تاريخ البداية قبل أو يساوي تاريخ النهاية", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // إعادة تعيين التواريخ إلى قيم منطقية
                txt_date_2.Value = txt_date_1.Value;
                cls.SelectAllnotes(dg_note);
            }
        }

        private void but_rpt_note_Click(object sender, EventArgs e)
        {
            try
            {
                if (dg_note.RowCount == 0)
                {
                    MessageBox.Show("لا يوجد بيانات للعرض", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create DataTable with the same structure as DataGridView
                DataTable dt = new DataTable();
                
                // تعريف الأعمدة مع تحديد أنها لا تقبل القيم الفارغة للـ id_note
                dt.Columns.Add("id_note", typeof(int)).AllowDBNull = false;
                dt.Columns.Add("name_emp", typeof(string));
                dt.Columns.Add("txt_date", typeof(DateTime));
                dt.Columns.Add("tixte_note", typeof(string));
                dt.Columns.Add("qasm", typeof(string));

                // نسخ البيانات مع التأكد من عدم وجود قيم فارغة
                foreach (DataGridViewRow row in dg_note.Rows)
                {
                    if (row.Cells["id_note"].Value != null)
                    {
                        DataRow dRow = dt.NewRow();
                        dRow["id_note"] = Convert.ToInt32(row.Cells["id_note"].Value);
                        dRow["name_emp"] = row.Cells["name_emp"].Value ?? DBNull.Value;
                        dRow["txt_date"] = row.Cells["txt_date"].Value ?? DBNull.Value;
                        dRow["tixte_note"] = row.Cells["tixte_note"].Value ?? DBNull.Value;
                        dRow["qasm"] = row.Cells["qasm"].Value ?? DBNull.Value;
                        dt.Rows.Add(dRow);
                    }
                }

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("لا يوجد بيانات صالحة للعرض في التقرير", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create and show the report form with filtered data
                rpt_note reportForm = new rpt_note();
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
            DataTable dt = cls.Searchnotesqa(ser_qasem.Text);
            dg_note.DataSource = dt;


        }

        //private void ser_qasem_TextChanged(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        if (!string.IsNullOrWhiteSpace(txte_sersh.Text))
        //        {
        //            // Call the search method from cls instance and assign to DataGridView
        //            dg_note.DataSource = cls.Searchnotes(txte_sersh.Text);
        //        }
        //        else
        //        {
        //            // If search box is empty, show all notes
        //            cls.Searchnotesqa(dg_note);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

       
       
    }
}
