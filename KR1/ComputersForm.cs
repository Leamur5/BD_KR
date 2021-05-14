﻿using System;
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
    public partial class ComputersForm : Form, ICRUDForm
    {
        private static class ComputersModel
        {
            public static int id { get; set; }
            public static int location { get; set; }
            public static string OS { get; set; }
            public static int cost { get; set; }
            public static int lifeTime { get; set; }
            public static int maxLifeTime { get; set; }
            public static int user { get; set; }
            public static int network { get; set; }
            public static int accessories { get; set; }
            public static int purchase { get; set; }
            public static int repair { get; set; }
            public static void reset()
            {
                id = -1;
                location = -1;
                OS = "";
                cost = -1;
                lifeTime = -1;
                maxLifeTime = -1;
                user = -1;
                network = -1;
                accessories = -1;
                purchase = -1;
                repair = -1;
            }
        }
        public ComputersForm()
        {
            InitializeComponent();
           
            ComputersModel.reset();
            clearInputs();
        }
        public void updateView()
        {
            computerTableAdapter.Fill(bD_KRDataSet.Computer);
            computerBindingSource.ResetBindings(false);
            computerDataGridView.Update();
        }
        public void insertRow()
        {
            computerTableAdapter.Insert(locationTableAdapter.GetData().First(u => Convert.ToString(u.ID) == locationComboBox.Text).ID,
                OSTextBox.Text, Convert.ToInt32(costNumericUpDown.Value),
                Convert.ToInt32(lifeTimeTextBox.Text), Convert.ToInt32(maxLifeTimeTextBox.Text), 
                employeeTableAdapter.GetData().First(u => u.Surname == userComboBox.Text).ID,
                networkTableAdapter.GetData().First(u => u.ID == Convert.ToInt32(networkComboBox.Text)).ID,
                accessoriesTableAdapter.GetData().First(u => u.View == accessoriesComboBox.Text).ID,
                purchasesTableAdapter.GetData().First(u => u.ID == Convert.ToInt32(purchaseComboBox.Text)).ID,
                repairTableAdapter.GetData().First(u => u.ID == Convert.ToInt32(repairComboBox.Text)).ID);
        }

        public void deleteRow()
        {
            computerTableAdapter.Delete(ComputersModel.id, ComputersModel.location, ComputersModel.OS, 
                ComputersModel.cost, ComputersModel.lifeTime, ComputersModel.maxLifeTime,
                ComputersModel.user, ComputersModel.network, ComputersModel.accessories,
                ComputersModel.purchase, ComputersModel.repair);
        }
        public void updateRow()
        {
            computerTableAdapter.Update(bD_KRDataSet);
        }
        public void updateInputs()
        {
            locationComboBox.SelectedIndex = locationComboBox.FindString(Convert.ToString(locationTableAdapter.GetData().FirstOrDefault(u => u.ID == ComputersModel.location).ID));
            OSTextBox.Text = ComputersModel.OS;
            costNumericUpDown.Value = ComputersModel.cost;
            lifeTimeTextBox.Text = Convert.ToString(ComputersModel.lifeTime);
            maxLifeTimeTextBox.Text = Convert.ToString(ComputersModel.maxLifeTime);
            userComboBox.SelectedIndex = userComboBox.FindString(employeeTableAdapter.GetData().FirstOrDefault(u => u.ID == ComputersModel.user).Surname);
            networkComboBox.SelectedIndex = networkComboBox.FindString(Convert.ToString(locationTableAdapter.GetData().FirstOrDefault(u => u.ID == ComputersModel.network).ID));
            accessoriesComboBox.SelectedIndex = accessoriesComboBox.FindString(accessoriesTableAdapter.GetData().FirstOrDefault(u => u.ID == ComputersModel.accessories).View);
            purchaseComboBox.SelectedIndex = purchaseComboBox.FindString(Convert.ToString(purchasesTableAdapter.GetData().FirstOrDefault(u => u.ID == ComputersModel.purchase).ID));
            repairComboBox.SelectedIndex = repairComboBox.FindString(Convert.ToString(repairTableAdapter.GetData().FirstOrDefault(u => u.ID == ComputersModel.repair).ID));

        }
        public void clearInputs()
        {
            locationComboBox.SelectedIndex = -1;
            OSTextBox.Text = "";
            costNumericUpDown.Value = 0;
            lifeTimeTextBox.Text = "";
            maxLifeTimeTextBox.Text = "";
            userComboBox.SelectedIndex = -1;
            networkComboBox.SelectedIndex = -1;
            accessoriesComboBox.SelectedIndex = -1;
            purchaseComboBox.SelectedIndex = -1;
            repairComboBox.SelectedIndex = -1;
        }
        public bool isIncorrectModel()
        {
            return ComputersModel.id < 0 || ComputersModel.location < 0 || ComputersModel.OS.Length == 0 ||
                ComputersModel.cost < 0 || ComputersModel.lifeTime < 0 || ComputersModel.maxLifeTime < 0 ||
                ComputersModel.user < 0 || ComputersModel.network < 0 || ComputersModel.accessories < 0 ||
                ComputersModel.purchase < 0 || ComputersModel.repair < 0;
        }
        public bool isIncorrectInputs()
        {
            return locationComboBox.SelectedIndex < 0 || OSTextBox.Text.Trim().Length == 0 ||
                costNumericUpDown.Value < 0 || lifeTimeTextBox.Text.Trim().Length == 0 ||
                maxLifeTimeTextBox.Text.Trim().Length == 0 || userComboBox.SelectedIndex < 0 ||
                networkComboBox.SelectedIndex < 0 || accessoriesComboBox.SelectedIndex < 0 || 
                purchaseComboBox.SelectedIndex < 0 || repairComboBox.SelectedIndex < 0;
        }

        private void mapPropsFromDGVToModel(int rowIndex)
        {
            ComputersModel.id = Convert.ToInt32(computerDataGridView.Rows[rowIndex].Cells[0].Value.ToString());
            ComputersModel.location = Convert.ToInt32(computerDataGridView.Rows[rowIndex].Cells[1].Value.ToString());
            ComputersModel.OS = computerDataGridView.Rows[rowIndex].Cells[2].Value.ToString();
            ComputersModel.cost = Convert.ToInt32(computerDataGridView.Rows[rowIndex].Cells[3].Value.ToString());
            ComputersModel.lifeTime = Convert.ToInt32(computerDataGridView.Rows[rowIndex].Cells[4].Value.ToString());
            ComputersModel.maxLifeTime = Convert.ToInt32(computerDataGridView.Rows[rowIndex].Cells[5].Value.ToString());
            ComputersModel.user = Convert.ToInt32(computerDataGridView.Rows[rowIndex].Cells[6].Value.ToString());
            ComputersModel.network = Convert.ToInt32(computerDataGridView.Rows[rowIndex].Cells[7].Value.ToString());
            ComputersModel.accessories = Convert.ToInt32(computerDataGridView.Rows[rowIndex].Cells[8].Value.ToString());
            ComputersModel.purchase = Convert.ToInt32(computerDataGridView.Rows[rowIndex].Cells[9].Value.ToString());
            ComputersModel.repair = Convert.ToInt32(computerDataGridView.Rows[rowIndex].Cells[10].Value.ToString());
        }

        private void computerDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mapPropsFromDGVToModel(e.RowIndex);
            updateInputs();
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
                ComputersModel.reset();
                clearInputs();
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
                ComputersModel.reset();
                clearInputs();
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void ComputersForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            ComputersModel.reset();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void ComputersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Repair". При необходимости она может быть перемещена или удалена.
            this.repairTableAdapter.Fill(this.bD_KRDataSet.Repair);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter.Fill(this.bD_KRDataSet.Purchases);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Accessories". При необходимости она может быть перемещена или удалена.
            this.accessoriesTableAdapter.Fill(this.bD_KRDataSet.Accessories);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Network". При необходимости она может быть перемещена или удалена.
            this.networkTableAdapter.Fill(this.bD_KRDataSet.Network);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.bD_KRDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Users". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Location". При необходимости она может быть перемещена или удалена.
            this.locationTableAdapter.Fill(this.bD_KRDataSet.Location);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Computer". При необходимости она может быть перемещена или удалена.
            this.computerTableAdapter.Fill(this.bD_KRDataSet.Computer);

        }
    }
}
