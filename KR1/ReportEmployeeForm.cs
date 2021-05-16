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
    public partial class ReportEmployeeForm : Form
    {
        public ReportEmployeeForm()
        {
            InitializeComponent();
        }

        private void ReportEmployeeForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // TODO: данная строка кода позволяет загрузить данные в таблицу "EmployeeDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.EmployeeTableAdapter.Fill(this.EmployeeDataSet.Employee, textBox1.Text + '%');

            this.reportViewer1.RefreshReport();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
