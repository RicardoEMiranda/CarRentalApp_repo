using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalApp {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            resetErrorMessages();
            
        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label2_Click(object sender, EventArgs e) {

        }

        private void button_Submit_Click(object sender, EventArgs e)
        {
            //alternate method for declaring pickUpDate
            //Value returns mm/dd/yyyy format with the time stamp when date was selected
            //string pickUpDate = datePicker_PickupDate.Value.ToString();
            string firstName = textBox_FirstName.Text;
            string lastName = textBox_LastName.Text;
            string pickUpDate = datePicker_PickupDate.Text;
            var pickUpDateVal = datePicker_PickupDate.Value;
            string pickUpTime = dropDown_PickupTime.Text;
            string dropOffDate = datePicker_DropOffDate.Text;
            var dropOffDateVal = datePicker_DropOffDate.Value;
            string dropOffTime = dropDown_DropOffTime.Text;
            //string vehicle = dropDown_Vehicles.Text;
            string vehicle = null;

            if(dropDown_Vehicles.SelectedItem != null)   {
                vehicle = dropDown_Vehicles.SelectedItem.ToString();
            }
            

            bool firstNameNotProvided = string.IsNullOrWhiteSpace(firstName);
            bool lastNameNotProvided = string.IsNullOrWhiteSpace(lastName);
            bool pickUpDateNotProvided = string.IsNullOrWhiteSpace(pickUpDate);
            bool dropOffDateNotProvided = string.IsNullOrWhiteSpace(dropOffDate);
            bool vehicleNotProvided = string.IsNullOrWhiteSpace(vehicle);
            bool timeInNotProvided = string.IsNullOrEmpty(pickUpTime);
            bool timeOutNotProvided = string.IsNullOrEmpty(dropOffTime);
            bool formIsValid = true;

            string errorText = " ";

            //Text Error Messages

            if (firstNameNotProvided)
            {
                formIsValid = false;
                errorText_FirstName.Text = "Please enter First Name";
            } else if (!firstNameNotProvided)
            {
                errorText_FirstName.Text = "";
            }

            if (lastNameNotProvided)
            {
                formIsValid = false;
                errorText_LastName.Text = "Please enter Last Name";
            } else if (!lastNameNotProvided)
            {
                errorText_LastName.Text = "";
            }

            if (pickUpDateVal.Date <= DateTime.UtcNow.Date)  {
                formIsValid = false;
                errorText_PickupDate.Text = "Please enter a valid date";
            } else if(pickUpDateVal.Date > DateTime.UtcNow.Date) {
                errorText_PickupDate.Text = "";
            }

            if (dropOffDateVal.Date <= DateTime.UtcNow.Date) {
                formIsValid = false;
                errorText_DropOffDate.Text = "Please enter a valid date";
            } else if (dropOffDateVal.Date > DateTime.UtcNow.Date)  {
                errorText_DropOffDate.Text = "";
            }

            if (timeInNotProvided) {
                formIsValid = false;
                errorText_PickUpTime.Text = "Please select a pickup time";
            } else if (!timeInNotProvided)  {
                errorText_PickUpTime.Text = "";
            }

            if(timeOutNotProvided)  {
                formIsValid = false;
                errorText_DropOffTime.Text = "Please select a pickup time";
            } else if (!timeOutNotProvided)  {
                errorText_DropOffTime.Text = "";
            }

            if(vehicleNotProvided)  {
                formIsValid = false;
                errorText_VehicleType.Text = "Please select a vehicle";
            } else if(!vehicleNotProvided)  {
                errorText_VehicleType.Text = "";
            }


            //Message Boxes
            if (firstNameNotProvided || lastNameNotProvided || pickUpDateNotProvided || 
                dropOffDateNotProvided || vehicleNotProvided || timeInNotProvided || timeOutNotProvided)  {
                MessageBox.Show("Please fill out all the required information");
                formIsValid = false;
            } 

            if(pickUpDateVal <= DateTime.UtcNow.Date || dropOffDateVal <= DateTime.UtcNow.Date)  {
                MessageBox.Show("Pickup date and drop off dates must be after today's date");
                formIsValid = false;

            } 

            if(pickUpDateVal > dropOffDateVal)  {
                MessageBox.Show("Please select a Pickup date that is before the drop off date");
                formIsValid = false;
            }

            if(formIsValid)  {
                resetErrorMessages();

                MessageBox.Show("Thank you " + firstName + ", your reservation details: \n" +
                "Reservation Name: " + firstName + " " + lastName + "\n" +
                "Pickup Date & Time: " + pickUpDate + " at" + pickUpTime + "\n" +
                "Drop off Date & Time: " + dropOffDate + " at" + dropOffTime + "\n" +
                "Vehicle Make/Model: " + vehicle);
                
            }
            

      
        }

        private void errorText_FirstName_Click(object sender, EventArgs e)
        {

        }

        private void resetErrorMessages() {
            errorText_FirstName.Text = "";
            errorText_LastName.Text = "";
            errorText_PickupDate.Text = "";
            errorText_DropOffDate.Text = "";
            errorText_PickUpTime.Text = "";
            errorText_DropOffTime.Text = "";
            errorText_VehicleType.Text = "";
        }
    }
}
