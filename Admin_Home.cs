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
    public partial class Admin_Home : Form
    {
        public Admin_Home()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Admin_Add_Placemnt_Officer obj = new Admin_Add_Placemnt_Officer();
            obj.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Admin_View_Placement_officer obj = new Admin_View_Placement_officer();
            obj.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            View_Student_View_placementrive obj = new View_Student_View_placementrive();
            obj.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Admin_view_Placed_Student obj = new Admin_view_Placed_Student();
            obj.Show();
        }
    }
}
