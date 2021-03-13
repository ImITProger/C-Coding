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
    public partial class Base : Form
    {
        public Base()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Entrance newForm = new Entrance(this);
            newForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration newForm = new Registration(this);
            newForm.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Base_Load(object sender, EventArgs e)
        {
            userBindingSource.Add(new User() {  Login = "admin", 
                                                Email = "admin@mail.ru",
                                                Name = "admin", 
                                                Surname = "admin",
                                                Telephone = "+7(999) 999-99-99" ,
                                              });
            userBindingSource.Add(new User() {  Login = "sir",
                                                Email = "sir@mail.ru",
                                                Name = "sir",
                                                Surname = "sir",
                                                Telephone = "+7(799) 999-99-99",
                                              });
            userBindingSource.Add(new User() {  Login = "grom",
                                                Email = "grom@mail.ru",
                                                Name = "grom",
                                                Surname = "grom",
                                                Telephone = "+7(989) 999-99-99",
                                              });
            userBindingSource.Add(new User() {  Login = "groza",
                                                Email = "groza@mail.ru",
                                                Name = "groza",
                                                Surname = "groza",
                                                Telephone = "+7(988) 999-99-99",
                                             });
            userBindingSource.Add(new User() {  Login = "good",
                                                Email = "good@mail.ru",
                                                Name = "good",
                                                Surname = "good",
                                                Telephone = "+7(777) 999-99-99",
                                             });
            userBindingSource.Add(new User() {  Login = "wait",
                                                Email = "wait@mail.ru",
                                                Name = "wait",
                                                Surname = "wait",
                                                Telephone = "+7(456) 999-99-99",
                                             });
            userBindingSource.Add(new User() {  Login = "sila",
                                                Email = "sila@mail.ru",
                                                Name = "sila",
                                                Surname = "sila",
                                                Telephone = "+7(568) 999-99-99",
                                             });
            userBindingSource.Add(new User() {  Login = "ura",
                                                Email = "ura@mail.ru",
                                                Name = "ura",
                                                Surname = "ura",
                                                Telephone = "+7(564) 999-99-99",
                                             });
        }

        private void userBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bindingNavigatorDeleteItem.PerformClick();
        }
    }
}
