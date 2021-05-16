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
    public partial class ReportRepairForm : Form
    {
        public ReportRepairForm()
        {
            InitializeComponent();
        }

        private void ReportRepairForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BD_KRDataSet.Repair". При необходимости она может быть перемещена или удалена.
            this.RepairTableAdapter.Fill(this.BD_KRDataSet.Repair);

            this.reportViewer1.RefreshReport();
        }
    }
}
