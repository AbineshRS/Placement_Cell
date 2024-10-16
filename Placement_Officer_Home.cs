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
    public partial class Placement_Officer_Home : Form
    {
        public Placement_Officer_Home()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login obj = new Login();
            obj.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Placement_Officer_Add_Placemenet_drive obj = new Placement_Officer_Add_Placemenet_drive();
            obj.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {
            Placement_Officer_View_Student obj = new Placement_Officer_View_Student();
            obj.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Placement_Officer_View_Student obj = new Placement_Officer_View_Student();
            obj.Show();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Placement_Officer_Add_Interview_to_Student obj = new Placement_Officer_Add_Interview_to_Student();
            obj.Show();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Placement_Officer_Add_Interview_Marks obj = new Placement_Officer_Add_Interview_Marks();
            obj.Show();
        }
    }
}
