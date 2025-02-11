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
    public partial class rpt_em : Form
    {
        public DataTable FilteredData { get; set; }

        public rpt_em()
        {
            InitializeComponent();
        }

        private void rpt_em_Load(object sender, EventArgs e)
        {
            if (FilteredData != null && FilteredData.Rows.Count > 0)
            {
                // Use filtered data if available
                this.EMSDataSet.employees.Clear();
                foreach (DataRow row in FilteredData.Rows)
                {
                    this.EMSDataSet.employees.ImportRow(row);
                }
            }
            else
            {
                // If no filtered data, load all data
                this.employeesTableAdapter.Fill(this.EMSDataSet.employees);
            }

            this.reportViewer1.RefreshReport();
            

        }
    }
}
