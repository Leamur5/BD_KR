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
    public partial class ReportServiceLifeForm : Form
    {
        public ReportServiceLifeForm()
        {
            InitializeComponent();
        }

        private void ReportServiceLifeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BD_KRDataSet.Computer". При необходимости она может быть перемещена или удалена.
            this.ComputerTableAdapter.Fill(this.BD_KRDataSet.Computer);

            this.reportViewer1.RefreshReport();
        }
    }
}
