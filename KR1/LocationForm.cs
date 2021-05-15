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
    public partial class LocationForm : Form, ICRUDForm
    {
        private static class LocationModel
        {
            public static int id { get; set; }
            public static string city { get; set; }
            public static string street { get; set; }
            public static int house { get; set; }
            public static int floor { get; set; }
            public static int cabinet { get; set; }
            public static void reset()
            {
                id = -1;
                city = "";
                street = "";
                house = -1;
                floor = -1;
                cabinet = -1;
            }
        }
        public LocationForm()
        {
            InitializeComponent();
            clearInputs();
            LocationModel.reset();
        }
        public void updateView()
        {
            locationTableAdapter.Fill(bD_KRDataSet.Location);
            locationBindingSource.ResetBindings(false);
            locationDataGridView.Update();
        }
        public void insertRow()
        {
            locationTableAdapter.Insert(cityTextBox.Text, streetTextBox.Text, Convert.ToInt32(houseTextBox.Text),
                Convert.ToInt32(floorTextBox.Text), Convert.ToInt32(cabinetTextBox.Text));
        }
        public void deleteRow()
        {
            locationTableAdapter.Delete(LocationModel.id, LocationModel.city,
                LocationModel.street, LocationModel.house, LocationModel.floor, LocationModel.cabinet);
        }
        public void updateRow()
        {
            locationTableAdapter.Update(bD_KRDataSet);
        }
        public void updateInputs()
        {
            cityTextBox.Text = LocationModel.city;
            streetTextBox.Text = LocationModel.street;
            houseTextBox.Text = Convert.ToString(LocationModel.house);
            floorTextBox.Text = Convert.ToString(LocationModel.floor);
            cabinetTextBox.Text = Convert.ToString(LocationModel.cabinet);
        }
        public void clearInputs()
        {
            cityTextBox.Text = "";
            streetTextBox.Text = "";
            houseTextBox.Text = "";
            floorTextBox.Text = "";
            cabinetTextBox.Text = "";
        }
        public bool isIncorrectModel()
        {
            return LocationModel.id < 0 || LocationModel.city == "" ||
                LocationModel.street == "" || LocationModel.house < 0 ||
                LocationModel.floor < 0 || LocationModel.cabinet < 0;
        }
        public bool isIncorrectInputs()
        {
            return cityTextBox.Text == "" || streetTextBox.Text == ""
                || houseTextBox.Text == "" || floorTextBox.Text == "" || cabinetTextBox.Text == "";
        }
        private void locationDataGridView_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            LocationModel.id = Convert.ToInt32(locationDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            LocationModel.city = locationDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            LocationModel.street = locationDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            LocationModel.house = Convert.ToInt32(locationDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString());
            LocationModel.floor = Convert.ToInt32(locationDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString());
            LocationModel.cabinet = Convert.ToInt32(locationDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString());

            updateInputs();
        }
        private void LocationForm_Click(object sender, EventArgs e)
        {
            clearInputs();
            LocationModel.reset();
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
                LocationModel.reset();
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
                LocationModel.reset();
                clearInputs();
            }
        }
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LocationForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bD_KRDataSet.Location". При необходимости она может быть перемещена или удалена.
            this.locationTableAdapter.Fill(this.bD_KRDataSet.Location);

        }
    }
}
