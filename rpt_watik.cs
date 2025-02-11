using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace min
{
    public partial class rpt_watik : Form
    {
        public rpt_watik()
        {
            InitializeComponent();
        }

        public void DisplayImage(byte[] imageData)
        {
            try
            {
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    watik.Image = Image.FromStream(ms);
                    watik.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء عرض الوثيقة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rpt_watik_Load(object sender, EventArgs e)
        {
           
        }

        private void but_clos_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (watik.Image != null)
            {
                // استخدام كامل مساحة الورقة بدون هوامش
                Rectangle pageArea = e.PageBounds;

                // رسم الصورة لتغطي كامل مساحة الورقة
                e.Graphics.DrawImage(watik.Image, pageArea);
            }
        }

        private void but_print_Click_1(object sender, EventArgs e)
        {
            if (watik.Image == null)
            {
                MessageBox.Show("لا توجد صورة للطباعة", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("A4", 827, 1169);
            printDialog1.Document = printDocument1;

            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    printDocument1.Print();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء الطباعة: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void but_pdf_Click(object sender, EventArgs e)
        {
            if (watik.Image == null)
            {
                MessageBox.Show("لا توجد صورة للتحويل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "PDF files (*.pdf)|*.pdf";
            saveFileDialog.FilterIndex = 1;
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    // إنشاء نسخة من الصورة بحجم A4
                    using (Bitmap bmp = new Bitmap(827, 1169)) // A4 size in pixels at 96 DPI
                    {
                        using (Graphics g = Graphics.FromImage(bmp))
                        {
                            // تعيين جودة الرسم
                            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                            g.PixelOffsetMode = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;

                            // رسم الصورة لتملأ المساحة كاملة
                            g.DrawImage(watik.Image, 0, 0, bmp.Width, bmp.Height);
                        }

                        // حفظ الصورة بجودة عالية
                        System.Drawing.Imaging.ImageCodecInfo jpgEncoder = GetEncoder(System.Drawing.Imaging.ImageFormat.Jpeg);
                        System.Drawing.Imaging.EncoderParameters encoderParams = new System.Drawing.Imaging.EncoderParameters(1);
                        encoderParams.Param[0] = new System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 100L);

                        // حفظ كصورة عالية الجودة
                        string tempJpgPath = Path.ChangeExtension(saveFileDialog.FileName, ".jpg");
                        bmp.Save(tempJpgPath, jpgEncoder, encoderParams);

                        // تحويل الصورة إلى PDF باستخدام PrintDocument
                        using (PrintDocument pd = new PrintDocument())
                        {
                            pd.DefaultPageSettings.PaperSize = new PaperSize("A4", 827, 1169);
                            pd.PrinterSettings.PrintToFile = true;
                            pd.PrinterSettings.PrintFileName = saveFileDialog.FileName;
                            pd.PrintPage += (sender2, e2) =>
                            {
                                Image img = Image.FromFile(tempJpgPath);
                                e2.Graphics.DrawImage(img, 0, 0, e2.PageBounds.Width, e2.PageBounds.Height);
                                img.Dispose();
                            };
                            pd.Print();
                        }

                        // حذف الملف المؤقت
                        if (File.Exists(tempJpgPath))
                            File.Delete(tempJpgPath);

                        MessageBox.Show("تم حفظ الملف بنجاح", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("حدث خطأ أثناء حفظ الملف: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
    }
}
