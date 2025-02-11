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
    public partial class rpt_record : Form
    {
        public rpt_record()
        {
            InitializeComponent();


        }

        private void rpt_record_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'EMSDataSet.rbc' table. You can move, or remove it, as needed.
            this.rbcTableAdapter.Fill(this.EMSDataSet.rbc);

            this.reportViewer1.RefreshReport();
        }
        public DataTable FilteredData { get; set; }

    }
}
