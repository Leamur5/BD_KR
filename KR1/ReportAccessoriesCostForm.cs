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
    public partial class ReportAccessoriesCostForm : Form
    {
        public ReportAccessoriesCostForm()
        {
            InitializeComponent();
        }

        private void ReportAccessoriesCostForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BD_KRDataSet.Accessories". При необходимости она может быть перемещена или удалена.
            this.AccessoriesTableAdapter.Fill(this.BD_KRDataSet.Accessories);

            this.reportViewer1.RefreshReport();
        }
    }
}
