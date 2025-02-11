using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;


namespace min
{
   
    class Class4
    {
        public SqlConnection cn = new SqlConnection(@"server= .\SQLEXPRESS;database=EMS;Integrated security=true");

        //--------------public Sub SelectAll------------
        public DataTable SelectAllqasm(DataGridView Dgv)
        {
            DataTable Dt = new DataTable();
            Dt.Clear();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ("SelectAllqasm");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(Dt);
            Dgv.DataSource = Dt;
            return Dt;
        }


        //-----------public void Insert---------
        public void Insertqasm(int ne, string qasm)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Insertqasm", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[2];
            Param[0] = new SqlParameter("@ne", SqlDbType.Int) { Value = ne };
            Param[1] = new SqlParameter("@qasm", SqlDbType.NVarChar) { Value = qasm };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم الحفظ بنجاح ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //-----------public void Delete---------
        public void Deleteqasm(int ne)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Deleteqasm", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ne", SqlDbType.Int) { Value = ne };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم الحذف بنجاح ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //--------------public Function MaxIf--------------
        public DataTable MaxIdqasm()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ("MaxIdqasm");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            return dt;
        }





    }
}
