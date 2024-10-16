using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Placement_Cell
{
    public partial class Student_Home : Form
    {
        public Student_Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Student_Add_Marks obj = new Student_Add_Marks();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Student_View_Interview_Marks obj = new Student_View_Interview_Marks();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Student_View_Notification obj = new Student_View_Notification();
            obj.Show();
        }
    }
}
