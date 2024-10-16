using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placement_Cell
{
    public partial class Student_View_Notification : Form
    {
        public Student_View_Notification()
        {
            InitializeComponent();
            grid();
        }
        SqlConnection con = new SqlConnection("server=HP;database=Placement_Cell;uid=sa;password=User123");
        public void grid()
        {
            int id = ids();
            con.Open();
            string query = "select Class,Department,Name,Email,Company,Designation,Date from Assign_Student where Sid='" + id + "'";
            DataSet ds = new DataSet();
            SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
            sqlda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
        public int ids()
        {
            con.Open();
            int id = 0;
            string query = "select * from Stdent_Reg where Uid='" + Program.Uid + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = Convert.ToInt16(dr[0].ToString());
            }
            con.Close();
            return id;
        }
    }
}
