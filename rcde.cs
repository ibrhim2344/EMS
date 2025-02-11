using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace min
{
    class rcde
    {
        public SqlConnection cn = new SqlConnection(@"server= .\SQLEXPRESS;database=EMS;Integrated security=true");



        //-----------public void Insert---------
        public void InsertRecord(int ID, string NEMEPL, TimeSpan timeAttendance, TimeSpan timedeparture, DateTime DATE, string qasm)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("InsertRecord", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int) { Value = ID };
            Param[1] = new SqlParameter("@NEMEPL", SqlDbType.NVarChar) { Value = NEMEPL };
            Param[2] = new SqlParameter("@timeAttendance", SqlDbType.Time) { Value = timeAttendance };
            Param[3] = new SqlParameter("@timedeparture", SqlDbType.Time) { Value = timedeparture };
            Param[4] = new SqlParameter("@DATE", SqlDbType.Date) { Value = DATE };
            Param[5] = new SqlParameter("@qasm", SqlDbType.NVarChar) { Value = qasm };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم الحفظ بنجاح ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        //--------------public Function MaxIf--------------
        public DataTable MaxIdRecord()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ("MaxIdRecord");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            return dt;
        }



        //-----------public void Delete---------
        public void DeleteRecord(int ID)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("DeleteRecord", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@ID", SqlDbType.Int) { Value = ID };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم الحذف بنجاح ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //--------------public Sub SelectAll------------
        public DataTable SelectAllRecord(DataGridView recordDataGridView)
        {
            DataTable Dt = new DataTable();
            Dt.Clear();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ("SelectAllRecord");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(Dt);
            recordDataGridView.DataSource = Dt;
            return Dt;
        }



        //-----------Public Function betwen----------
        public DataTable betweenRecord(DateTime Date1, DateTime Date2)
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlCommand Cmd = new SqlCommand();
            SqlParameter[] param = new SqlParameter[2];
            param[0] = new SqlParameter("@Date1", SqlDbType.Date) { Value = Date1 };
            param[1] = new SqlParameter("@Date2", SqlDbType.Date) { Value = Date2 };
            Cmd.Parameters.AddRange(param);
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ("betweenRecord");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            return dt;
        }



        //--------------public Function Search-----------
        public DataTable Searchemployees(string text_name)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Searchemployees", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@text_name", SqlDbType.NVarChar, 700) { Value = text_name };
            Cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



        public DataTable SearchemployeesByDepartment(string department)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("SearchemployeesByDepartment", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@txte_qsam", SqlDbType.NVarChar, 700) { Value = department };
            Cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }



        //--------------public Function Search-----------
        public DataTable SearchRecord(string NEMEPL)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("SearchRecord", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@NEMEPL", SqlDbType.NVarChar, 700) { Value = NEMEPL };
            Cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // ---  امام البارمتر الذي تم اختياره في الاجراء المخزن سابقا(Where)قم بتحديد ال
        // -- Go to Button Code


        //--------------public Function Search-----------
        public DataTable SearchRecordqa(string qasm)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("SearchRecordqa", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@qasm", SqlDbType.NVarChar, 700) { Value = qasm };
            Cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // ---  امام البارمتر الذي تم اختياره في الاجراء المخزن سابقا(Where)قم بتحديد ال
        // -- Go to Button Code

        

    }
}
