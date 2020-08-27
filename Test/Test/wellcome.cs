using BL;
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
    public partial class wellcome : Form
    {
        StudentBL bl = new StudentBL();
        public wellcome(string user)
        {
            InitializeComponent();
            string name = bl.ReturnName(user);
            hellowText.Text = "שלום " + user;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            test testForm = new test();
            testForm.Show();
            this.Close();
        }
    }
}
