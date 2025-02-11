using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace min
{
    public partial class Record : Form
    {
        rcde rc = new rcde();
        public Record()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void employees2BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employees2BindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eMSDataSet);

        }

        private void Record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eMSDataSet.Record' table. You can move, or remove it, as needed.
            this.recordTableAdapter.Fill(this.eMSDataSet.Record);
            // TODO: This line of code loads data into the 'eMSDataSet.employees2' table. You can move, or remove it, as needed.
            this.employees2TableAdapter.Fill(this.eMSDataSet.employees2);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // التحقق من وجود صف محدد
                if (employees2DataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("الرجاء تحديد موظف من القائمة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // استخراج البيانات من الصف المحدد
                DataGridViewRow selectedRow = employees2DataGridView.SelectedRows[0];
                
                // التأكد من وجود قيم صالحة
                string employeeName = "";
                string department = "";
                bool foundName = false;
                bool foundDepartment = false;

                // البحث عن العمود الصحيح للاسم والقسم
                foreach (DataGridViewColumn col in employees2DataGridView.Columns)
                {
                    // البحث عن عمود الاسم
                    if (!foundName && (col.Name.ToLower().Contains("name") || 
                        col.HeaderText.ToLower().Contains("name") ||
                        col.HeaderText.Contains("اسم")))
                    {
                        if (selectedRow.Cells[col.Index].Value != null)
                        {
                            employeeName = selectedRow.Cells[col.Index].Value.ToString();
                            foundName = true;
                        }
                    }

                    // البحث عن عمود القسم
                    if (!foundDepartment && (col.Name.ToLower().Contains("department") || 
                        col.HeaderText.ToLower().Contains("department") ||
                        col.HeaderText.Contains("قسم")))
                    {
                        if (selectedRow.Cells[col.Index].Value != null)
                        {
                            department = selectedRow.Cells[col.Index].Value.ToString();
                            foundDepartment = true;
                        }
                    }

                    // إذا تم العثور على كلا العمودين، نخرج من الحلقة
                    if (foundName && foundDepartment)
                    {
                        break;
                    }
                }

                // التحقق من وجود البيانات المطلوبة
                if (string.IsNullOrEmpty(employeeName))
                {
                    MessageBox.Show("لم يتم العثور على اسم الموظف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(department))
                {
                    MessageBox.Show("لم يتم العثور على القسم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // إدخال البيانات
                rc.InsertRecord(
                    Convert.ToInt32(id.Text),
                    employeeName,                     // اسم الموظف
                    AttendanceTime.Value.TimeOfDay,   // وقت الحضور
                    departureTime.Value.TimeOfDay,    // وقت الانصراف
                    DateTime.Now.Date,                // تاريخ اليوم
                    department                        // القسم
                );

                // تحديث عرض السجلات وتنظيف الحقول
                rc.SelectAllRecord(recordDataGridView);
                ClearData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id.Text = rc.MaxIdRecord().Rows[0][0].ToString();
            // --------- 

        }

        private void recordDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_delt_Click(object sender, EventArgs e)
        {
            try
            {
                // التأكد من أن هناك صفًا محددًا في DataGridView
                if (recordDataGridView.SelectedRows.Count == 0)
                {
                    MessageBox.Show("الرجاء تحديد سجل للحذف.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // جلب رقم السجل من العمود الأول (الذي يحتوي على ID)
                int recordId = Convert.ToInt32(recordDataGridView.SelectedRows[0].Cells[0].Value);

                if (MessageBox.Show("هل تريد حذف هذا السجل؟", "حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
                {
                    rc.DeleteRecord(recordId);
                    MessageBox.Show("تم الحذف بنجاح", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // تحديث البيانات بعد الحذف
                    rc.SelectAllRecord(recordDataGridView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء الحذف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //-----------public void ClearData---------
        public void ClearData()
        {
            id.Text = null;
            AttendanceTime.Value = DateTime.Now;
            departureTime.Value = DateTime.Now;
        }

        private void txt_date_2_ValueChanged(object sender, EventArgs e)
        {
            DataTable dt =rc.betweenRecord(txt_date_1.Value, txt_date_2.Value);
            recordDataGridView.DataSource = dt;

        }

        private void user_name_qasm_TextChanged(object sender, EventArgs e)
        {
            // إنشاء DataTable جديد لتخزين نتائج البحث المدمجة
            DataTable mergedResults = new DataTable();

            // استرجاع البيانات بناءً على الاسم
            DataTable dt1 = rc.Searchemployees(user_name_qasm.Text);

            // استرجاع البيانات بناءً على القسم
            DataTable dt2 = rc.SearchemployeesByDepartment(user_name_qasm.Text);

            // دمج البيانات إذا كانت هناك نتائج من كلا البحثين
            if (dt1.Rows.Count > 0)
                mergedResults = dt1.Copy(); // نسخ البيانات الأولى

            if (dt2.Rows.Count > 0)
                mergedResults.Merge(dt2); // دمج بيانات البحث الثاني

            // عرض النتائج في DataGridView
            employees2DataGridView.DataSource = mergedResults;
        }

        private void employees2DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void but_sersh_TextChanged(object sender, EventArgs e)
        {
            // إنشاء DataTable جديد لتخزين نتائج البحث المدمجة
            DataTable mergedResults = new DataTable();

            // استرجاع البيانات بناءً على الاسم
            DataTable dt1 = rc.SearchRecord(user_name_qasm.Text);

            // استرجاع البيانات بناءً على القسم
            DataTable dt2 = rc.SearchRecordqa(user_name_qasm.Text);

            // دمج البيانات إذا كانت هناك نتائج من كلا البحثين
            if (dt1.Rows.Count > 0)
                mergedResults = dt1.Copy(); // نسخ البيانات الأولى

            if (dt2.Rows.Count > 0)
                mergedResults.Merge(dt2); // دمج بيانات البحث الثاني

            // عرض النتائج في DataGridView
            recordDataGridView.DataSource = mergedResults;
        }





        private void but_print_Click(object sender, EventArgs e)
        {
            try
            {
                // التحقق من وجود بيانات في الجدول
                if (recordDataGridView.RowCount == 0)
                {
                    MessageBox.Show("لا يوجد بيانات للعرض", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // إنشاء DataTable جديد لتخزين البيانات المفلترة
                DataTable filteredData = new DataTable();

                // إضافة الأعمدة بناءً على أعمدة recordDataGridView
                foreach (DataGridViewColumn column in recordDataGridView.Columns)
                {
                    // تحديد نوع البيانات المناسب لكل عمود
                    Type columnType = typeof(string); // النوع الافتراضي
                    switch (column.Name.ToLower())
                    {
                        case "id":
                            columnType = typeof(int);
                            break;
                        case "timeattendance":
                        case "timedeparture":
                            columnType = typeof(TimeSpan);
                            break;
                        case "date":
                            columnType = typeof(DateTime);
                            break;
                    }
                    filteredData.Columns.Add(column.Name, columnType);
                }

                // نسخ البيانات المفلترة من DataGridView إلى DataTable
                foreach (DataGridViewRow row in recordDataGridView.Rows)
                {
                    if (!row.IsNewRow)
                    {
                        DataRow newRow = filteredData.NewRow();
                        try
                        {
                            foreach (DataGridViewColumn column in recordDataGridView.Columns)
                            {
                                if (row.Cells[column.Name].Value != null)
                                {
                                    switch (column.Name.ToLower())
                                    {
                                        case "id":
                                            newRow[column.Name] = Convert.ToInt32(row.Cells[column.Name].Value);
                                            break;
                                        case "timeattendance":
                                        case "timedeparture":
                                            newRow[column.Name] = TimeSpan.Parse(row.Cells[column.Name].Value.ToString());
                                            break;
                                        case "date":
                                            newRow[column.Name] = Convert.ToDateTime(row.Cells[column.Name].Value);
                                            break;
                                        default:
                                            newRow[column.Name] = row.Cells[column.Name].Value.ToString();
                                            break;
                                    }
                                }
                            }
                            filteredData.Rows.Add(newRow);
                        }
                        catch (Exception ex)
                        {
                            // تجاهل الصفوف التي تحتوي على بيانات غير صالحة
                            continue;
                        }
                    }
                }

                if (filteredData.Rows.Count == 0)
                {
                    MessageBox.Show("لا يوجد بيانات صالحة للعرض في التقرير", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // عرض التقرير مع البيانات المفلترة
                rpt_record reportForm = new rpt_record();
                reportForm.FilteredData = filteredData;
                reportForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء إنشاء التقرير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //// أضف هذا الحدث لتعبئة البيانات تلقائياً عند اختيار صف
        //private void employees2DataGridView_SelectionChanged(object sender, EventArgs e)
        //{
        //    if (employees2DataGridView.SelectedRows.Count > 0)
        //    {
        //        DataGridViewRow row = employees2DataGridView.SelectedRows[0];
        //        if (row.Cells[1].Value != null)
        //        {
        //            text_name.Text = row.Cells[1].Value.ToString();  // تعبئة اسم الموظف تلقائياً
        //        }
        //    }
        //}

    }
}
