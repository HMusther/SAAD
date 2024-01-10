using SAAD.Constants;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAAD
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
/*            if (string.IsNullOrEmpty(emailTextBox.Text) || string.IsNullOrEmpty(passTextBox.Text))
            {
                MessageBox.Show("Fill in all details!");
                return;
            }


            var user = Database.Accounts.Where( x => x.email == emailTextBox.Text);

            if (user.Any())
            {
                if (user.First().password == passTextBox.Text)
                {*/
                    Home homepage = new Home();
                    homepage.ShowDialog();
                    this.Hide();
/*                }
            }*/


        }
    }
}
