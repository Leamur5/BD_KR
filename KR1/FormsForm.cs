using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KR1
{
    public partial class FormsForm : Form
    {
        public FormsForm()
        {
            InitializeComponent();
        }

        private void adminFormsBtn_Click(object sender, EventArgs e)
        {
            AdminFormsForm f = new AdminFormsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void stuffFormsBtn_Click(object sender, EventArgs e)
        {
            StuffFormsForm f = new StuffFormsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
