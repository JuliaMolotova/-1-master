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
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form form1C = new Form1C();
            form1C.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form formPO = new FormPO();
            formPO.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formAvt = new FormAvt();
            formAvt.Show();
        }
    }
}
