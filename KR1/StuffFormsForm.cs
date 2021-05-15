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
    public partial class StuffFormsForm : Form
    {
        public StuffFormsForm()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void providerBtn_Click(object sender, EventArgs e)
        {
            ProvidersForm f = new ProvidersForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void repairBtn_Click(object sender, EventArgs e)
        {
            RepairForm f = new RepairForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void locationBtn_Click(object sender, EventArgs e)
        {
            LocationForm f = new LocationForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }

        private void purchasesBtn_Click(object sender, EventArgs e)
        {
            PurchasesWithEditingForm f = new PurchasesWithEditingForm();
            Hide();
            f.ShowDialog(this);
            Show();
        }
    }
}
