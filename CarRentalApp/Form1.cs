using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            //alternate method for declaring pickUpDate
            //Value returns mm/dd/yyyy format with the time stamp when date was selected
            //string pickUpDate = datePicker_PickupDate.Text;
            string firstName = textBox_FirstName.Text;
            string lastName = textBox_LastName.Text;
            string pickUpDate = datePicker_PickupDate.Value.ToString();
            string pickUpTime = dropDown_PickupTime.Text;
            string dropOffDate = datePicker_DropOffDate.Text;
            string dropOffTime = dropDown_DropOffTime.Text;
            //string vehicle = dropDown_Vehicles.Text;
            string vehicle = dropDown_Vehicles.SelectedItem.ToString();

            MessageBox.Show("Thank you " + firstName + ", your reservation details: \n" +
                "Reservation Name: " + firstName + " " + lastName + "\n" +
                "Pickup Date & Time: " + pickUpDate + " at" + pickUpTime +"\n" +
                "Drop off Date & Time: " + dropOffDate + " at" + dropOffTime +"\n" +
                "Vehicle Make/Model: " + vehicle);
        }
    }
}
