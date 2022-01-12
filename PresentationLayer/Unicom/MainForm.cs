using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Unicom
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonUserForm_Click(object sender, EventArgs e)
        {
            UserForm cf = new UserForm();
            cf.Visible = true;
        }

        private void buttonRequestForm_Click(object sender, EventArgs e)
        {
            RequestForm cf = new RequestForm();
            cf.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
