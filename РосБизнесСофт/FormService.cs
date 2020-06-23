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
    public partial class FormService : Form
    {
        public FormService()
        {
            InitializeComponent();
            ShowService();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewPO.SelectedItems.Count == 1)
            {
                Service service = listViewPO.SelectedItems[0].Tag as Service;
                textBoxSoftware.Text = service.Software;
                textBoxPrice.Text = service.Price;
            }
            else
            {
                textBoxSoftware.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Service service = new Service();
            service.Price = textBoxPrice.Text;

            if (comboBoxVariety.SelectedIndex == 0)
            {
                service.Variety = 0;
                service.Spectrum = textBoxSpectrum.Text;
            }
            else if (comboBoxVariety.SelectedIndex == 1)
            {
                service.Variety = 1;
                service.Software = textBoxSoftware.Text;
            }
            else
            {
                service.Variety = 2;
            }
            Program.РосБизнесСофт.Service.Add(service);
            Program.РосБизнесСофт.SaveChanges();
            ShowService();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (comboBoxVariety.SelectedIndex == 0)
            {
                if (listView1C.SelectedItems.Count == 1)
                {
                    Service service = listView1C.SelectedItems[0].Tag as Service;
                    service.Spectrum = textBoxSpectrum.Text;
                    service.Price = textBoxPrice.Text;
                    Program.РосБизнесСофт.SaveChanges();
                    ShowService();
                }
            }
            else if (comboBoxVariety.SelectedIndex == 1)
            {
                if (listViewPO.SelectedItems.Count == 1)
                {
                    Service service = listView1C.SelectedItems[0].Tag as Service;
                    service.Software = textBoxSoftware.Text;
                    service.Price = textBoxPrice.Text;
                    Program.РосБизнесСофт.SaveChanges();
                    ShowService();
                }
            }
            else
            {
                if (listViewAvt.SelectedItems.Count == 1)
                {
                    Service service = listView1C.SelectedItems[0].Tag as Service;
                    service.Level3 = textBoxLevel3.Text;
                    service.Price = textBoxPrice.Text;
                    Program.РосБизнесСофт.SaveChanges();
                    ShowService();
                }
            }
        }

        void ShowService()
        {
            listView1C.Items.Clear();
            listViewPO.Items.Clear();
            listViewAvt.Items.Clear();
            foreach (Service service in Program.РосБизнесСофт.Service)
            {
                if (service.Variety == 0)
                {
                    ListViewItem item = new ListViewItem(new string[]
                    {
                    service.Spectrum, service.Price
                    });
                    item.Tag = service;
                    listView1C.Items.Add(item);
                }
                else if (service.Variety == 1)
                {
                    ListViewItem item = new ListViewItem(new string[]
                        {
                          service.Software, service.Price
                        });
                    item.Tag = service;
                    listViewPO.Items.Add(item);
                }
                else
                {
                    ListViewItem item = new ListViewItem(new string[]
                        {
                          service.Level3, service.Price
                        });
                    item.Tag = service;
                    listViewAvt.Items.Add(item);
                }
            }
            listView1C.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewPO.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            listViewAvt.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void listView1C_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1C.SelectedItems.Count == 1)
            {
                Service service = listView1C.SelectedItems[0].Tag as Service;
                textBoxSpectrum.Text = service.Spectrum;
                textBoxPrice.Text = service.Price;
            }
            else
            {
                textBoxSpectrum.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void listViewAvt_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewAvt.SelectedItems.Count == 1)
            {
                Service service = listViewAvt.SelectedItems[0].Tag as Service;
                textBoxLevel3.Text = service.Level3;
                textBoxPrice.Text = service.Price;
            }
            else
            {
                textBoxLevel3.Text = "";
                textBoxPrice.Text = "";
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxVariety.SelectedIndex == 0)
                {
                    if (listView1C.SelectedItems.Count == 1)
                    {
                        Service service = listView1C.SelectedItems[0].Tag as Service;
                        Program.РосБизнесСофт.Service.Remove(service);
                        Program.РосБизнесСофт.SaveChanges();
                        ShowService();
                    }
                    textBoxPrice.Text = "";
                }
                else if (comboBoxVariety.SelectedIndex == 1)
                {
                    if (listViewPO.SelectedItems.Count == 1)
                    {
                        Service service = listViewPO.SelectedItems[0].Tag as Service;
                        Program.РосБизнесСофт.Service.Remove(service);
                        Program.РосБизнесСофт.SaveChanges();
                        ShowService();
                    }
                    textBoxPrice.Text = "";
                }
                else
                {
                    if (listViewAvt.SelectedItems.Count == 1)
                    {
                        Service service = listViewPO.SelectedItems[0].Tag as Service;
                        Program.РосБизнесСофт.Service.Remove(service);
                        Program.РосБизнесСофт.SaveChanges();
                        ShowService(); 
                    }
                    textBoxPrice.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Невозможно удалить, эта запись используется", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
