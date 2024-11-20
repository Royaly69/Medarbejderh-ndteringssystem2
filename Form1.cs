using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Medarbejderhåndteringssystem
{
    public partial class Form1 : Form
    {
        public BindingList<User> UserList { get; set; } = new BindingList<User>();

        public Form1()
        {
            ConnectionDB connection = new ConnectionDB();
            for (int i = 1; i <= connection.GetTableLength(); i++)
            {
                UserList.Add(connection.ReadDB(i));
            }
            InitializeComponent();

            BookdataGridView1.DataSource = UserList;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            User user = new User (AddFornavn.Text, AddEfterNavn.Text, AddEmail.Text, Convert.ToInt32(AddNummer.Text), Convert.ToInt32(AddAlder.Text));
            UserList.Add(user);
            ConnectionDB connection = new ConnectionDB();
            connection.CreateUser(user);

            AddFornavn.Clear();
            AddEfterNavn.Clear();
            AddEmail.Clear();
            AddNummer.Clear();
            AddAlder.Clear();
        
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < UserList.Count; i++)
            {
                if (UserList[i].TelefonNummer == Convert.ToInt32(DeleteNumber.Text))
                {
                    ConnectionDB connection = new ConnectionDB();
                    User user = UserList[i];
                    connection.DeleteUser(user);
                    UserList.RemoveAt(i);
                }
            }

        }

    }
}
