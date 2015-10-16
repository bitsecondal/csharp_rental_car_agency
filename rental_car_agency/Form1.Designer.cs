namespace rental_car_agency
{
    partial class Form1
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
            System.Windows.Forms.Button button_calculate;
            this.textBox_cust_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_odo_begin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_days_rent = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_odo_end = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_clear = new System.Windows.Forms.Button();
            this.label_total_miles = new System.Windows.Forms.Label();
            this.label_total_customer = new System.Windows.Forms.Label();
            this.label_total_customer_all = new System.Windows.Forms.Label();
            button_calculate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_cust_name
            // 
            this.textBox_cust_name.Location = new System.Drawing.Point(12, 49);
            this.textBox_cust_name.Name = "textBox_cust_name";
            this.textBox_cust_name.Size = new System.Drawing.Size(100, 20);
            this.textBox_cust_name.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Beginning Odometer Reading ";
            // 
            // textBox_odo_begin
            // 
            this.textBox_odo_begin.Location = new System.Drawing.Point(12, 101);
            this.textBox_odo_begin.Name = "textBox_odo_begin";
            this.textBox_odo_begin.Size = new System.Drawing.Size(100, 20);
            this.textBox_odo_begin.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Days Rented";
            // 
            // textBox_days_rent
            // 
            this.textBox_days_rent.Location = new System.Drawing.Point(12, 209);
            this.textBox_days_rent.Name = "textBox_days_rent";
            this.textBox_days_rent.Size = new System.Drawing.Size(100, 20);
            this.textBox_days_rent.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ending Odometer Reading";
            // 
            // textBox_odo_end
            // 
            this.textBox_odo_end.Location = new System.Drawing.Point(12, 153);
            this.textBox_odo_end.Name = "textBox_odo_end";
            this.textBox_odo_end.Size = new System.Drawing.Size(100, 20);
            this.textBox_odo_end.TabIndex = 3;
            // 
            // button_calculate
            // 
            button_calculate.Location = new System.Drawing.Point(332, 49);
            button_calculate.Name = "button_calculate";
            button_calculate.Size = new System.Drawing.Size(75, 23);
            button_calculate.TabIndex = 5;
            button_calculate.Text = "Calculate";
            button_calculate.UseVisualStyleBackColor = true;
            button_calculate.Click += new System.EventHandler(this.button_calculate_Click);
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(332, 107);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(75, 23);
            this.button_exit.TabIndex = 7;
            this.button_exit.Text = "Exit";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_clear
            // 
            this.button_clear.Location = new System.Drawing.Point(332, 78);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(75, 23);
            this.button_clear.TabIndex = 6;
            this.button_clear.Text = "Clear";
            this.button_clear.UseVisualStyleBackColor = true;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // label_total_miles
            // 
            this.label_total_miles.AutoSize = true;
            this.label_total_miles.Location = new System.Drawing.Point(329, 173);
            this.label_total_miles.Name = "label_total_miles";
            this.label_total_miles.Size = new System.Drawing.Size(143, 13);
            this.label_total_miles.TabIndex = 11;
            this.label_total_miles.Text = "Total Miles, This Customer: 0";
            // 
            // label_total_customer
            // 
            this.label_total_customer.AutoSize = true;
            this.label_total_customer.Location = new System.Drawing.Point(329, 193);
            this.label_total_customer.Name = "label_total_customer";
            this.label_total_customer.Size = new System.Drawing.Size(168, 13);
            this.label_total_customer.TabIndex = 12;
            this.label_total_customer.Text = "Total Charge, This Customer: 0.00";
            // 
            // label_total_customer_all
            // 
            this.label_total_customer_all.AutoSize = true;
            this.label_total_customer_all.Location = new System.Drawing.Point(329, 212);
            this.label_total_customer_all.Name = "label_total_customer_all";
            this.label_total_customer_all.Size = new System.Drawing.Size(164, 13);
            this.label_total_customer_all.TabIndex = 13;
            this.label_total_customer_all.Text = "Total Charge, All Customers: 0.00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 445);
            this.Controls.Add(this.label_total_customer_all);
            this.Controls.Add(this.label_total_customer);
            this.Controls.Add(this.label_total_miles);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(button_calculate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_odo_end);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_days_rent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_odo_begin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_cust_name);
            this.Name = "Form1";
            this.Text = "Rental Agency";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_cust_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_odo_begin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_days_rent;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_odo_end;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.Label label_total_miles;
        private System.Windows.Forms.Label label_total_customer;
        private System.Windows.Forms.Label label_total_customer_all;
    }
}

