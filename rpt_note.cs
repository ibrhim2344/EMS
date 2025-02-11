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
    public partial class rpt_note : Form
    {
        public DataTable FilteredData { get; set; }
        public rpt_note()
        {
            InitializeComponent();
        }

        private void rpt_note_Load(object sender, EventArgs e)
        {
            try
            {
                if (FilteredData != null && FilteredData.Rows.Count > 0)
                {
                    // Use filtered data if available
                    this.EMSDataSet.notes.Clear();
                    foreach (DataRow row in FilteredData.Rows)
                    {
                        this.EMSDataSet.notes.ImportRow(row);
                    }
                }
                else
                {
                    // If no filtered data, load all data
                    this.notesTableAdapter.Fill(this.EMSDataSet.notes);
                }
                
                this.reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ أثناء تحميل التقرير: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
