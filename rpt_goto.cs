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
    public partial class rpt_goto : Form
    {
        public DataTable FilteredData { get; set; }
        public rpt_goto()
        {
            InitializeComponent();
        }

        private void rpt_goto_Load(object sender, EventArgs e)
        {
            try
            {
                if (FilteredData != null && FilteredData.Rows.Count > 0)
                {
                    // Use filtered data if available
                    this.EMSDataSet.ttgoto.Clear();
                    foreach (DataRow row in FilteredData.Rows)
                    {
                        this.EMSDataSet.ttgoto.ImportRow(row);
                    }
                }
                else
                {
                    // If no filtered data, load all data
                    this.ttgotoTableAdapter.Fill(this.EMSDataSet.ttgoto);
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
