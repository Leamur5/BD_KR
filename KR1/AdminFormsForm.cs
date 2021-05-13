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
    public partial class AdminFormsForm : Form
    {
        public AdminFormsForm()
        {
            InitializeComponent();
        }

        private void computersBtn_Click(object sender, EventArgs e)
        {
            ComputersForm f = new ComputersForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void networkBtn_Click(object sender, EventArgs e)
        {
            NetworkForm f = new NetworkForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void employeeBtn_Click(object sender, EventArgs e)
        {
            EmployeeForm f = new EmployeeForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void accessoriesBtn_Click(object sender, EventArgs e)
        {
            AccessoriesForm f = new AccessoriesForm();
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
