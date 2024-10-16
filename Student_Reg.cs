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
    public partial class Student_Reg : Form
    {
        public Student_Reg()
        {
            InitializeComponent();
            Sid();
            Uid();
        }
        SqlConnection con = new SqlConnection("server=HP;database=Placement_Cell;uid=sa;password=User123");
        public void Sid()
        {
            con.Open();
            string query = "SELECT ISNULL(MAX(Sid), 200) + 1 AS NewSid FROM Stdent_Reg";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[0].ToString();
            }
            con.Close();
        }
        public void Uid()
        {
            con.Open();
            string query = "SELECT ISNULL(MAX(Uid), 1000) + 1 AS NewUid FROM Login";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox7.Text = dr[0].ToString();
            }
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Stdent_Reg values(" + textBox1.Text + "," + textBox7.Text + ",'" + textBox2.Text + "','" + comboBox1.Text + "'," + textBox3.Text + ",'" + comboBox2.Text + "','" + textBox10.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            SqlCommand cmd = new SqlCommand(query,con);
            if(cmd.ExecuteNonQuery()>0 )
            {
                string query2 = "insert into Login values(" + textBox7.Text + ",'" + textBox8.Text + "','" + textBox9.Text + "','Student')";
                SqlCommand cmd2 = new SqlCommand(query2,con);
                if(cmd2.ExecuteNonQuery()>0 )
                {
                    Login obj = new Login();
                    obj.Show();
                }
            }
            con.Close();
        }
    }
}
