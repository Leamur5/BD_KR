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
    public partial class AccessoriesForm : Form, ICRUDForm
    {
        private static class AccessoriesModel
        {
            public static int id { get; set; }
            public static string view { get; set; }
            public static int cost { get; set; } 
            public static int purchase { get; set; }
            public static void reset()
            {
                id = -1;
                view = "";
                cost = -1;
                purchase = -1;
            }
        }
        public AccessoriesForm()
        {
            InitializeComponent();

            /*List<int> purchases = purchasesTableAdapter1.GetData().Where(emp => emp.Efficiency == true).Select(w => w.ID).ToList<int>();
            foreach (int purchase in purchases)
            {
                purchaseComboBox.Items.Add(purchase);
            }*/
            purchaseComboBox.Update();

            AccessoriesModel.reset();
            clearInputs();
        }

        public void updateView()
        {
            accessoriesTableAdapter2.Fill(bD_KRDataSet2.Accessories);
            accessoriesBindingSource.ResetBindings(false);
            AccessoriesDataGridView.Update();
        }

        public void insertRow()
        {
            accessoriesTableAdapter2.Insert(ViewTextBox.Text, Convert.ToInt32(costNumericUpDown.Value),
                purchasesTableAdapter2.GetData().First(u => u.ID == Convert.ToInt32(purchaseComboBox.Text)).ID);
        }
        public void deleteRow()
        {
            accessoriesTableAdapter2.Delete(AccessoriesModel.id, AccessoriesModel.view, AccessoriesModel.cost, AccessoriesModel.purchase);
        }
        public void updateRow()
        {
            accessoriesTableAdapter2.Update(bD_KRDataSet1);
        }
        public void updateInputs()
        {
            ViewTextBox.Text = AccessoriesModel.view;
            costNumericUpDown.Value = AccessoriesModel.cost;
            purchaseComboBox.SelectedIndex = purchaseComboBox.FindString(Convert.ToString(purchasesTableAdapter2.GetData().FirstOrDefault(u => u.ID == AccessoriesModel.purchase).ID));

            string query = "SELECT Purchases.ID,Purchases.Provider, Purchases.DeliveryDate,Purchases.GuaranteePeriod,Purchases.PurchaseAmount " +
                "FROM(Accessories INNER JOIN Purchases ON Accessories.Purchase_ID = Purchases.ID) " +
                "WHERE(Accessories.ID = " + AccessoriesModel.id.ToString() + ")";
            PurchaseDataGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            changePurchaseButton.Enabled = true;
            
        }

        public void clearInputs()
        {
            ViewTextBox.Text = "";
            costNumericUpDown.Value = 0;
            purchaseComboBox.SelectedIndex = -1;
            changePurchaseButton.Enabled = false;
            
            for (int i = 0; i < AccessoriesDataGridView.Rows.Count; i++)
            {
                AccessoriesDataGridView.Rows[i].Selected = false;
            }
            AccessoriesDataGridView.Update();
        }

        public bool isIncorrectModel()
        {
            return AccessoriesModel.id < 0 || AccessoriesModel.view.Length == 0 ||
                AccessoriesModel.cost < 0 || AccessoriesModel.purchase < 0;
        }

        public bool isIncorrectInputs()
        {
            return ViewTextBox.Text.Trim().Length == 0 || costNumericUpDown.Value < 0 ||
                purchaseComboBox.SelectedIndex < 0;
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
                AccessoriesModel.reset();
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
                AccessoriesModel.reset();
                clearInputs();
            }
        }

        private void AccessoriesDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            AccessoriesModel.id = Convert.ToInt32(AccessoriesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            AccessoriesModel.view = AccessoriesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            AccessoriesModel.cost = Convert.ToInt32(AccessoriesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            AccessoriesModel.purchase = Convert.ToInt32(AccessoriesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

            updateInputs();
        }

        private void AccessoriesForm_Click(object sender, EventArgs e)
        {
            AccessoriesModel.reset();
            clearInputs();
        }
        private void changePurchaseButton_Click(object sender, EventArgs e)
        {
            PurchasesForm f = new PurchasesForm(AccessoriesModel.id);
            Hide();
            f.ShowDialog(this);
            Show();
            updateView();
            updateInputs();
        }

        private void AccessoriesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet2.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter2.Fill(this.bD_KRDataSet2.Purchases);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet2.Accessories". При необходимости она может быть перемещена или удалена.
            this.accessoriesTableAdapter2.Fill(this.bD_KRDataSet2.Accessories);
            
        }

        private void AccessoriesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
