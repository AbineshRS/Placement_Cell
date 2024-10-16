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
    public partial class Admin_view_Placed_Student : Form
    {
        public Admin_view_Placed_Student()
        {
            InitializeComponent();
            grid();
            grid2();
        }
        SqlConnection con = new SqlConnection("server=HP;database=Placement_Cell;uid=sa;password=User123");
        public void grid()
        {
            con.Open();
            string query = "select * from Assign_Student where Interview_Marks>8";
            DataSet ds = new DataSet();
            SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
            sqlda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
        public void grid2()
        {
            con.Open();
            string query = "select * from Assign_Student where Interview_Marks<=8";
            DataSet ds = new DataSet();
            SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
            sqlda.Fill(ds);
            dataGridView2.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
    }
}
