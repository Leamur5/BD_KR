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
        private static class EmployeeModel
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
            EmployeeModel.reset();
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
            employeeTableAdapter.Delete(EmployeeModel.id, EmployeeModel.surname, EmployeeModel.name, EmployeeModel.patronymic, EmployeeModel.networkAccess);
        }
        public void updateRow()
        {
            employeeTableAdapter.Update(bD_KRDataSet);
        }
        public void updateInputs()
        {
            SurnameTextBox.Text = EmployeeModel.surname;
            NameTextBox.Text = EmployeeModel.name;
            PatronymicTextBox.Text = EmployeeModel.patronymic;
            NetworkAccess.Checked = EmployeeModel.networkAccess;
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
            return EmployeeModel.id < 0 || EmployeeModel.surname == "" || EmployeeModel.name == "" || EmployeeModel.patronymic == "";
        }
        public bool isIncorrectInputs()
        {
            return SurnameTextBox.Text == "" || NameTextBox.Text == ""
                || PatronymicTextBox.Text == "";
        }
        private void employeeDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            EmployeeModel.id = Convert.ToInt32(employeeDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            EmployeeModel.surname = employeeDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            EmployeeModel.name = employeeDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            EmployeeModel.patronymic = employeeDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            EmployeeModel.networkAccess = Convert.ToBoolean(employeeDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            
            updateInputs();
        }

        private void EmployeeForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            EmployeeModel.reset();
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
                EmployeeModel.reset();
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
                EmployeeModel.reset();
                clearInputs();
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void mapPropsFromDGVToModel(int rowIndex)
        {
            EmployeeModel.id = Convert.ToInt32(employeeDataGridView.Rows[rowIndex].Cells[0].Value.ToString());
            EmployeeModel.surname = employeeDataGridView.Rows[rowIndex].Cells[1].Value.ToString();
            EmployeeModel.name = employeeDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            EmployeeModel.patronymic = employeeDataGridView.Rows[rowIndex].Cells[3].Value.ToString();
            EmployeeModel.networkAccess = Convert.ToBoolean(employeeDataGridView.Rows[rowIndex].Cells[4].Value.ToString());
        }
        

        private void searchTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (searchTextBox.Text.Trim().Length == 0 || e.KeyCode != Keys.Enter)
            {
                return;
            }
            var findedRow = employeeTableAdapter.GetData().FirstOrDefault(d => d.Surname.StartsWith(searchTextBox.Text));
            if (findedRow == null)
            {
                MessageBox.Show("Ничего не найдено");
                return;
            }
            int rowIndex = 0;
            for (int i = 0; i < employeeDataGridView.Rows.Count; i++)
            {
                employeeDataGridView.Rows[i].Selected = employeeDataGridView.Rows[i].Cells[1].Value.ToString() == findedRow.Surname ? true : false;
                if (employeeDataGridView.Rows[i].Selected)
                {
                    rowIndex = i;
                    break;
                }
            }
            mapPropsFromDGVToModel(rowIndex);
            updateInputs();
        }
    }
}
