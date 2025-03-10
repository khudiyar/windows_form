using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2k2
{
    public partial class ContactForm : Form
    {
        private string data;
        public ContactForm(string data = "DEFAULT")
        {
            this.data = data;
            InitializeComponent();
        }

        public void setData(string data="DEFAULT")
        {
            this.data = data;
        }

        public string getData()
        {
            return this.data;
        }

        private void ContactForm_Load(object sender, EventArgs e)
        {
            txtSecond.Text = this.data;
        }
    }
}
