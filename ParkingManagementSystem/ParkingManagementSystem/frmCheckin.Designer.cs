
namespace ParkingManagementSystem
{
    partial class frmCheckin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheckin));
            this.label3 = new System.Windows.Forms.Label();
            this.label_SlotName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Plate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button_checkIn = new System.Windows.Forms.Button();
            this.button_addCustomer = new System.Windows.Forms.Button();
            this.comboBox_Vehicle = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label3.Location = new System.Drawing.Point(12, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "Slot:";
            // 
            // label_SlotName
            // 
            this.label_SlotName.AutoSize = true;
            this.label_SlotName.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label_SlotName.Location = new System.Drawing.Point(195, 66);
            this.label_SlotName.Name = "label_SlotName";
            this.label_SlotName.Size = new System.Drawing.Size(94, 25);
            this.label_SlotName.TabIndex = 10;
            this.label_SlotName.Text = "SlotName";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label1.Location = new System.Drawing.Point(110, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Check In";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label2.Location = new System.Drawing.Point(12, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "NumberPlate";
            // 
            // textBox_Plate
            // 
            this.textBox_Plate.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox_Plate.Location = new System.Drawing.Point(193, 101);
            this.textBox_Plate.Name = "textBox_Plate";
            this.textBox_Plate.Size = new System.Drawing.Size(177, 32);
            this.textBox_Plate.TabIndex = 13;
            this.textBox_Plate.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox_Plate_MouseClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label4.Location = new System.Drawing.Point(12, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 25);
            this.label4.TabIndex = 14;
            this.label4.Text = "CustomerID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "(if any)";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.textBox2.Location = new System.Drawing.Point(193, 183);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(178, 32);
            this.textBox2.TabIndex = 16;
            this.textBox2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox2_MouseClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "VehicleType";
            // 
            // button_checkIn
            // 
            this.button_checkIn.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_checkIn.Location = new System.Drawing.Point(213, 262);
            this.button_checkIn.Name = "button_checkIn";
            this.button_checkIn.Size = new System.Drawing.Size(154, 44);
            this.button_checkIn.TabIndex = 19;
            this.button_checkIn.Text = "Check In";
            this.button_checkIn.UseVisualStyleBackColor = true;
            this.button_checkIn.Click += new System.EventHandler(this.button_checkIn_Click);
            // 
            // button_addCustomer
            // 
            this.button_addCustomer.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_addCustomer.Location = new System.Drawing.Point(58, 262);
            this.button_addCustomer.Name = "button_addCustomer";
            this.button_addCustomer.Size = new System.Drawing.Size(149, 44);
            this.button_addCustomer.TabIndex = 20;
            this.button_addCustomer.Text = "Add Customer";
            this.button_addCustomer.UseVisualStyleBackColor = true;
            this.button_addCustomer.Click += new System.EventHandler(this.button_addCustomer_Click);
            // 
            // comboBox_Vehicle
            // 
            this.comboBox_Vehicle.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.comboBox_Vehicle.FormattingEnabled = true;
            this.comboBox_Vehicle.Items.AddRange(new object[] {
            "Car",
            "Bike",
            "Van"});
            this.comboBox_Vehicle.Location = new System.Drawing.Point(193, 145);
            this.comboBox_Vehicle.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox_Vehicle.Name = "comboBox_Vehicle";
            this.comboBox_Vehicle.Size = new System.Drawing.Size(178, 33);
            this.comboBox_Vehicle.TabIndex = 21;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(366, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(197, 229);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "label7";
            // 
            // frmCheckin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 338);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.comboBox_Vehicle);
            this.Controls.Add(this.button_addCustomer);
            this.Controls.Add(this.button_checkIn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Plate);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label_SlotName);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frmCheckin";
            this.Text = "CheckIN";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_SlotName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Plate;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_checkIn;
        private System.Windows.Forms.Button button_addCustomer;
        private System.Windows.Forms.ComboBox comboBox_Vehicle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}