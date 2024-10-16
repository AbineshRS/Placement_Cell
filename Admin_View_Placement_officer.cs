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
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Placement_Cell
{
    public partial class Admin_View_Placement_officer : Form
    {
        public Admin_View_Placement_officer()
        {
            InitializeComponent();
            grid();
            combo();
        }
        SqlConnection con = new SqlConnection("server=HP;database=Placement_Cell;uid=sa;password=User123");

        public void grid()
        {
            con.Open();
            string query = "select * from Add_Placement_Officer";
            DataSet ds = new DataSet();
            SqlDataAdapter sqlda = new SqlDataAdapter(query, con);
            sqlda.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            con.Close();
        }
        public void combo()
        {
            con.Open();
            string query = "select * from Add_Placement_Officer";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                comboBox1.Items.Add(dr[0].ToString());
            }
            con.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            con.Open();
            string query = "select * from Add_Placement_Officer where Pid='" + comboBox1.Text + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                textBox1.Text = dr[1].ToString();
                textBox2.Text = dr[2].ToString();
                textBox3.Text = dr[5].ToString();
                textBox4.Text = dr[8].ToString();
                string imagePath = dr[8].ToString();
                if (File.Exists(imagePath))
                {
                    pictureBox1.Image = new Bitmap(imagePath);
                }
            }
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            string[] allowedExtensions = { ".jpg", ".jpeg" };
            string sourceFilePath = textBox4.Text;
            string sourceFileExtension = Path.GetExtension(sourceFilePath).ToLower();
            if (!allowedExtensions.Contains(sourceFileExtension))
            {
                MessageBox.Show("Please upload an image in JPEG format (.jpg or .jpeg).", "Invalid File Format", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }
            string profile = Path.Combine(Application.StartupPath, "profile");
           
            string newImagePath = Path.Combine(profile, comboBox1.Text + sourceFileExtension);
            if (File.Exists(newImagePath))
            {
                File.Delete(newImagePath);
            }
            if (File.Exists(sourceFilePath))
            {
                File.Copy(sourceFilePath, newImagePath, true);
            }
            string profdb = Path.Combine("profile", comboBox1.Text + sourceFileExtension).Replace("\\", "\\");


            con.Open();
            string query = "UPDATE Add_Placement_Officer SET Name='"+textBox2.Text+"', Profile='"+profdb+"'";
            SqlCommand cmd = new SqlCommand(query, con);

            if (cmd.ExecuteNonQuery() > 0)
            {
                MessageBox.Show("Updated");
            }
            else
            {
                MessageBox.Show("Update failed");
            }

            con.Close();
        }



        private void pictureBox2_Click(object sender, EventArgs e)
        {

            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(open.FileName);
                textBox4.Text = open.FileName;

            }
        }
        
    }
}
