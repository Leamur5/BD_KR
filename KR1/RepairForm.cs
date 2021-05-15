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
    public partial class RepairForm : Form, ICRUDForm
    {
        private static class RepairModel
        {
            public static int id { get; set; }
            public static DateTime startDate { get; set; }
            public static DateTime endDate { get; set; }
            public static bool needToWriteOff { get; set; }
            public static int cost { get; set; }
            public static void reset()
            {
                id = -1;
                startDate = new DateTime(0001, 01, 01);
                endDate = new DateTime(0001, 01, 01);
                needToWriteOff = false;
                cost = -1;
            }
        }
        
        public RepairForm()
        {
            InitializeComponent();

            RepairModel.reset();
            clearInputs();
        }
        public void updateView()
        {
            repairTableAdapter.Fill(bD_KRDataSet.Repair);
            repairBindingSource.ResetBindings(false);
            repairDataGridView.Update();
        }
        public void insertRow()
        {
            repairTableAdapter.Insert(startDateTimePicker.Value, endDateTimePicker.Value,
                 NeedToWriteOff.Checked, Convert.ToInt32(costNumericUpDown.Value));
        }
        public void deleteRow()
        {
            repairTableAdapter.Delete(RepairModel.id,
                RepairModel.startDate, RepairModel.endDate, RepairModel.needToWriteOff,
                RepairModel.cost);
        }
        public void updateRow()
        {
            repairTableAdapter.Update(bD_KRDataSet);
        }
        public void updateInputs()
        {
            startDateTimePicker.Value = RepairModel.startDate;
            endDateTimePicker.Value = RepairModel.endDate;
            NeedToWriteOff.Checked = RepairModel.needToWriteOff;
            costNumericUpDown.Value = RepairModel.cost;
            
            string query = "SELECT Computer.ID, Computer.OperatingSystem, Computer.Cost, Computer.LifeTime, Computer.MaxLifeTime " +
                "FROM(Computer INNER JOIN Repair ON Computer.Repair_ID = Repair.ID) " +
                "WHERE(Repair.ID = " + RepairModel.id.ToString() + ")";
            computerDataGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);

        }
        public void clearInputs()
        {
            NeedToWriteOff.Checked = false;
            costNumericUpDown.Value = 0;

            for (int i = 0; i < repairDataGridView.Rows.Count; i++)
            {
                repairDataGridView.Rows[i].Selected = false;
            }
            repairDataGridView.Update();
        }
        public bool isIncorrectModel()
        {
            return RepairModel.id < 0 || RepairModel.cost < 0;
        }
        public bool isIncorrectInputs()
        {
            return  costNumericUpDown.Value < 0;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectInputs())
            {
                MessageBox.Show("Некоректные данные");
            }
            else
            {
                insertRow();
                updateView();
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectModel() || isIncorrectInputs())
            {
                MessageBox.Show("Выберите строку и введите новые значения");
            }
            else
            {
                updateRow();
                updateView();
                RepairModel.reset();
                clearInputs();
            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectModel() || isIncorrectInputs())
            {
                MessageBox.Show("Выберите строку");
            }
            else
            {
                deleteRow();
                updateView();
                RepairModel.reset();
                clearInputs();
            }
        }

        private void RepairDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            RepairModel.id = Convert.ToInt32(repairDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            RepairModel.startDate = Convert.ToDateTime(repairDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            RepairModel.endDate = Convert.ToDateTime(repairDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            RepairModel.needToWriteOff = Convert.ToBoolean(repairDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            RepairModel.cost = Convert.ToInt32(repairDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());

            updateInputs();
        }
        private void RepairForm_Click(object sender, EventArgs e)
        {
            RepairModel.reset();
            clearInputs();
        }


        private void RepairForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Repair". При необходимости она может быть перемещена или удалена.
            this.repairTableAdapter.Fill(this.bD_KRDataSet.Repair);

        }
    }
}
