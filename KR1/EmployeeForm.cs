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
    public partial class EmployeeForm : Form, ICRUDForm
    {
        private static class PositionModel
        {
            public static int id { get; set; }
            public static string surname { get; set; }
            public static string name { get; set; }
            public static string patronymic { get; set; }
            public static bool networkAccess { get; set; }
            public static void reset()
            {
                id = -1;
                surname = "";
                name = "";
                patronymic = "";
                networkAccess = false;
            }
        }
        public EmployeeForm()
        {
            InitializeComponent();
            clearInputs();
            PositionModel.reset();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.bD_KRDataSet.Employee);

        }

        public void updateView()
        {
            employeeTableAdapter.Fill(bD_KRDataSet.Employee);
            employeeBindingSource.ResetBindings(false);
            employeeDataGridView.Update();
        }
        public void insertRow()
        {
            employeeTableAdapter.Insert(SurnameTextBox.Text, NameTextBox.Text, PatronymicTextBox.Text, NetworkAccess.Checked);
        }

        public void deleteRow()
        {
            employeeTableAdapter.Delete(PositionModel.id, PositionModel.surname, PositionModel.name, PositionModel.patronymic, PositionModel.networkAccess);
        }
        public void updateRow()
        {
            employeeTableAdapter.Update(SurnameTextBox.Text, NameTextBox.Text, PatronymicTextBox.Text, NetworkAccess.Checked,
                PositionModel.id, PositionModel.surname, PositionModel.name, PositionModel.patronymic, PositionModel.networkAccess);
        }
        public void updateInputs()
        {
            SurnameTextBox.Text = PositionModel.surname;
            NameTextBox.Text = PositionModel.name;
            PatronymicTextBox.Text = PositionModel.patronymic;
            NetworkAccess.Checked = PositionModel.networkAccess;
        }
        public void clearInputs()
        {
            SurnameTextBox.Text = "";
            NameTextBox.Text = "";
            PatronymicTextBox.Text = "";
            NetworkAccess.Checked = false;
        }
        public bool isIncorrectModel()
        {
            return PositionModel.id < 0 || PositionModel.surname == "" || PositionModel.name == "" || PositionModel.patronymic == "";
        }
        public bool isIncorrectInputs()
        {
            return SurnameTextBox.Text == "" || NameTextBox.Text == ""
                || PatronymicTextBox.Text == "";
        }
        private void employeeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PositionModel.id = Convert.ToInt32(employeeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            PositionModel.surname = employeeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            PositionModel.name = employeeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            PositionModel.patronymic = employeeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            PositionModel.networkAccess = Convert.ToBoolean(employeeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            
            updateInputs();
        }

        private void EmployeeForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            PositionModel.reset();
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
                PositionModel.reset();
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
                PositionModel.reset();
                clearInputs();
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
