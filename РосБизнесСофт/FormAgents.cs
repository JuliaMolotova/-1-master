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
    public partial class FormAgents : Form
    {
        public FormAgents()
        {
            InitializeComponent();
            ShowAgents();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AgentsSet agentsSet = new AgentsSet();
            agentsSet.FIO = textBoxFIO.Text;
            agentsSet.Position = textBoxPosition.Text;
            agentsSet.Email = textBoxEmail.Text;
            Program.РосБизнесСофт.AgentsSet.Add(agentsSet);
            Program.РосБизнесСофт.SaveChanges();
            ShowAgents();
        }

        void ShowAgents()
        {
            listViewAgents.Items.Clear();
            foreach (AgentsSet agentsSet in Program.РосБизнесСофт.AgentsSet)
            {
                ListViewItem item = new ListViewItem(new string[]
                {
                agentsSet.Id.ToString(), agentsSet.FIO, agentsSet.Position,
                agentsSet.Email
                });
                item.Tag = agentsSet;
                listViewAgents.Items.Add(item);
            }
            listViewAgents.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (listViewAgents.SelectedItems.Count == 1)
            {
                AgentsSet agentsSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                agentsSet.FIO = textBoxFIO.Text;
                agentsSet.Position = textBoxPosition.Text;
                agentsSet.Email = textBoxEmail.Text;;
                Program.РосБизнесСофт.SaveChanges();
                ShowAgents();
            }
        }

        private void listViewAgents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAgents.SelectedItems.Count == 1)
            {
                AgentsSet agentsSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                textBoxFIO.Text = agentsSet.FIO;
                textBoxPosition.Text = agentsSet.Position;
                textBoxEmail.Text = agentsSet.Email;
            }
            else
            {
                textBoxFIO.Text = "";
                textBoxPosition.Text = "";
                textBoxEmail.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (listViewAgents.SelectedItems.Count == 1)
                {
                    AgentsSet agentsSet = listViewAgents.SelectedItems[0].Tag as AgentsSet;
                    Program.РосБизнесСофт.AgentsSet.Remove(agentsSet);
                    Program.РосБизнесСофт.SaveChanges();
                    ShowAgents();
                }
                textBoxFIO.Text = "";
                textBoxPosition.Text = "";
                textBoxEmail.Text = "";
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
