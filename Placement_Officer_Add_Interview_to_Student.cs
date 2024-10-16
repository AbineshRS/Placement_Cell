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
    public partial class Placement_Officer_Add_Interview_to_Student : Form
    {
        public Placement_Officer_Add_Interview_to_Student()
        {
            InitializeComponent();
            combo();
            combo2();
        }
        SqlConnection con = new SqlConnection("server=HP;database=Placement_Cell;uid=sa;password=User123");
        public void combo()
        {
            con.Open();
            string query = "select * from Add_Marks ";
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
            string query = "select * from Add_Marks ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox2.Items.Add(dr[4].ToString());
            }
            con.Close();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Add_Marks where Department='" + comboBox2.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox3.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Add_Marks where Mid='" + comboBox3.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[2].ToString();
                textBox2.Text = dr[5].ToString();
                textBox3.Text = dr[6].ToString();
            }
            con.Close();
        }
        public void combo2()
        {
            con.Open();
            string query = "select * from Add_Placement where PlacementOfficerid='" + Program.poc + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox4.Items.Add(dr[2].ToString());
            }
            con.Close();
        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Add_Placement where PlacementOfficerid='" + Program.poc + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox5.Items.Add(dr[3].ToString());
            }
            con.Close();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Add_Placement where PlacementOfficerid='" + Program.poc + "' ";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                var min = dr[4].ToString();
                var mx = dr[5].ToString();


                if (DateTime.TryParse(min, out DateTime mindate) && DateTime.TryParse(mx, out DateTime maxdate))
                {
                    dateTimePicker1.MinDate = mindate;
                    dateTimePicker1.MaxDate = maxdate;
                    dateTimePicker1.Value = mindate;
                }

            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string query = "insert into Assign_Student values(" + Program.poc + ",'" + comboBox1.Text + "','" + comboBox2.Text + "'," + comboBox3.Text + ",'" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + comboBox4.Text + "','" + comboBox5.Text + "','" + dateTimePicker1.Text + "','0')";
            SqlCommand cmd = new SqlCommand(query, con);
            if(cmd.ExecuteNonQuery()>0 )
            {
                MessageBox.Show("Added");
            }
            con.Close();
        }
    }
}
