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
    public partial class FormConsultation : Form
    {
        public FormConsultation()
        {
            InitializeComponent();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            textBoxFIO.Text = "";
            textBoxPhone.Text = "";
            textBoxMessage.Text = "";
            MessageBox.Show("Ваше сообщение успешно доставлено!", "Спасибо!", MessageBoxButtons.OK);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
