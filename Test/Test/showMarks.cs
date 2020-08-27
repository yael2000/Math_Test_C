using BL;
using DAL;
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
    public partial class showMarks : Form
    {
        public showMarks()
        {
            InitializeComponent();
            QuesAnsBL BL = new QuesAnsBL();
            List<Marks_tbl> marks = BL.getmarks();
            dataGridView1.DataSource = marks;
        }
    }
}
