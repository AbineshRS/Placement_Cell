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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Placement_Cell
{
    public partial class Placement_Officer_Add_Placemenet_drive : Form
    {
        public Placement_Officer_Add_Placemenet_drive()
        {
            InitializeComponent();
            id();

        }
        SqlConnection con = new SqlConnection("server=HP;database=Placement_Cell;uid=sa;password=User123");
        public void id()
        {
            con.Open();
            string query = "SELECT ISNULL(MAX(Placementid), 200) + 1 AS NewPlacementid FROM Add_Placement";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Add_Placement values(" + textBox1.Text + ",'" + Program.poc + "','" + textBox2.Text + "','" + textBox3.Text + "','" + dateTimePicker1.Text + "','" + dateTimePicker2.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Added");
            }
            con.Close();
        }
    }
}
