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
    public partial class ReportProviderForm : Form
    {
        public ReportProviderForm()
        {
            InitializeComponent();
        }

        private void ReportProviderForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "BD_KRDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.ProviderTableAdapter.Fill(this.BD_KRDataSet.Provider);

            this.reportViewer1.RefreshReport();
        }
    }
}
