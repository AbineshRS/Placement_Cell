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
    public partial class Admin_Add_Placemnt_Officer : Form
    {
        public Admin_Add_Placemnt_Officer()
        {
            InitializeComponent();
            Pid();
            Uid();
        }
        SqlConnection con = new SqlConnection("server=HP;database=Placement_Cell;uid=sa;password=User123");


        private void button1_Click(object sender, EventArgs e)
        {
            string profile = Path.Combine(Application.StartupPath, "profile");
            if (!Directory.Exists(profile))
            {
                Directory.CreateDirectory(profile);
            }
            string folder = Path.Combine(profile, textBox1.Text + Path.GetExtension(textBox4.Text));
            File.Copy(textBox4.Text, folder, true);
            string profdb = Path.Combine("profile", textBox1.Text + Path.GetExtension(textBox4.Text));
            con.Open();
            string query = "insert into Add_Placement_Officer values(" + textBox1.Text + "," + textBox7.Text + ",'" + textBox2.Text + "','" + dateTimePicker1.Text + "'," + textBox3.Text + ",'" + comboBox1.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + profdb + "')";
            SqlCommand cmd = new SqlCommand(query, con);
            if (cmd.ExecuteNonQuery() > 0)
            {
                string query2 = "insert into Login values(" + textBox7.Text + ",'" + textBox8.Text + "','" + textBox9.Text + "','PlacementOfficer')";
                SqlCommand cmd2 = new SqlCommand(@query2, con);
                if (cmd2.ExecuteNonQuery() > 0)
                {
                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    textBox7.Text = "";
                    textBox8.Text = "";
                    textBox9.Text = "";
                    pictureBox2.Image = null;
                }
            }
            con.Close();
        }
        public void Pid()
        {
            con.Open();
            string query = "SELECT ISNULL(MAX(Pid), 100) + 1 AS NewPid FROM Add_Placement_Officer";
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = new Bitmap(open.FileName);
                textBox4.Text = open.FileName;

            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;

            // Calculate the age
            int age = DateTime.Now.Year - selectedDate.Year;

            // Adjust if the birthday hasn't occurred yet this year
            if (DateTime.Now.Date < selectedDate.AddYears(age))
            {
                age--;
            }

            // Display the age in the TextBox
            textBox3.Text = age.ToString();

        }
    }
}
