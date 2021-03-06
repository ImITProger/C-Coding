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
        public List<User> db = new List<User>();
        int pageSize = 3;
        int pageNumber = 0;
        int pageMax = 0;
        int s = 1;
        public Base()
        {
            InitializeComponent();
            scr_val = 0;
        }
        int scr_val;
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
            db.Add(new User() {                 Login = "admin", 
                                                Email = "admin@mail.ru",
                                                Name = "admin", 
                                                Surname = "admin",
                                                Telephone = "+7(999) 999-99-99" ,
                                              });
            db.Add(new User() {                 Login = "sir",
                                                Email = "sir@mail.ru",
                                                Name = "sir",
                                                Surname = "sir",
                                                Telephone = "+7(799) 999-99-99",
                                              });
            db.Add(new User() {                 Login = "grom",
                                                Email = "grom@mail.ru",
                                                Name = "grom",
                                                Surname = "grom",
                                                Telephone = "+7(989) 999-99-99",
                                              });
            db.Add(new User() {                 Login = "groza",
                                                Email = "groza@mail.ru",
                                                Name = "groza",
                                                Surname = "groza",
                                                Telephone = "+7(988) 999-99-99",
                                             });
            db.Add(new User() {                 Login = "good",
                                                Email = "good@mail.ru",
                                                Name = "good",
                                                Surname = "good",
                                                Telephone = "+7(777) 999-99-99",
                                             });
            db.Add(new User() {                 Login = "wait",
                                                Email = "wait@mail.ru",
                                                Name = "wait",
                                                Surname = "wait",
                                                Telephone = "+7(456) 999-99-99",
                                             });
            db.Add(new User() {                 Login = "sila",
                                                Email = "sila@mail.ru",
                                                Name = "sila",
                                                Surname = "sila",
                                                Telephone = "+7(568) 999-99-99",
                                             });
            db.Add(new User() {                 Login = "ura",
                                                Email = "ura@mail.ru",
                                                Name = "ura",
                                                Surname = "ura",
                                                Telephone = "+7(564) 999-99-99",
                                             });
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            dataGridView.ReadOnly = true;
            double temp = db.Count / 3;
            pageMax = Convert.ToInt32(Math.Ceiling(temp));
            for(int i = 0; i < pageSize; ++i)
            {
                dataGridView.Rows.Add();
                dataGridView.Rows[i].Cells[0].Value = db[pageNumber + i].Login;
                dataGridView.Rows[i].Cells[1].Value = db[pageNumber + i].Email;
                dataGridView.Rows[i].Cells[2].Value = db[pageNumber + i].Name;
                dataGridView.Rows[i].Cells[3].Value = db[pageNumber + i].Surname;
                dataGridView.Rows[i].Cells[4].Value = db[pageNumber + i].Telephone;
            }
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

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if(pageNumber > 0)
            {
                dataGridView.Rows.Clear();
                pageNumber = pageNumber - 1;
                for (int i = 0; i < pageSize; ++i)
                {
                    if ((pageNumber * pageSize) + i < db.Count)
                    {
                        dataGridView.Rows.Add();
                        dataGridView.Rows[i].Cells[0].Value = db[(pageNumber * pageSize) + i].Login;
                        dataGridView.Rows[i].Cells[1].Value = db[(pageNumber * pageSize) + i].Email;
                        dataGridView.Rows[i].Cells[2].Value = db[(pageNumber * pageSize) + i].Name;
                        dataGridView.Rows[i].Cells[3].Value = db[(pageNumber * pageSize) + i].Surname;
                        dataGridView.Rows[i].Cells[4].Value = db[(pageNumber * pageSize) + i].Telephone;
                    }
                }
                lblPageNumber.Text = (pageNumber + 1).ToString();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (pageNumber + 1 <= pageMax)
            {
                pageNumber = pageNumber + 1;
                dataGridView.Rows.Clear();
                lblPageNumber.Text = (pageNumber + 1).ToString();
                for (int i = 0; i < pageSize; ++i)
                {
                    if ((pageNumber * pageSize) + i < db.Count)
                    {
                        dataGridView.Rows.Add();
                        dataGridView.Rows[i].Cells[0].Value = db[(pageNumber * pageSize) + i].Login;
                        dataGridView.Rows[i].Cells[1].Value = db[(pageNumber * pageSize) + i].Email;
                        dataGridView.Rows[i].Cells[2].Value = db[(pageNumber * pageSize) + i].Name;
                        dataGridView.Rows[i].Cells[3].Value = db[(pageNumber * pageSize) + i].Surname;
                        dataGridView.Rows[i].Cells[4].Value = db[(pageNumber * pageSize) + i].Telephone;
                    }
                }
            }

        }

        private void lblPageNumber_Click(object sender, EventArgs e)
        {

        }

        private void lblEndPage_Click(object sender, EventArgs e)
        {

        }
    }
}
