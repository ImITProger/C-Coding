using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Labarator1
{

    public partial class Registration : Form
    {
        Base Base = new Base();
        public Registration()
        {
            InitializeComponent();
        }
        public Registration(Base Base2)
        {
            InitializeComponent();
            Base = Base2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (LoginTxt.Text == "")
            {
                MessageBox.Show("Поля пустые!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (User user1 in Base.db)
            {
                if (user1.Email == EmailTxt.Text || user1.Login == LoginTxt.Text)
                { 
                    MessageBox.Show("Такой пользователь или почти существует!"); 
                    return; 
                }
                
            }
            if (string.IsNullOrEmpty(LoginTxt.Text) || string.IsNullOrEmpty(EmailTxt.Text))
            { 
                MessageBox.Show("Проверьте поля они у вас пустые");
                return;
            }
            if (PhoneTxt.Text.Length < 10)
            {
                MessageBox.Show("Номер не верный,проверьте кол-во цыфров");
                return;
            }

            User user = new User() { Login = LoginTxt.Text, Password = PasswordTxt.Text, Name = NameTxt.Text, Surname = Surnametxt.Text, Telephone = PhoneTxt.Text, Email = EmailTxt.Text };
            Base.db.Add(user);
            
            

        }

        private void Registration_Load(object sender, EventArgs e)
        {
           
        }
    }
}
