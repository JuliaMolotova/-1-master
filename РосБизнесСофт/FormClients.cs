using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace РосБизнесСофт
{
    public partial class FormClients : Form
    {
        public FormClients()
        {
            InitializeComponent();
            ShowСlients();
        }

        private void listViewClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewClients.SelectedItems.Count == 1)
            {
                ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;
                textBoxBusiness.Text = clientsSet.Business;
                textBoxFIO.Text = clientsSet.FIO;
                textBoxPhone.Text = clientsSet.Phone;
                textBoxEmail.Text = clientsSet.Email;
            }
            else
            {
                textBoxBusiness.Text = "";
                textBoxFIO.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
                ClientsSet clientsSet = new ClientsSet();
                clientsSet.Business = textBoxBusiness.Text;
                clientsSet.FIO = textBoxFIO.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                Program.РосБизнесСофт.ClientsSet.Add(clientsSet);
                Program.РосБизнесСофт.SaveChanges();
                ShowСlients();
        }

        void ShowСlients()
        {
            listViewClients.Items.Clear();
            foreach (ClientsSet clientsSet in Program.РосБизнесСофт.ClientsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                    clientsSet.Id.ToString(), clientsSet.Business, clientsSet.FIO, clientsSet.Phone, clientsSet.Email
                });
                item.Tag = clientsSet;
                listViewClients.Items.Add(item);
            }
            listViewClients.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {

            if (listViewClients.SelectedItems.Count == 1)
            {
                ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;
                clientsSet.Business = textBoxBusiness.Text;
                clientsSet.FIO = textBoxFIO.Text;
                clientsSet.Phone = textBoxPhone.Text;
                clientsSet.Email = textBoxEmail.Text;
                Program.РосБизнесСофт.ClientsSet.Add(clientsSet);
                Program.РосБизнесСофт.SaveChanges();
                ShowСlients(); ;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewClients.SelectedItems.Count == 1)
                {
                    ClientsSet clientsSet = listViewClients.SelectedItems[0].Tag as ClientsSet;
                    Program.РосБизнесСофт.ClientsSet.Remove(clientsSet);
                    Program.РосБизнесСофт.SaveChanges();
                    ShowСlients();
                }
                textBoxBusiness.Text = "";
                textBoxFIO.Text = "";
                textBoxPhone.Text = "";
                textBoxEmail.Text = ""; 
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
