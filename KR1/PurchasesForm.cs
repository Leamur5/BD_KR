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
    public partial class PurchasesForm : Form
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
                //id = -1;
                efficiency = false;
                provider = -1;
                deliveryDate = new DateTime(0001, 01, 01);
                guaranteePeriod = -1;
                purchaseAmount = -1;
            }
        }
        public PurchasesForm(int accessoriesId)
        {
            InitializeComponent();
            PurchasesModel.id = accessoriesId;
            formLabel.Text += " " + accessoriesId;
            
            PurchasesModel.reset();
            
        }

        private void updateDGVDataSource()
        {
            string query = "SELECT Purchases.ID,Purchases.Efficiency, Purchases.Provider, Purchases.DeliveryDate,Purchases.GuaranteePeriod,Purchases.PurchaseAmount " +
                "FROM(Accessories INNER JOIN Purchases ON Accessories.Purchase_ID = Purchases.ID) " +
                "WHERE(Purchases.ID = " + PurchasesModel.id.ToString() + ")";
            purchaseDataGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            purchaseDataGridView.Update();
        }
        public void updateView()
        {
            purchasesTableAdapter.Fill(bD_KRDataSet.Purchases);
            purchasesBindingSource.ResetBindings(false);
            updateDGVDataSource();
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
        
        
        public bool isIncorrectModel()
        {
            return PurchasesModel.id < 0 || PurchasesModel.purchaseAmount < 0 ||
                PurchasesModel.provider < 0 || PurchasesModel.guaranteePeriod < 0;
        }
        
        private void purchaseDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PurchasesModel.id = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            PurchasesModel.efficiency = Convert.ToBoolean(purchaseDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
            PurchasesModel.provider = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            PurchasesModel.deliveryDate = Convert.ToDateTime(purchaseDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            PurchasesModel.guaranteePeriod = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            PurchasesModel.purchaseAmount = Convert.ToInt32(purchaseDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());

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

        private void PurchasesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter.Fill(this.bD_KRDataSet.Purchases);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter.Fill(this.bD_KRDataSet.Purchases);
            updateDGVDataSource();
        }
    }
}
