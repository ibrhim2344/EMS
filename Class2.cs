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
    class Class2
    {
        public SqlConnection cn = new SqlConnection(@"server= .\SQLEXPRESS;database=EMS;Integrated security=true");
        private DataTable dt = new DataTable();

        //--------------public Sub SelectAll------------
        public DataTable SelectAllnotes(DataGridView dg_note)
        {
            DataTable Dt = new DataTable();
            Dt.Clear();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ("SelectAllnotes");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(Dt);
            dg_note.DataSource = Dt;
            return Dt;
        }

        //-----------public void Insert---------
        public void Insertnotes(int id_note, string name_emp, DateTime txt_date, string tixte_note, string qasm)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Insertnotes", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[5];
            Param[0] = new SqlParameter("@id_note", SqlDbType.Int) { Value = id_note };
            Param[1] = new SqlParameter("@name_emp", SqlDbType.NVarChar) { Value = name_emp };
            Param[2] = new SqlParameter("@txt_date", SqlDbType.Date) { Value = txt_date };
            Param[3] = new SqlParameter("@tixte_note", SqlDbType.NVarChar) { Value = tixte_note };
            Param[4] = new SqlParameter("@qasm", SqlDbType.NVarChar) { Value = qasm };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم الحفظ بنجاح ", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //-----------public void Update---------
        public void Updatenotes(int id_note, string name_emp, DateTime txt_date, string tixte_note, string qasm)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Updatenotes", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[5];
            Param[0] = new SqlParameter("@id_note", SqlDbType.Int) { Value = id_note };
            Param[1] = new SqlParameter("@name_emp", SqlDbType.NVarChar) { Value = name_emp };
            Param[2] = new SqlParameter("@txt_date", SqlDbType.Date) { Value = txt_date };
            Param[3] = new SqlParameter("@tixte_note", SqlDbType.NVarChar) { Value = tixte_note };
            Param[4] = new SqlParameter("@qasm", SqlDbType.NVarChar) { Value = qasm };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم التعديل بنجاح ", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        //-----------public void Delete---------
        public void Deletenotes(int id_note)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Deletenotes", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] Param = new SqlParameter[1];
            Param[0] = new SqlParameter("@id_note", SqlDbType.Int) { Value = id_note };
            Cmd.Parameters.AddRange(Param);
            cn.Open();
            Cmd.ExecuteNonQuery();
            cn.Close();
            MessageBox.Show("تم الحذف بنجاح ", "حذف", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //--------------public Function Search-----------
        public DataTable Searchnotes(string name_emp)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Searchnotes", cn);
            Cmd.CommandType = CommandType.StoredProcedure;
            SqlParameter[] param = new SqlParameter[1];
            param[0] = new SqlParameter("@name_emp", SqlDbType.NVarChar, 700) { Value = name_emp };
            Cmd.Parameters.AddRange(param);
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
      
        //-----------Public Function betwen----------
        public DataTable betweennotes(DateTime Date1, DateTime Date2)
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
            Cmd.CommandText = ("betweennotes");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            return dt;
        }


        //--------------public Function MaxIf--------------
        public DataTable MaxIdnotes()
        {
            DataTable dt = new DataTable();
            dt.Clear();
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = ("MaxIdnotes");
            SqlDataAdapter da = new SqlDataAdapter(Cmd);
            da.Fill(dt);
            return dt;
        }



        //--------------public void Combobox -----------
        public void SelectAllnotes()
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = "SelectAllnotes";
            cn.Open();
            dt.Load(Cmd.ExecuteReader());
            cn.Close();
        }

        //--------------public Function SelectAllemployees--------------
        public DataTable SelectAllemployees(string qasm)
        {
            DataTable dt = new DataTable();
            try
            {
                using (SqlCommand cmd = new SqlCommand("SELECT DISTINCT name_emp FROM notes WHERE qasm = @qasm AND name_emp IS NOT NULL AND name_emp != '' ORDER BY name_emp", cn))
                {
                    cmd.Parameters.AddWithValue("@qasm", qasm);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("حدث خطأ في تحميل بيانات الموظفين: " + ex.Message, "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return dt;
        }

        ////--------------public Function Search-----------
        //public DataTable Searchnotesqa(string qasm)
        //{
        //    SqlCommand Cmd;
        //    Cmd = new SqlCommand("Searchnotesqa", cn);
        //    Cmd.CommandType = CommandType.StoredProcedure;
        //    SqlParameter[] param = new SqlParameter[1];
        //    param[0] = new SqlParameter("@qasm", SqlDbType.NVarChar, 700) { Value = qasm };
        //    Cmd.Parameters.AddRange(param);
        //    SqlDataAdapter da = new SqlDataAdapter(Cmd);
        //    DataTable dt = new DataTable();
        //    da.Fill(dt);
        //    return dt;
        //}
        // ---  امام البارمتر الذي تم اختياره في الاجراء المخزن سابقا(Where)قم بتحديد ال
        // -- Go to Button Code

        //--------------public Function Search-----------
        //--------------public Function Search-----------
        public DataTable Searchnotesqa(string qasm)
        {
            SqlCommand Cmd;
            Cmd = new SqlCommand("Searchnotesqa", cn);
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

        //--------------public void Combobox -----------
        public void SelectAllemployees()
        {
            SqlCommand Cmd = new SqlCommand();
            Cmd.Connection = cn;
            Cmd.CommandType = CommandType.StoredProcedure;
            Cmd.CommandText = "SelectAllemployees";
            cn.Open();
            dt.Load(Cmd.ExecuteReader());
            cn.Close();
        }

    }
}
