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
    public partial class Student_Add_Marks : Form
    {
        public Student_Add_Marks()
        {
            InitializeComponent();
            comob();
            comob2();
            grid();
        }
        SqlConnection con = new SqlConnection("server=HP;database=Placement_Cell;uid=sa;password=User123");
        public void comob()
        {
            con.Open();
            string query = "select * from Stdent_Reg where Uid='" + Program.Uid + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        public void comob2()
        {
            con.Open();
            string query = "select * from Add_Marks where Uid='" + Program.Uid + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[0].ToString());
            }
            con.Close();
        }
        public void grid()
        {
            con.Open();
            string query = "select * from Add_Marks where Uid='"+Program.Uid+"'";
            DataSet ds = new DataSet();
            SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
            sqlda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView; 
            con.Close();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Stdent_Reg where Sid='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[2].ToString();
                textBox2.Text = dr[5].ToString();
                textBox3.Text = dr[6].ToString();
                textBox4.Text = dr[8].ToString();
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Add_Marks values(" + comboBox1.Text + ",'" + Program.Uid + "','" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Success");
            }
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Add_Marks where Mid='" + comboBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox6.Text = dr[2].ToString();
                textBox10.Text = dr[3].ToString();
                textBox8.Text = dr[4].ToString();
                textBox7.Text = dr[5].ToString();
                textBox9.Text = dr[6].ToString();
            }
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "update Add_Marks set CGP='" + textBox9.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            if(cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Mark Updated");
            }
            con.Close();
        }
    }
}
