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
    class Class1
    {
        public SqlConnection cn = new SqlConnection(@"server= .\SQLEXPRESS;database=EMS;Integrated security=true");

        //--------------public Sub SelectAll------------
        public DataTable SelectAllemployees(DataGridView dg_ems)
        {
            DataTable dt = new DataTable();
            using (SqlCommand cmd = new SqlCommand("SelectAllemployees", cn))
            {
                cmd.CommandType = CommandType.StoredProcedure;
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }
            dg_ems.DataSource = dt;
            return dt;
        }



        //--------------public Function MaxIf--------------
        public DataTable MaxIdemployees()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ("MaxIdemployees");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            return dt;
        }

        //-----------public void Insert---------
        public void Insertemployees(int id_emp, string text_name, string txte_qsam, string nmr_watny, string nmr_phon, string notes_smal, byte[] watik, string study)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Insertemployees", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[8];
            Param[0] = new SqlParameter("@id_emp", SqlDbType.Int) { Value = id_emp };
            Param[1] = new SqlParameter("@text_name", SqlDbType.NVarChar) { Value = text_name };
            Param[2] = new SqlParameter("@txte_qsam", SqlDbType.NVarChar) { Value = txte_qsam };
            Param[3] = new SqlParameter("@nmr_watny", SqlDbType.VarChar) { Value = nmr_watny };
            Param[4] = new SqlParameter("@nmr_phon", SqlDbType.VarChar) { Value = nmr_phon };
            Param[5] = new SqlParameter("@notes_smal", SqlDbType.NVarChar) { Value = notes_smal };
            Param[6] = new SqlParameter("@watik", SqlDbType.Image) { Value = watik };
            Param[7] = new SqlParameter("@study", SqlDbType.NVarChar) { Value = study };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم الحفظ بنجاح ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //-----------public void Delete---------
        public void Deleteemployees(int id_emp)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Deleteemployees", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id_emp", SqlDbType.Int) { Value = id_emp };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم الحذف بنجاح ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //-----------public void Update---------
        public void Updateemployees(int id_emp, string text_name, string txte_qsam, string nmr_watny, string nmr_phon, string notes_smal, byte[] watik, string study)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Updateemployees", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[8];
            Param[0] = new SqlParameter("@id_emp", SqlDbType.Int) { Value = id_emp };
            Param[1] = new SqlParameter("@text_name", SqlDbType.NVarChar) { Value = text_name };
            Param[2] = new SqlParameter("@txte_qsam", SqlDbType.NVarChar) { Value = txte_qsam };
            Param[3] = new SqlParameter("@nmr_watny", SqlDbType.VarChar) { Value = nmr_watny };
            Param[4] = new SqlParameter("@nmr_phon", SqlDbType.VarChar) { Value = nmr_phon };
            Param[5] = new SqlParameter("@notes_smal", SqlDbType.NVarChar) { Value = notes_smal };
            Param[6] = new SqlParameter("@watik", SqlDbType.Image) { Value = watik };
            Param[7] = new SqlParameter("@study", SqlDbType.NVarChar) { Value = study };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم التعديل بنجاح ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        // ---  امام البارمتر الذي تم اختياره في الاجراء المخزن سابقا(Where)قم بتحديد ال
        // -- Go to Button Code


    }
}
