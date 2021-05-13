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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void formsBtn_Click(object sender, EventArgs e)
        {
            FormsForm f = new FormsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void reportsBtn_Click(object sender, EventArgs e)
        {
            ReportsForm f = new ReportsForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void infoBtn_Click(object sender, EventArgs e)
        {
            InfoForm f = new InfoForm();
            f.Show();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
