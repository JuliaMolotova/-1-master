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
    public partial class FormOrders : Form
    {
        public FormOrders()
        {
            InitializeComponent();
            ShowOrders();
            ShowAgents();
            ShowClients();
            ShowService();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxAgent.SelectedItem != null && comboBoxClient.SelectedItem != null && comboBoxService.SelectedItem != null)
            {
                Orders orders   = new Orders();
                orders.IdAgents = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                orders.IdClients = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                orders.IdService = Convert.ToInt32(comboBoxService.SelectedItem.ToString().Split('.')[0]);
                orders.DateStart = textBoxDateStart.Text;
                orders.DateEnd = textBoxDateEnd.Text;
                Program.РосБизнесСофт.Orders.Add(orders);
                Program.РосБизнесСофт.SaveChanges();
                ShowOrders();
            }
            else MessageBox.Show("", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                Orders orders = listViewOrders.SelectedItems[0].Tag as Orders;
                orders.IdAgents = Convert.ToInt32(comboBoxAgent.SelectedItem.ToString().Split('.')[0]);
                orders.IdClients = Convert.ToInt32(comboBoxClient.SelectedItem.ToString().Split('.')[0]);
                orders.IdService = Convert.ToInt32(comboBoxService.SelectedItem.ToString().Split('.')[0]);
                orders.DateStart = textBoxDateStart.Text;
                orders.DateEnd = textBoxDateEnd.Text;
                Program.РосБизнесСофт.SaveChanges();
                ShowOrders();
            }
        }

        void ShowOrders()
        {
            listViewOrders.Items.Clear();
            foreach (Orders orders in Program.РосБизнесСофт.Orders)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                orders.AgentsSet.FIO,
                orders.ClientsSet.FIO,
                orders.Service.Variety,
                orders.DateStart,
                orders.DateEnd
                });
                item.Tag = orders;
                listViewOrders.Items.Add(item);
            }
        }

        void ShowAgents()
        {
            comboBoxAgent.Items.Clear();
            foreach (AgentsSet agentSet in Program.РосБизнесСофт.AgentsSet)
            {
                string[] item = { agentSet.Id.ToString() + ". ", "" + agentSet.FIO };
                comboBoxAgent.Items.Add(string.Join("", item));
            }
        }

        void ShowClients()
        {
            comboBoxClient.Items.Clear();
            foreach (ClientsSet clientsSet in Program.РосБизнесСофт.ClientsSet)
            {
                string[] item = { clientsSet.Id.ToString() + ". ", "" + clientsSet.FIO };
                comboBoxClient.Items.Add(string.Join("", item));
            }
        }

        void ShowService()
        {
            comboBoxService.Items.Clear();
            foreach (Service service in Program.РосБизнесСофт.Service)
            {
                string[] item = { service.Id.ToString() + ". ", "" + service.Variety};
                comboBoxService.Items.Add(string.Join("", item));
            }
        }

        private void listViewOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewOrders.SelectedItems.Count == 1)
            {
                Orders orders = listViewOrders.SelectedItems[0].Tag as Orders;
                comboBoxAgent.SelectedIndex = comboBoxAgent.FindString(orders.IdAgents.ToString());
                comboBoxClient.SelectedIndex = comboBoxClient.FindString(orders.IdClients.ToString());
                comboBoxService.SelectedIndex = comboBoxService.FindString(orders.IdService.ToString());
            }
            else
            {
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxService.SelectedItem = null;
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewOrders.SelectedItems.Count == 1)
                {
                    Orders orders = listViewOrders.SelectedItems[0].Tag as Orders;
                    Program.РосБизнесСофт.Orders.Remove(orders);
                    Program.РосБизнесСофт.SaveChanges();
                    ShowOrders();
                }
                textBoxDateStart.Text = "";
                textBoxDateEnd.Text = "";
                comboBoxAgent.SelectedItem = null;
                comboBoxClient.SelectedItem = null;
                comboBoxService.SelectedItem = null;
            }
            catch
            {
                MessageBox.Show("Невозможно удалить!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
