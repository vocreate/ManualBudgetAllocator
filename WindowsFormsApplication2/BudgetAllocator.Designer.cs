namespace WindowsFormsApplication2
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
            this.gaslabel = new System.Windows.Forms.Label();
            this.SubmitAll = new System.Windows.Forms.Button();
            this.InputGasExpense = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.CurrentGasFill = new System.Windows.Forms.Label();
            this.MaxGasExpense = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.InputMyCash = new System.Windows.Forms.TextBox();
            this.Food = new System.Windows.Forms.Label();
            this.InputFoodExpense = new System.Windows.Forms.TextBox();
            this.CurrentFoodFill = new System.Windows.Forms.Label();
            this.divider = new System.Windows.Forms.Label();
            this.MaxFoodExpense = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.MaxRentExpense = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.CurrentRentFill = new System.Windows.Forms.Label();
            this.InputRentExpense = new System.Windows.Forms.TextBox();
            this.rent = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MaxOtherExpense = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.CurrentOtherFill = new System.Windows.Forms.Label();
            this.InputOtherExpense = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gaslabel
            // 
            this.gaslabel.AutoSize = true;
            this.gaslabel.Location = new System.Drawing.Point(55, 95);
            this.gaslabel.Name = "gaslabel";
            this.gaslabel.Size = new System.Drawing.Size(34, 17);
            this.gaslabel.TabIndex = 0;
            this.gaslabel.Text = "Gas";
            // 
            // SubmitAll
            // 
            this.SubmitAll.Location = new System.Drawing.Point(183, 300);
            this.SubmitAll.Name = "SubmitAll";
            this.SubmitAll.Size = new System.Drawing.Size(82, 23);
            this.SubmitAll.TabIndex = 1;
            this.SubmitAll.Text = "Calculate!";
            this.SubmitAll.UseVisualStyleBackColor = true;
            this.SubmitAll.Click += new System.EventHandler(this.SubmitAll_Click);
            // 
            // InputGasExpense
            // 
            this.InputGasExpense.AcceptsTab = true;
            this.InputGasExpense.Location = new System.Drawing.Point(95, 90);
            this.InputGasExpense.Name = "InputGasExpense";
            this.InputGasExpense.Size = new System.Drawing.Size(67, 22);
            this.InputGasExpense.TabIndex = 2;
            this.InputGasExpense.Text = "0";
            this.InputGasExpense.TextChanged += new System.EventHandler(this.InputGasExpense_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(211, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(12, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "/";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // CurrentGasFill
            // 
            this.CurrentGasFill.AutoSize = true;
            this.CurrentGasFill.Location = new System.Drawing.Point(180, 90);
            this.CurrentGasFill.Name = "CurrentGasFill";
            this.CurrentGasFill.Size = new System.Drawing.Size(16, 17);
            this.CurrentGasFill.TabIndex = 4;
            this.CurrentGasFill.Text = "0";
            this.CurrentGasFill.Click += new System.EventHandler(this.CurrentGasFill_Click);
            // 
            // MaxGasExpense
            // 
            this.MaxGasExpense.Location = new System.Drawing.Point(238, 90);
            this.MaxGasExpense.Name = "MaxGasExpense";
            this.MaxGasExpense.Size = new System.Drawing.Size(58, 22);
            this.MaxGasExpense.TabIndex = 5;
            this.MaxGasExpense.Text = "25";
            this.MaxGasExpense.TextChanged += new System.EventHandler(this.MaxGasExpense_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Amount Left / Max Gas";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "My Cash";
            // 
            // InputMyCash
            // 
            this.InputMyCash.Location = new System.Drawing.Point(202, 46);
            this.InputMyCash.Name = "InputMyCash";
            this.InputMyCash.Size = new System.Drawing.Size(69, 22);
            this.InputMyCash.TabIndex = 8;
            this.InputMyCash.Text = "100";
            this.InputMyCash.TextChanged += new System.EventHandler(this.InputMyCash_TextChanged);
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.Location = new System.Drawing.Point(49, 139);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(40, 17);
            this.Food.TabIndex = 9;
            this.Food.Text = "Food";
            // 
            // InputFoodExpense
            // 
            this.InputFoodExpense.Location = new System.Drawing.Point(95, 136);
            this.InputFoodExpense.Name = "InputFoodExpense";
            this.InputFoodExpense.Size = new System.Drawing.Size(67, 22);
            this.InputFoodExpense.TabIndex = 10;
            this.InputFoodExpense.Text = "0";
            this.InputFoodExpense.TextChanged += new System.EventHandler(this.InputFoodExpense_TextChanged);
            // 
            // CurrentFoodFill
            // 
            this.CurrentFoodFill.AutoSize = true;
            this.CurrentFoodFill.Location = new System.Drawing.Point(180, 139);
            this.CurrentFoodFill.Name = "CurrentFoodFill";
            this.CurrentFoodFill.Size = new System.Drawing.Size(16, 17);
            this.CurrentFoodFill.TabIndex = 11;
            this.CurrentFoodFill.Text = "0";
            this.CurrentFoodFill.Click += new System.EventHandler(this.CurrentFoodFill_Click);
            // 
            // divider
            // 
            this.divider.AutoSize = true;
            this.divider.Location = new System.Drawing.Point(211, 141);
            this.divider.Name = "divider";
            this.divider.Size = new System.Drawing.Size(12, 17);
            this.divider.TabIndex = 12;
            this.divider.Text = "/";
            this.divider.Click += new System.EventHandler(this.divider_Click);
            // 
            // MaxFoodExpense
            // 
            this.MaxFoodExpense.Location = new System.Drawing.Point(238, 136);
            this.MaxFoodExpense.Name = "MaxFoodExpense";
            this.MaxFoodExpense.Size = new System.Drawing.Size(58, 22);
            this.MaxFoodExpense.TabIndex = 13;
            this.MaxFoodExpense.Text = "25";
            this.MaxFoodExpense.TextChanged += new System.EventHandler(this.MaxFoodExpense_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Amount Left / Max Food";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Amount Left / Max Rent";
            // 
            // MaxRentExpense
            // 
            this.MaxRentExpense.Location = new System.Drawing.Point(238, 185);
            this.MaxRentExpense.Name = "MaxRentExpense";
            this.MaxRentExpense.Size = new System.Drawing.Size(58, 22);
            this.MaxRentExpense.TabIndex = 19;
            this.MaxRentExpense.Text = "25";
            this.MaxRentExpense.TextChanged += new System.EventHandler(this.MaxRentExpense_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(12, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "/";
            // 
            // CurrentRentFill
            // 
            this.CurrentRentFill.AutoSize = true;
            this.CurrentRentFill.Location = new System.Drawing.Point(180, 188);
            this.CurrentRentFill.Name = "CurrentRentFill";
            this.CurrentRentFill.Size = new System.Drawing.Size(16, 17);
            this.CurrentRentFill.TabIndex = 17;
            this.CurrentRentFill.Text = "0";
            this.CurrentRentFill.Click += new System.EventHandler(this.CurrentRentFill_Click);
            // 
            // InputRentExpense
            // 
            this.InputRentExpense.Location = new System.Drawing.Point(95, 185);
            this.InputRentExpense.Name = "InputRentExpense";
            this.InputRentExpense.Size = new System.Drawing.Size(67, 22);
            this.InputRentExpense.TabIndex = 16;
            this.InputRentExpense.Text = "0";
            this.InputRentExpense.TextChanged += new System.EventHandler(this.InputRentExpense_TextChanged);
            // 
            // rent
            // 
            this.rent.AutoSize = true;
            this.rent.Location = new System.Drawing.Point(49, 188);
            this.rent.Name = "rent";
            this.rent.Size = new System.Drawing.Size(38, 17);
            this.rent.TabIndex = 15;
            this.rent.Text = "Rent";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 17);
            this.label7.TabIndex = 26;
            this.label7.Text = "Amount Left / Max Other";
            // 
            // MaxOtherExpense
            // 
            this.MaxOtherExpense.Location = new System.Drawing.Point(238, 229);
            this.MaxOtherExpense.Name = "MaxOtherExpense";
            this.MaxOtherExpense.Size = new System.Drawing.Size(58, 22);
            this.MaxOtherExpense.TabIndex = 25;
            this.MaxOtherExpense.Text = "25";
            this.MaxOtherExpense.TextChanged += new System.EventHandler(this.MaxOtherExpense_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(211, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "/";
            // 
            // CurrentOtherFill
            // 
            this.CurrentOtherFill.AutoSize = true;
            this.CurrentOtherFill.Location = new System.Drawing.Point(180, 232);
            this.CurrentOtherFill.Name = "CurrentOtherFill";
            this.CurrentOtherFill.Size = new System.Drawing.Size(16, 17);
            this.CurrentOtherFill.TabIndex = 23;
            this.CurrentOtherFill.Text = "0";
            this.CurrentOtherFill.Click += new System.EventHandler(this.CurrentOtherFill_Click);
            // 
            // InputOtherExpense
            // 
            this.InputOtherExpense.Location = new System.Drawing.Point(95, 229);
            this.InputOtherExpense.Name = "InputOtherExpense";
            this.InputOtherExpense.Size = new System.Drawing.Size(67, 22);
            this.InputOtherExpense.TabIndex = 22;
            this.InputOtherExpense.Text = "0";
            this.InputOtherExpense.TextChanged += new System.EventHandler(this.InputOtherExpense_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(49, 232);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Other";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(335, 300);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 27;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 343);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.MaxOtherExpense);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CurrentOtherFill);
            this.Controls.Add(this.InputOtherExpense);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.MaxRentExpense);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CurrentRentFill);
            this.Controls.Add(this.InputRentExpense);
            this.Controls.Add(this.rent);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.MaxFoodExpense);
            this.Controls.Add(this.divider);
            this.Controls.Add(this.CurrentFoodFill);
            this.Controls.Add(this.InputFoodExpense);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.InputMyCash);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MaxGasExpense);
            this.Controls.Add(this.CurrentGasFill);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.InputGasExpense);
            this.Controls.Add(this.SubmitAll);
            this.Controls.Add(this.gaslabel);
            this.Name = "Form1";
            this.Text = "BudgetAllocator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label gaslabel;
        private System.Windows.Forms.Button SubmitAll;
        private System.Windows.Forms.TextBox InputGasExpense;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label CurrentGasFill;
        private System.Windows.Forms.TextBox MaxGasExpense;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox InputMyCash;
        private System.Windows.Forms.Label Food;
        private System.Windows.Forms.TextBox InputFoodExpense;
        private System.Windows.Forms.Label CurrentFoodFill;
        private System.Windows.Forms.Label divider;
        private System.Windows.Forms.TextBox MaxFoodExpense;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox MaxRentExpense;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label CurrentRentFill;
        private System.Windows.Forms.TextBox InputRentExpense;
        private System.Windows.Forms.Label rent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox MaxOtherExpense;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CurrentOtherFill;
        private System.Windows.Forms.TextBox InputOtherExpense;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
    }
}

