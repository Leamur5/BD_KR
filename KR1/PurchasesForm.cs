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
    public partial class PurchasesForm : Form//, ICRUDForm
    {
        private static class PurchasesModel
        {
            public static int accessoryId { get; set; }
            public static int purchaseId { get; set; }
            public static void reset()
            {
                purchaseId = -1;
            }
        }
        public PurchasesForm(int accessoriesId)
        {
            InitializeComponent();
            PurchasesModel.accessoryId = accessoriesId;
            formLabel.Text += " " + accessoriesId;
        }

        private void updateDGVDataSource()
        {
            string query = "SELECT Purchases.ID,Purchases.Provider, Purchases.DeliveryDate,Purchases.GuaranteePeriod,Purchases.PurchaseAmount " +
                "FROM(Accessories INNER JOIN Purchases ON Accessories.Purchase_ID = Purchases.ID) " +
                "WHERE(Accessories.ID = " + PurchasesModel.accessoryId.ToString() + ")";
            purchaseDataGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            purchaseDataGridView.Update();
        }
        public void updateView()
        {
            purchasesTableAdapter.Fill(bD_KRDataSet.Purchases);
            purchasesBindingSource.ResetBindings(false);
            updateDGVDataSource();
        }
        public void insertRow()
        {
            purchasesTableAdapter.Insert(purchasesTableAdapter.GetData()
                .FirstOrDefault(d => Convert.ToString(d.ID) == purchasesComboBox.Text).Efficiency,
                purchasesTableAdapter.GetData()
                .FirstOrDefault(d => Convert.ToString(d.ID) == purchasesComboBox.Text).Provider,
                purchasesTableAdapter.GetData()
                .FirstOrDefault(d => Convert.ToString(d.ID) == purchasesComboBox.Text).DeliveryDate,
                purchasesTableAdapter.GetData()
                .FirstOrDefault(d => Convert.ToString(d.ID) == purchasesComboBox.Text).GuaranteePeriod,
                purchasesTableAdapter.GetData()
                .FirstOrDefault(d => Convert.ToString(d.ID) == purchasesComboBox.Text).PurchaseAmount);
        }
        /*public void deleteRow()
        {
            purchasesTableAdapter.Delete(PurchasesModel.accessoryId, PurchasesModel.purchaseId);
        }
        */
        private void PurchasesForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Purchases". При необходимости она может быть перемещена или удалена.
            this.purchasesTableAdapter.Fill(this.bD_KRDataSet.Purchases);

        }
    }
}
