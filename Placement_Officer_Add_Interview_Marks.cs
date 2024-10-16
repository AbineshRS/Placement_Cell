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
    public partial class Placement_Officer_Add_Interview_Marks : Form
    {
        public Placement_Officer_Add_Interview_Marks()
        {
            InitializeComponent();
            combo();
        }
        SqlConnection con = new SqlConnection("server=HP;database=Placement_Cell;uid=sa;password=User123");
        public void combo()
        {
            con.Open();
            string query = "select * from Assign_Student where Uid='"+Program.poc+"'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[3].ToString());
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Assign_Student where Sid='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox3.Text = dr[4].ToString();
                textBox4.Text = dr[5].ToString();
                textBox5.Text = dr[7].ToString();
                textBox6.Text = dr[8].ToString();
                textBox7.Text = dr[9].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Assign_Student set Interview_Marks='" + textBox8.Text + "' where Sid='"+comboBox1.Text+"'";
            SqlCommand cmd = new SqlCommand (query, con);
            if(cmd.ExecuteNonQuery()>0)
            {
                MessageBox.Show("ADDed Marks");
            }
            con.Close() ;
        }
    }
}
