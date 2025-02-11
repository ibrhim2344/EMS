using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace min
{
    public partial class employees : Form
    {
        Class1 cls = new Class1();
        public employees()
     
        {
            InitializeComponent();
           
        }

        private void but_add_emplyee_Click(object sender, EventArgs e)
        {
            add_employees add_employees = new add_employees();
            add_employees.Show();
            add_employees.but_edit.Visible = false;
        }
        

        private void employees_Load(object sender, EventArgs e)
        {
            cls.SelectAllemployees(dg_ems);
            if (dg_ems.RowCount > 0)
            {
                Font columnFont = new Font("Cairo", 10, FontStyle.Regular);

                dg_ems.Columns["id_emp"].HeaderText = "م";
                dg_ems.Columns["id_emp"].DefaultCellStyle.Font = columnFont;
                dg_ems.Columns["id_emp"].Width = 80;

                dg_ems.Columns["text_name"].HeaderText = "الاسم كامل";
                dg_ems.Columns["text_name"].DefaultCellStyle.Font = columnFont;
                dg_ems.Columns["text_name"].Width = 300;

                dg_ems.Columns["txte_qsam"].HeaderText = "القسم/الوحدة";
                dg_ems.Columns["txte_qsam"].DefaultCellStyle.Font = columnFont;
                dg_ems.Columns["txte_qsam"].Width = 300;

                dg_ems.Columns["nmr_watny"].HeaderText = "الرقم الوطني";
                dg_ems.Columns["nmr_watny"].DefaultCellStyle.Font = columnFont;
                dg_ems.Columns["nmr_watny"].Width = 300;

                dg_ems.Columns["nmr_phon"].HeaderText = "رقم الهاتف";
                dg_ems.Columns["nmr_phon"].DefaultCellStyle.Font = columnFont;
                dg_ems.Columns["nmr_phon"].Width = 300;

                dg_ems.Columns["notes_smal"].HeaderText = "الصفة";
                dg_ems.Columns["notes_smal"].DefaultCellStyle.Font = columnFont;
                dg_ems.Columns["notes_smal"].Width = 300;

                dg_ems.Columns["watik"].HeaderText = "وثيقة";
                dg_ems.Columns["watik"].DefaultCellStyle.Font = columnFont;
                dg_ems.Columns["watik"].Width = 250;

                dg_ems.Columns["study"].HeaderText = "المؤهل العلمي";
                dg_ems.Columns["study"].DefaultCellStyle.Font = columnFont;
                dg_ems.Columns["study"].Width = 300;
            }

        }

        
        

        private void but_restert_Click(object sender, EventArgs e)
        {
            cls.SelectAllemployees(dg_ems);
        }

        

        private void dg_ems_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || dg_ems.CurrentRow == null)
            {
                return;
            }

            try
            {
                add_employees form = new add_employees();
                form.Show();
                form.but_save.Visible = false;
                form.but_edit.Visible = true;

                // تعيين القيم من DataGridView إلى الحقول المختلفة في الفورم
                if (dg_ems.CurrentRow.Cells["id_emp"].Value != null)
                    form.id_emp.Text = dg_ems.CurrentRow.Cells["id_emp"].Value.ToString();

                if (dg_ems.CurrentRow.Cells["text_name"].Value != null)
                    form.text_name.Text = dg_ems.CurrentRow.Cells["text_name"].Value.ToString();

                if (dg_ems.CurrentRow.Cells["txte_qsam"].Value != null)
                    form.txte_qsam.Text = dg_ems.CurrentRow.Cells["txte_qsam"].Value.ToString();

                if (dg_ems.CurrentRow.Cells["nmr_watny"].Value != null)
                    form.nmr_watny.Text = dg_ems.CurrentRow.Cells["nmr_watny"].Value.ToString();

                if (dg_ems.CurrentRow.Cells["nmr_phon"].Value != null)
                    form.nmr_phon.Text = dg_ems.CurrentRow.Cells["nmr_phon"].Value.ToString();

                if (dg_ems.CurrentRow.Cells["notes_smal"].Value != null)
                    form.notes_smal.Text = dg_ems.CurrentRow.Cells["notes_smal"].Value.ToString();

                // استعادة الصورة من قاعدة البيانات
                if (dg_ems.CurrentRow.Cells["watik"].Value != null && dg_ems.CurrentRow.Cells["watik"].Value != DBNull.Value)
                {
                    byte[] pictureData = (byte[])dg_ems.CurrentRow.Cells["watik"].Value;
                    using (MemoryStream ms = new MemoryStream(pictureData))
                    {
                        form.watik.Image = Image.FromStream(ms);
                    }
                }
                if (dg_ems.CurrentRow.Cells["study"].Value != null)
                    form.study.Text = dg_ems.CurrentRow.Cells["study"].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل البيانات: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ser_name_TextChanged(object sender, EventArgs e)
        {
            DataTable dt = cls.Searchemployees(ser_name.Text);
            dg_ems.DataSource = dt;

        }

        private void ser_qasem_TextChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dt = cls.SearchemployeesByDepartment(ser_qasem.Text);
                dg_ems.DataSource = dt;
                
                // If search box is empty, show all employees
                if (string.IsNullOrWhiteSpace(ser_qasem.Text))
                {
                    cls.SelectAllemployees(dg_ems);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء البحث: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_wtika_Click(object sender, EventArgs e)
        {
            if (dg_ems.RowCount == 0)
            {
                MessageBox.Show("لا يوجد بيانات للعرض", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the current data from DataGridView
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dg_ems.Columns)
            {
                dt.Columns.Add(col.Name);
            }

            foreach (DataGridViewRow row in dg_ems.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }

            // Create and show the report form with filtered data
            rpt_em reportForm = new rpt_em();
            reportForm.FilteredData = dt;
            reportForm.Show();
        }

        private void but_delt_Click(object sender, EventArgs e)
        {
            if (dg_ems.CurrentRow != null)
            {
                if (MessageBox.Show("هل تريد حذف هذا السجل ", " حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    int id_emp = Convert.ToInt32(dg_ems.CurrentRow.Cells["id_emp"].Value);
                    cls.Deleteemployees(id_emp);
                    // Refresh the DataGridView after deletion
                    cls.SelectAllemployees(dg_ems);
                }
            }
            else
            {
                MessageBox.Show("الرجاء تحديد صف للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void but_rpt_wtika_Click(object sender, EventArgs e)
        {
            // Check if any rows are selected
            if (dg_ems.SelectedRows.Count == 0 && dg_ems.SelectedCells.Count == 0)
            {
                MessageBox.Show("الرجاء تحديد صف واحد على الأقل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Check if multiple rows are selected
            if (dg_ems.SelectedRows.Count > 1 || dg_ems.SelectedCells.Count > 1)
            {
                MessageBox.Show("الرجاء تحديد صف واحد فقط", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Get the selected row
            DataGridViewRow selectedRow;
            if (dg_ems.SelectedRows.Count > 0)
                selectedRow = dg_ems.SelectedRows[0];
            else
                selectedRow = dg_ems.Rows[dg_ems.SelectedCells[0].RowIndex];

            // Check if watik column has data
            if (selectedRow.Cells["watik"].Value == null || selectedRow.Cells["watik"].Value == DBNull.Value)
            {
                MessageBox.Show("لا توجد وثيقة متاحة لهذا الموظف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Create and show the rpt_watik form with the image
            rpt_watik rptForm = new rpt_watik();
            byte[] imageData = (byte[])selectedRow.Cells["watik"].Value;
            rptForm.DisplayImage(imageData);
            rptForm.Show();
        }

        
    }
}
