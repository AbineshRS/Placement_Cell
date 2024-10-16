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
using static System.Net.Mime.MediaTypeNames;

namespace Placement_Cell
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("server=HP;database=Placement_Cell;uid=sa;password=User123");

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "pwd")
            {
                Admin_Home obj = new Admin_Home();
                obj.Show();
            }
            else
            {
                con.Open();
                string query = "select * from Login where Username='" + textBox1.Text + "' and Password='" + textBox2.Text + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    if (dr[3].ToString() == "PlacementOfficer")
                    {
                        Placement_Officer_Home obj = new Placement_Officer_Home();
                        obj.Show();
                        Program.poc = dr[0].ToString();
                    }
                    else if (dr[3].ToString() == "Student")
                    {
                        Student_Home obj = new Student_Home();
                        obj.Show();
                        Program.Uid = dr[0].ToString();
                    }
                }
                con.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {
           
            DialogResult result = MessageBox.Show("Do you want to proceed to the next page?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            
            if (result == DialogResult.Yes)
            {
                
                Student_Reg nextForm = new Student_Reg();
                nextForm.Show(); 
                this.Hide();
            }
           
        }

    }
}
