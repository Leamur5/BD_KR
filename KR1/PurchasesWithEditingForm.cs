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
    public partial class PurchasesWithEditingForm : Form, ICRUDForm
    {
        
        private static class PurchasesModel
        {
            public static int id { get; set; }
            public static bool efficiency { get; set; }
            public static int provider { get; set; }
            public static DateTime deliveryDate { get; set; }
            public static int guaranteePeriod { get; set; }
            public static int purchaseAmount { get; set; }
            public static void reset()
            {
                id = -1;
                efficiency = false;
                provider = -1;
                deliveryDate = new DateTime(0001, 01, 01);
                guaranteePeriod = -1;
                purchaseAmount = -1;
            }
        }

        public PurchasesWithEditingForm()
        {
            InitializeComponent();
            PurchasesModel.reset();
            clearInputs();
        }
        
        public void updateView()
        {
            purchasesTableAdapter.Fill(bD_KRDataSet.Purchases);
            purchasesBindingSource.ResetBindings(false);
            purchaseDataGridView.Update();
        }
        public void insertRow()
        {
            purchasesTableAdapter.Insert(Efficiency.Checked,
                providerTableAdapter.GetData().First(u => u.ProviderName == providerComboBox.Text).ID,
                deliveryDateTimePicker.Value, Convert.ToInt32(guaranteeTextBox.Text),
                Convert.ToInt32(costNumericUpDown.Value));
        }
        public void deleteRow()
        {
            purchasesTableAdapter.Delete(PurchasesModel.id, PurchasesModel.efficiency,
                PurchasesModel.provider, PurchasesModel.deliveryDate, PurchasesModel.guaranteePeriod,
                PurchasesModel.purchaseAmount);
        }
        public void updateRow()
        {
            purchasesTableAdapter.Update(bD_KRDataSet);
        }

        public void updateInputs()
        {
            Efficiency.Checked = PurchasesModel.efficiency;
            providerComboBox.SelectedIndex = providerComboBox.FindString(Convert.ToString(providerTableAdapter.GetData().FirstOrDefault(u => u.ID == PurchasesModel.provider).ProviderName));
            deliveryDateTimePicker.Value = PurchasesModel.deliveryDate;
            guaranteeTextBox.Text = Convert.ToString(PurchasesModel.guaranteePeriod);
            costNumericUpDown.Value = PurchasesModel.purchaseAmount;

        }
        public void clearInputs()
        {
            Efficiency.Checked = false;
            providerComboBox.SelectedIndex = -1;
            guaranteeTextBox.Text = "";
            costNumericUpDown.Value = 0;

        }
        public bool isIncorrectModel()
        {
            return PurchasesModel.id < 0 || PurchasesModel.purchaseAmount < 0 ||
                PurchasesModel.provider < 0 || PurchasesModel.guaranteePeriod < 0;
        }

        public bool isIncorrectInputs()
        {
            return providerComboBox.SelectedIndex < 0 || guaranteeTextBox.Text.Trim().Length == 0 ||
                costNumericUpDown.Value < 0;
        }

        private void purchaseDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PurchasesModel.id = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            PurchasesModel.efficiency = Convert.ToBoolean(purchaseDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            PurchasesModel.provider = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            PurchasesModel.deliveryDate = Convert.ToDateTime(purchaseDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            PurchasesModel.guaranteePeriod = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            PurchasesModel.purchaseAmount = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());
            updateInputs();
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectModel())
            {
                MessageBox.Show("Выберите строку и введите новые значения");
            }
            else
            {
                updateRow();
                updateView();
                PurchasesModel.reset();

            }
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (isIncorrectModel())
            {
                MessageBox.Show("Выберите строку");
            }
            else
            {
                deleteRow();
                updateView();
                PurchasesModel.reset();

            }
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
        private void PurchasesForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            PurchasesModel.reset();
        }
        private void PurchasesWithEditingForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.bD_KRDataSet.Provider);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter.Fill(this.bD_KRDataSet.Purchases);

        }
    }
}
