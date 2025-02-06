using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoMediaEscolar
{
    public partial class FormLogin : Form
    {

        List<User> userList = new List<User>();

        public FormLogin()
        {
            InitializeComponent();
        }

        private async void submitButton_Click(object sender, EventArgs e)
        {
            userList.Add(new User("joelito", "Joel Filipe Fernandes Costa", "ola1234"));

            string user = userTextBox.Text;
            string password = passwordTextBox.Text;

            User foundUser = userList.Find(u => u.Username == user);

            if (foundUser != null)
            {
                string foundPassword = foundUser.Password;
                if (!string.IsNullOrEmpty(password))
                {
                    if (password == foundPassword)
                    {
                        this.Hide();
                        Form1 form1 = new Form1();
                        form1.ShowDialog();
                        form1.aluno = foundUser.Name;
                    }
                    else
                    {
                        MessageBox.Show("A password está errada.");
                    }
                }
                else
                {
                    MessageBox.Show("A password não é válida");
                }
            } else
            {
                MessageBox.Show("O utilizador é inválido.");
            }
        }
    }
}
