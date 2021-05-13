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
    public partial class NetworkForm : Form, ICRUDForm
    {
        
        private static class PositionModel
        {
            public static int id { get; set; }
            public static string communicationType { get; set; }
            public static string topology { get; set; }
            public static bool internetAccess { get; set; }
            public static string IPAdress { get; set; }
            public static void reset()
            {
                id = -1;
                communicationType = "";
                topology = "";
                internetAccess = false;
                IPAdress = "";
                
            }
        }
        public NetworkForm()
        {
            InitializeComponent();
            clearInputs();
            PositionModel.reset();
        }

        private void NetworkForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet2.Network". При необходимости она может быть перемещена или удалена.
            this.networkTableAdapter2.Fill(this.bD_KRDataSet2.Network);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet1.Network". При необходимости она может быть перемещена или удалена.
            
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Network". При необходимости она может быть перемещена или удалена.
            

        }
        public void updateView()
        {
            networkTableAdapter2.Fill(bD_KRDataSet2.Network);
            networkBindingSource.ResetBindings(false);
            networkDataGridView.Update();
        }
        public void insertRow()
        {
            networkTableAdapter2.Insert(communicationTypeTextBox.Text, topologyTextBox.Text, InternetAccess.Checked, ipAdressTextBox.Text);
        }
        public void deleteRow()
        {
            networkTableAdapter2.Delete(PositionModel.id, PositionModel.communicationType, PositionModel.topology, PositionModel.internetAccess, PositionModel.IPAdress);
        }
        public void updateRow()
        {
            networkTableAdapter2.Update(bD_KRDataSet2);
        }
        public void updateInputs()
        {
            communicationTypeTextBox.Text = PositionModel.communicationType;
            topologyTextBox.Text = PositionModel.topology;
            InternetAccess.Checked = PositionModel.internetAccess;
            ipAdressTextBox.Text = PositionModel.IPAdress;
        }
        public void clearInputs()
        {
            communicationTypeTextBox.Text = "";
            topologyTextBox.Text = "";
            InternetAccess.Checked = false;
            ipAdressTextBox.Text = "";
        }

        public bool isIncorrectModel()
        {
            return PositionModel.id < 0 || PositionModel.topology == "" || PositionModel.communicationType == "" || PositionModel.IPAdress == "";
        }
        public bool isIncorrectInputs()
        {
            return communicationTypeTextBox.Text == "" || topologyTextBox.Text == ""
                || ipAdressTextBox.Text == "";
        }

        private void networkDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PositionModel.id = Convert.ToInt32(networkDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            PositionModel.communicationType = networkDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            PositionModel.topology = networkDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            PositionModel.internetAccess = Convert.ToBoolean(networkDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            PositionModel.IPAdress = networkDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            updateInputs();
        }

        private void NetworkForm_Click(object sender, EventArgs e)
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

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
