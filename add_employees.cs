using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WIA;

namespace min
{
    public partial class add_employees : Form
    {
        Class1 cls = new Class1();
        public add_employees()
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

        private void add_employees_Load(object sender, EventArgs e)
        {
            LoadDataIntoComboBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            id_emp.Text = cls.MaxIdemployees().Rows[0][0].ToString();
        }

        private void but_save_Click(object sender, EventArgs e)
        {
            try
            {
                MemoryStream ms6 = new MemoryStream();
                watik.Image.Save(ms6, watik.Image.RawFormat);
                byte[] byteimage6 = ms6.ToArray();

                //// تحويل النص إلى رقم صحيح للمعامل الرابع
                //int watnyNumber = Convert.ToInt32(nmr_watny.Text);

                cls.Insertemployees(
                    Convert.ToInt32(id_emp.Text),  // int
                    text_name.Text,               // string
                    txte_qsam.Text,               // string
                    nmr_watny.Text,                  // int
                    nmr_phon.Text,                // string
                    notes_smal.Text,              // string
                    byteimage6,                    // byte[]
                    study.Text
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ClearData();
        }
        //-----------Public void Image---------
        public void ChoosePicture(PictureBox watik)
        {
            OpenFileDialog a = new OpenFileDialog();
            a.AddExtension = true;
            a.CheckPathExists = true;
            a.CheckFileExists = true;
            a.Title = "Choose Image";
            a.Filter = "Choose Image (*.PNG; *.JPG; *.GIF; *.JPEG)| *.PNG; *.JPG; *.GIF; *.JPEG | All Files (*.*)|*.*";
            if (a.ShowDialog() == DialogResult.OK)
            {
                watik.Image = Image.FromFile(a.FileName);
            }
        }


        private void but_file_Click(object sender, EventArgs e)
        {
            ChoosePicture(watik);
        }

        private void watik_Click(object sender, EventArgs e)
        {

        }
        //-----------public void ClearData---------
        public void ClearData()
        {
            id_emp.Text = null;
            text_name.Text = null;
            txte_qsam.Text = null;
            nmr_watny.Text = null;
            nmr_phon.Text = null;
            notes_smal.Text = null;
            study.Text = null;
            watik.Image = null;
        }

        private void but_edit_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] byteimage6;
                if (watik.Image != null)
                {
                    using (MemoryStream ms6 = new MemoryStream())
                    {
                        watik.Image.Save(ms6, watik.Image.RawFormat);
                        byteimage6 = ms6.ToArray();
                        cls.Updateemployees(Convert.ToInt32(id_emp.Text), text_name.Text, txte_qsam.Text,
                            nmr_watny.Text, nmr_phon.Text, notes_smal.Text, byteimage6, study.Text);
                    }
                }
                else
                {
                    MessageBox.Show("الرجاء اختيار صورة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ClearData();
            this.Close();
        }

        private void but_scan_Click(object sender, EventArgs e)
        {
            try
            {
                var deviceManager = new DeviceManager();
                
                // Check if any scanners are connected
                if (deviceManager.DeviceInfos.Count == 0)
                {
                    MessageBox.Show("لم يتم العثور على أي ماسح ضوئي متصل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Find the first available scanner
                DeviceInfo scannerInfo = null;
                foreach (DeviceInfo info in deviceManager.DeviceInfos)
                {
                    if (info.Type == WiaDeviceType.ScannerDeviceType)
                    {
                        scannerInfo = info;
                        break;
                    }
                }

                if (scannerInfo == null)
                {
                    MessageBox.Show("لم يتم العثور على ماسح ضوئي", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Connect to the scanner
                var device = scannerInfo.Connect();
                var scanner = device.Items[1]; // Usually, the first item is the scanner itself

                // Set scanning properties
                const string WIA_SCAN_COLOR_MODE = "6146";
                const string WIA_HORIZONTAL_RESOLUTION = "6147";
                const string WIA_VERTICAL_RESOLUTION = "6148";

                scanner.Properties[WIA_SCAN_COLOR_MODE].set_Value(1); // Color
                scanner.Properties[WIA_HORIZONTAL_RESOLUTION].set_Value(300); // DPI
                scanner.Properties[WIA_VERTICAL_RESOLUTION].set_Value(300); // DPI

                // Perform the scan
                var imageFile = (ImageFile)scanner.Transfer(FormatID.wiaFormatJPEG);

                if (imageFile != null)
                {
                    // Convert scanned image to byte array
                    byte[] imageBytes = (byte[])imageFile.FileData.get_BinaryData();
                    
                    using (var ms = new MemoryStream(imageBytes))
                    {
                        // Display the scanned image
                        watik.Image = Image.FromStream(ms);
                        watik.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    
                    MessageBox.Show("تم المسح الضوئي بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (COMException comEx)
            {
                MessageBox.Show("خطأ في الاتصال بالماسح الضوئي: " + comEx.Message, "خطأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء المسح الضوئي: " + ex.Message, "خطأ", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txte_qsam_SelectedIndexChanged(object sender, EventArgs e)
        {

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
                            txte_qsam.DataSource = dt;
                            txte_qsam.ValueMember = "qasm";    // القيمة الفعلية (Value)
                            txte_qsam.DisplayMember = "qasm"; // النص الظاهر (Display)
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
