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
    
    public partial class frm_qasm : Form
    {
        Class4 cls = new Class4();
        public frm_qasm()
        {

            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void qasmBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.qasmBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eMSDataSet);

        }

        private void frm_qasm_Load(object sender, EventArgs e)
        {
            cls.SelectAllqasm(Dgv);
            if (Dgv.RowCount > 0)
            {
                Font columnFont = new Font("Cairo", 10, FontStyle.Regular);

                Dgv.Columns["ne"].HeaderText = "رقم";
                Dgv.Columns["ne"].DefaultCellStyle.Font = columnFont;
                Dgv.Columns["ne"].Width = 200;



                Dgv.Columns["qasm"].HeaderText = "القسم / الوحدة";
                Dgv.Columns["qasm"].DefaultCellStyle.Font = columnFont;
                Dgv.Columns["qasm"].Width = 450;

            }
        
            // TODO: This line of code loads data into the 'eMSDataSet.qasm' table. You can move, or remove it, as needed.
            this.qasmTableAdapter.Fill(this.eMSDataSet.qasm);

        }

        private void but_add_emplyee_Click(object sender, EventArgs e)
        {
            
            try
            {
                cls.Insertqasm(Convert.ToInt32(neTextBox.Text), qasmTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ClearData();
            cls.SelectAllqasm(Dgv);
        }

        private void but_restert_Click(object sender, EventArgs e)
        {
            cls.SelectAllqasm(Dgv);
        }

        private void but_delt_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("هل تريد حذف هذا السجل ", " حذف سجل", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                cls.Deleteqasm(Convert.ToInt32(neTextBox.Text));
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            neTextBox.Text = cls.MaxIdqasm().Rows[0][0].ToString();
            // --------- ضع هذا الكود في حدث اللود او في زر الاضافة

        }

        //-----------public void ClearData---------
        public void ClearData()
        {
            neTextBox.Text = null;
            qasmTextBox.Text = null;
           
        }

    }
}
