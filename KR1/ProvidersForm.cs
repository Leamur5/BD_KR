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
    public partial class ProvidersForm : Form, ICRUDForm
    {
        private static class ProvidersModel
        {
            public static int id { get; set; }
            public static string name { get; set; }
            public static string telephone { get; set; }
            public static int adress { get; set; }
            public static void reset()
            {
                id = -1;
                name = "";
                telephone = "";
                adress = -1;
                
            }
        }
        public ProvidersForm()
        {
            InitializeComponent();
            adressComboBox.Update();

            ProvidersModel.reset();
            clearInputs();
        }
        public void updateView()
        {
            providerTableAdapter.Fill(bD_KRDataSet.Provider);
            providerBindingSource.ResetBindings(false);
            providersDataGridView.Update();
        }
        public void insertRow()
        {
            providerTableAdapter.Insert(NameTextBox.Text, telephoneTextBox.Text,
                locationTableAdapter.GetData().First(u => u.ID == Convert.ToInt32(adressComboBox.Text)).ID);
        }
        public void deleteRow()
        {
            providerTableAdapter.Delete(ProvidersModel.id, ProvidersModel.name,
                ProvidersModel.telephone, ProvidersModel.adress);
        }
        public void updateRow()
        {
            providerTableAdapter.Update(bD_KRDataSet);
        }
        public void updateInputs()
        {
            NameTextBox.Text = ProvidersModel.name;
            telephoneTextBox.Text = ProvidersModel.telephone;
            adressComboBox.SelectedIndex = adressComboBox.FindString(Convert.ToString(locationTableAdapter.GetData().FirstOrDefault(u => u.ID == ProvidersModel.adress).ID));

            string query = "SELECT Purchases.ID,Purchases.Provider, Purchases.DeliveryDate,Purchases.GuaranteePeriod,Purchases.PurchaseAmount " +
                "FROM(Provider INNER JOIN Purchases ON Provider.ID = Purchases.Provider) " +
                "WHERE(Provider.ID = " + ProvidersModel.id.ToString() + ")";
            purchasesDataGridView.DataSource = DGVDataSourceChanger.getNewDGVDataSource(query);
            

        }
        public void clearInputs()
        {
            NameTextBox.Text = "";
            telephoneTextBox.Text = "";
            adressComboBox.SelectedIndex = -1;
            

            for (int i = 0; i < providersDataGridView.Rows.Count; i++)
            {
                providersDataGridView.Rows[i].Selected = false;
            }
            providersDataGridView.Update();
        }
        public bool isIncorrectModel()
        {
            return ProvidersModel.id < 0 || ProvidersModel.name.Length == 0 ||
                ProvidersModel.telephone.Length == 0 || ProvidersModel.adress < 0;
        }
        public bool isIncorrectInputs()
        {
            return NameTextBox.Text.Trim().Length == 0 || telephoneTextBox.Text.Trim().Length == 0 ||
                adressComboBox.SelectedIndex < 0;
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
                ProvidersModel.reset();
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
                ProvidersModel.reset();
                clearInputs();
            }
        }
        private void ProvidersDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            ProvidersModel.id = Convert.ToInt32(providersDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            ProvidersModel.name = providersDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            ProvidersModel.telephone = providersDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            ProvidersModel.adress = Convert.ToInt32(providersDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());

            updateInputs();
        }
        private void ProvidersForm_Click(object sender, EventArgs e)
        {
            ProvidersModel.reset();
            clearInputs();
        }


        private void ProvidersForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Location". При необходимости она может быть перемещена или удалена.
            this.locationTableAdapter.Fill(this.bD_KRDataSet.Location);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Provider". При необходимости она может быть перемещена или удалена.
            this.providerTableAdapter.Fill(this.bD_KRDataSet.Provider);

        }
    }
}
