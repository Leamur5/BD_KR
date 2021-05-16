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
    public partial class ReportNetworkForm : Form
    {
        public ReportNetworkForm()
        {
            InitializeComponent();
        }

        private void ReportNetworkForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BD_KRDataSet.Network". При необходимости она может быть перемещена или удалена.
            this.NetworkTableAdapter.Fill(this.BD_KRDataSet.Network);

            this.reportViewer1.RefreshReport();
        }
    }
}
