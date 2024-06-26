
namespace CarRentalApp {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FirstName = new System.Windows.Forms.TextBox();
            this.textBox_LastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datePicker_PickupDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.datePicker_DropOffDate = new System.Windows.Forms.DateTimePicker();
            this.dropDown_Vehicles = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_Submit = new System.Windows.Forms.Button();
            this.dropDown_PickupTime = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dropDown_DropOffTime = new System.Windows.Forms.ComboBox();
            this.errorText_FirstName = new System.Windows.Forms.Label();
            this.errorText_LastName = new System.Windows.Forms.Label();
            this.errorText_PickupDate = new System.Windows.Forms.Label();
            this.errorText_PickUpTime = new System.Windows.Forms.Label();
            this.errorText_DropOffTime = new System.Windows.Forms.Label();
            this.errorText_VehicleType = new System.Windows.Forms.Label();
            this.errorText_DropOffDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(316, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rental Vehicle Entry Form";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox_FirstName
            // 
            this.textBox_FirstName.Location = new System.Drawing.Point(16, 122);
            this.textBox_FirstName.Name = "textBox_FirstName";
            this.textBox_FirstName.Size = new System.Drawing.Size(156, 20);
            this.textBox_FirstName.TabIndex = 2;
            // 
            // textBox_LastName
            // 
            this.textBox_LastName.Location = new System.Drawing.Point(182, 122);
            this.textBox_LastName.Name = "textBox_LastName";
            this.textBox_LastName.Size = new System.Drawing.Size(162, 20);
            this.textBox_LastName.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(178, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Last Name";
            // 
            // datePicker_PickupDate
            // 
            this.datePicker_PickupDate.Location = new System.Drawing.Point(16, 187);
            this.datePicker_PickupDate.Name = "datePicker_PickupDate";
            this.datePicker_PickupDate.Size = new System.Drawing.Size(200, 20);
            this.datePicker_PickupDate.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Pickup Date ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Drop Off Date / Time";
            // 
            // datePicker_DropOffDate
            // 
            this.datePicker_DropOffDate.Location = new System.Drawing.Point(17, 260);
            this.datePicker_DropOffDate.Name = "datePicker_DropOffDate";
            this.datePicker_DropOffDate.Size = new System.Drawing.Size(200, 20);
            this.datePicker_DropOffDate.TabIndex = 7;
            // 
            // dropDown_Vehicles
            // 
            this.dropDown_Vehicles.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown_Vehicles.FormattingEnabled = true;
            this.dropDown_Vehicles.Items.AddRange(new object[] {
            "Buick Encore GX XT",
            "Ford Edge",
            "Hyundai Sonata",
            "Nissan Altima",
            "Toyota Corolla"});
            this.dropDown_Vehicles.Location = new System.Drawing.Point(17, 327);
            this.dropDown_Vehicles.Name = "dropDown_Vehicles";
            this.dropDown_Vehicles.Size = new System.Drawing.Size(199, 21);
            this.dropDown_Vehicles.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Vehicle Make/Model";
            // 
            // button_Submit
            // 
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.Location = new System.Drawing.Point(17, 393);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(131, 36);
            this.button_Submit.TabIndex = 11;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = true;
            this.button_Submit.Click += new System.EventHandler(this.button_Submit_Click);
            // 
            // dropDown_PickupTime
            // 
            this.dropDown_PickupTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown_PickupTime.FormattingEnabled = true;
            this.dropDown_PickupTime.Items.AddRange(new object[] {
            "  7:00 AM",
            "  7:30 AM",
            "  8:00 AM",
            "  8:30 AM",
            "  9:00 AM",
            "  9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            ""});
            this.dropDown_PickupTime.Location = new System.Drawing.Point(240, 185);
            this.dropDown_PickupTime.Name = "dropDown_PickupTime";
            this.dropDown_PickupTime.Size = new System.Drawing.Size(121, 21);
            this.dropDown_PickupTime.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(236, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Pickup Time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(236, 237);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(118, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Drop off Time";
            // 
            // dropDown_DropOffTime
            // 
            this.dropDown_DropOffTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropDown_DropOffTime.FormattingEnabled = true;
            this.dropDown_DropOffTime.Items.AddRange(new object[] {
            "  7:00 AM",
            "  7:30 AM",
            "  8:00 AM",
            "  8:30 AM",
            "  9:00 AM",
            "  9:30 AM",
            "10:00 AM",
            "10:30 AM",
            "11:00 AM",
            "11:30 AM",
            "12:00 PM",
            ""});
            this.dropDown_DropOffTime.Location = new System.Drawing.Point(240, 258);
            this.dropDown_DropOffTime.Name = "dropDown_DropOffTime";
            this.dropDown_DropOffTime.Size = new System.Drawing.Size(121, 21);
            this.dropDown_DropOffTime.TabIndex = 14;
            // 
            // errorText_FirstName
            // 
            this.errorText_FirstName.AutoSize = true;
            this.errorText_FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText_FirstName.ForeColor = System.Drawing.Color.Red;
            this.errorText_FirstName.Location = new System.Drawing.Point(14, 145);
            this.errorText_FirstName.Name = "errorText_FirstName";
            this.errorText_FirstName.Size = new System.Drawing.Size(38, 13);
            this.errorText_FirstName.TabIndex = 16;
            this.errorText_FirstName.Text = "Label";
            this.errorText_FirstName.Click += new System.EventHandler(this.errorText_FirstName_Click);
            // 
            // errorText_LastName
            // 
            this.errorText_LastName.AutoSize = true;
            this.errorText_LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText_LastName.ForeColor = System.Drawing.Color.Red;
            this.errorText_LastName.Location = new System.Drawing.Point(179, 145);
            this.errorText_LastName.Name = "errorText_LastName";
            this.errorText_LastName.Size = new System.Drawing.Size(38, 13);
            this.errorText_LastName.TabIndex = 17;
            this.errorText_LastName.Text = "Label";
            // 
            // errorText_PickupDate
            // 
            this.errorText_PickupDate.AutoSize = true;
            this.errorText_PickupDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText_PickupDate.ForeColor = System.Drawing.Color.Red;
            this.errorText_PickupDate.Location = new System.Drawing.Point(14, 212);
            this.errorText_PickupDate.Name = "errorText_PickupDate";
            this.errorText_PickupDate.Size = new System.Drawing.Size(149, 13);
            this.errorText_PickupDate.TabIndex = 18;
            this.errorText_PickupDate.Text = "Please enter a valid date";
            // 
            // errorText_PickUpTime
            // 
            this.errorText_PickUpTime.AutoSize = true;
            this.errorText_PickUpTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText_PickUpTime.ForeColor = System.Drawing.Color.Red;
            this.errorText_PickUpTime.Location = new System.Drawing.Point(239, 210);
            this.errorText_PickUpTime.Name = "errorText_PickUpTime";
            this.errorText_PickUpTime.Size = new System.Drawing.Size(38, 13);
            this.errorText_PickUpTime.TabIndex = 19;
            this.errorText_PickUpTime.Text = "Label";
            // 
            // errorText_DropOffTime
            // 
            this.errorText_DropOffTime.AutoSize = true;
            this.errorText_DropOffTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText_DropOffTime.ForeColor = System.Drawing.Color.Red;
            this.errorText_DropOffTime.Location = new System.Drawing.Point(239, 282);
            this.errorText_DropOffTime.Name = "errorText_DropOffTime";
            this.errorText_DropOffTime.Size = new System.Drawing.Size(38, 13);
            this.errorText_DropOffTime.TabIndex = 20;
            this.errorText_DropOffTime.Text = "Label";
            // 
            // errorText_VehicleType
            // 
            this.errorText_VehicleType.AutoSize = true;
            this.errorText_VehicleType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText_VehicleType.ForeColor = System.Drawing.Color.Red;
            this.errorText_VehicleType.Location = new System.Drawing.Point(17, 351);
            this.errorText_VehicleType.Name = "errorText_VehicleType";
            this.errorText_VehicleType.Size = new System.Drawing.Size(38, 13);
            this.errorText_VehicleType.TabIndex = 21;
            this.errorText_VehicleType.Text = "Label";
            // 
            // errorText_DropOffDate
            // 
            this.errorText_DropOffDate.AutoSize = true;
            this.errorText_DropOffDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorText_DropOffDate.ForeColor = System.Drawing.Color.Red;
            this.errorText_DropOffDate.Location = new System.Drawing.Point(16, 284);
            this.errorText_DropOffDate.Name = "errorText_DropOffDate";
            this.errorText_DropOffDate.Size = new System.Drawing.Size(149, 13);
            this.errorText_DropOffDate.TabIndex = 22;
            this.errorText_DropOffDate.Text = "Please enter a valid date";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.errorText_DropOffDate);
            this.Controls.Add(this.errorText_VehicleType);
            this.Controls.Add(this.errorText_DropOffTime);
            this.Controls.Add(this.errorText_PickUpTime);
            this.Controls.Add(this.errorText_PickupDate);
            this.Controls.Add(this.errorText_LastName);
            this.Controls.Add(this.errorText_FirstName);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dropDown_DropOffTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dropDown_PickupTime);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dropDown_Vehicles);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.datePicker_DropOffDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.datePicker_PickupDate);
            this.Controls.Add(this.textBox_LastName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_FirstName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FirstName;
        private System.Windows.Forms.TextBox textBox_LastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker datePicker_PickupDate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker datePicker_DropOffDate;
        private System.Windows.Forms.ComboBox dropDown_Vehicles;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.ComboBox dropDown_PickupTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox dropDown_DropOffTime;
        private System.Windows.Forms.Label errorText_FirstName;
        private System.Windows.Forms.Label errorText_LastName;
        private System.Windows.Forms.Label errorText_PickupDate;
        private System.Windows.Forms.Label errorText_PickUpTime;
        private System.Windows.Forms.Label errorText_DropOffTime;
        private System.Windows.Forms.Label errorText_VehicleType;
        private System.Windows.Forms.Label errorText_DropOffDate;
    }
}

