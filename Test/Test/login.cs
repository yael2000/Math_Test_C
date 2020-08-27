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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Enter_Click(object sender, EventArgs e)
        {
            StudentBL bl = new StudentBL();
            bool check = bl.setStudent(UserName.Text, UserPassword.Text);
            if (check)
            {
                wellcome form2 = new wellcome(UserName.Text);
                form2.ShowDialog();
                this.Hide();
            }
            else MessageBox.Show("משתמש אינו רשום!");
        }
    }
}
