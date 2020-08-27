using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();

            int mark = test.points;
            marklable.Text = "הציון הוא:" + mark;
            if (mark >= 90)
                comment.Text = "!!!מצויין";
            else if (mark >= 80)
                comment.Text = "!!!טוב מאוד ";
            else if (mark >= 70)
                comment.Text = "טוב!";
            else comment.Text = "עליך להשתפר :(";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            showMarks show = new showMarks();
            show.ShowDialog();
            this.Hide();
        }
    }
}
