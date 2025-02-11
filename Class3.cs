using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace min
{
    class Class3
    {
        public SqlConnection cn = new SqlConnection(@"server= .\SQLEXPRESS;database=EMS;Integrated security=true");


        //--------------public Sub SelectAll------------
        public DataTable SelectAllttgoto(DataGridView dg_goto)
        {
            DataTable Dt = new DataTable();
            Dt.Clear();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ("SelectAllttgoto");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(Dt);
            dg_goto.DataSource = Dt;
            return Dt;
        }


        //-----------public void Insert---------
        //-----------public void Insert---------
        public void Insertttgoto(int id_goto, DateTime date, string note, string absence, string name_emp, string qasm)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Insertttgoto", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@id_goto", SqlDbType.Int) { Value = id_goto };
            Param[1] = new SqlParameter("@date", SqlDbType.Date) { Value = date };
            Param[2] = new SqlParameter("@note", SqlDbType.NVarChar) { Value = note };
            Param[3] = new SqlParameter("@absence", SqlDbType.NVarChar) { Value = absence };
            Param[4] = new SqlParameter("@name_emp", SqlDbType.NVarChar) { Value = name_emp };
            Param[5] = new SqlParameter("@qasm", SqlDbType.NVarChar) { Value = qasm };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم الحفظ بنجاح ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        //-----------public void Update---------
        public void Updatettgoto(int id_goto, DateTime date, string note, string absence, string name_emp, string qasm)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Updatettgoto", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[6];
            Param[0] = new SqlParameter("@id_goto", SqlDbType.Int) { Value = id_goto };
            Param[1] = new SqlParameter("@date", SqlDbType.Date) { Value = date };
            Param[2] = new SqlParameter("@note", SqlDbType.NVarChar) { Value = note };
            Param[3] = new SqlParameter("@absence", SqlDbType.NVarChar) { Value = absence };
            Param[4] = new SqlParameter("@name_emp", SqlDbType.NVarChar) { Value = name_emp };
            Param[5] = new SqlParameter("@qasm", SqlDbType.NVarChar) { Value = qasm };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم التعديل بنجاح ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }




        //-----------public void Delete----------
        public void Deletettgoto(int id_goto)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Deletettgoto", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id_goto", SqlDbType.Int) { Value = id_goto };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم الحذف بنجاح ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //--------------public Function MaxIf--------------
        public DataTable MaxIdttgoto()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ("MaxIdttgoto");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            return dt;
        }

        //--------------public Function Search-----------
        public DataTable Searchttgoto(string name_emp)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Searchttgoto", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name_emp", SqlDbType.VarChar, 300) { Value = name_emp };
            Cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        // ---  امام البارمتر الذي تم اختياره في الاجراء المخزن سابقا(Where)قم بتحديد ال
        // -- Go to Button Code


        //-----------Public Function betwen----------
        public DataTable betweenttgoto(DateTime Date1, DateTime Date2)
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
            Cmd.CommandText = ("betweenttgoto");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable FillComboBoxEmployees(string qsam = null)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.Text;
            
            // استعلام لاختيار الموظفين الفريدين من جدول employees
            string query = "SELECT DISTINCT txte_qsam FROM employees";
            if (!string.IsNullOrEmpty(qsam))
            {
                query += " WHERE qasm = @qsam";
                cmd.Parameters.AddWithValue("@qsam", qsam);
            }
            
            cmd.CommandText = query;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            return dt;
        }

        public DataTable SearchttgotoByDepartment(string department)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("SearchttgotoByDepartment", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@qasm", SqlDbType.NVarChar, 700) { Value = department };
            Cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }




    }
}
