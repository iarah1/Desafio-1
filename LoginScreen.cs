using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desafio_1
{
    public partial class LoginScreen : Form
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            List<UserData.User> users = UserData.GetUsers();
            var exists_user = users.Where(j => j.username == Username.Text && j.password == Password.Text).ToList();
            if(exists_user.Count() > 0)
            {
                var userRubro = exists_user.FirstOrDefault();

                MainScreen _main = new MainScreen();
                _main.username = Username.Text;
                _main.rubroid = userRubro.rubro;
                _main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("El usuario y/o contraseña son incorrectos.");
            }
        }
    }
}
