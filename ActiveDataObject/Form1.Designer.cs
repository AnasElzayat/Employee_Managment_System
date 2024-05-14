namespace ActiveDataObject
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
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.MaleCheckBox = new System.Windows.Forms.CheckBox();
            this.FemaleCheckBox = new System.Windows.Forms.CheckBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.EmpFNameTextBox = new System.Windows.Forms.TextBox();
            this.DeptIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.EmpLNameTextBox = new System.Windows.Forms.TextBox();
            this.EmpIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DeptsComboBox = new System.Windows.Forms.ComboBox();
            this.EmpsListBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SalaryNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MaleCheckBox
            // 
            this.MaleCheckBox.AutoSize = true;
            this.MaleCheckBox.Location = new System.Drawing.Point(535, 171);
            this.MaleCheckBox.Name = "MaleCheckBox";
            this.MaleCheckBox.Size = new System.Drawing.Size(59, 20);
            this.MaleCheckBox.TabIndex = 0;
            this.MaleCheckBox.Text = "Male";
            this.MaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // FemaleCheckBox
            // 
            this.FemaleCheckBox.AutoSize = true;
            this.FemaleCheckBox.Location = new System.Drawing.Point(622, 171);
            this.FemaleCheckBox.Name = "FemaleCheckBox";
            this.FemaleCheckBox.Size = new System.Drawing.Size(75, 20);
            this.FemaleCheckBox.TabIndex = 1;
            this.FemaleCheckBox.Text = "Female";
            this.FemaleCheckBox.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(551, 347);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(75, 23);
            this.UpdateButton.TabIndex = 2;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(666, 347);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(434, 347);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(483, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(457, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Salary";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(451, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Gender";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Last Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(431, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "First Name";
            // 
            // EmpFNameTextBox
            // 
            this.EmpFNameTextBox.Location = new System.Drawing.Point(535, 81);
            this.EmpFNameTextBox.Name = "EmpFNameTextBox";
            this.EmpFNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.EmpFNameTextBox.TabIndex = 10;
            // 
            // DeptIdNumericUpDown
            // 
            this.DeptIdNumericUpDown.Location = new System.Drawing.Point(535, 272);
            this.DeptIdNumericUpDown.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.DeptIdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.DeptIdNumericUpDown.Name = "DeptIdNumericUpDown";
            this.DeptIdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.DeptIdNumericUpDown.TabIndex = 11;
            // 
            // EmpLNameTextBox
            // 
            this.EmpLNameTextBox.Location = new System.Drawing.Point(535, 128);
            this.EmpLNameTextBox.Name = "EmpLNameTextBox";
            this.EmpLNameTextBox.Size = new System.Drawing.Size(100, 22);
            this.EmpLNameTextBox.TabIndex = 13;
            // 
            // EmpIdNumericUpDown
            // 
            this.EmpIdNumericUpDown.Location = new System.Drawing.Point(535, 40);
            this.EmpIdNumericUpDown.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.EmpIdNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.EmpIdNumericUpDown.Name = "EmpIdNumericUpDown";
            this.EmpIdNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.EmpIdNumericUpDown.TabIndex = 14;
            this.EmpIdNumericUpDown.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // DeptsComboBox
            // 
            this.DeptsComboBox.FormattingEnabled = true;
            this.DeptsComboBox.Location = new System.Drawing.Point(92, 63);
            this.DeptsComboBox.Name = "DeptsComboBox";
            this.DeptsComboBox.Size = new System.Drawing.Size(121, 24);
            this.DeptsComboBox.TabIndex = 15;
            this.DeptsComboBox.SelectedIndexChanged += new System.EventHandler(this.DeptsComboBox_SelectedIndexChanged);
            // 
            // EmpsListBox
            // 
            this.EmpsListBox.FormattingEnabled = true;
            this.EmpsListBox.ItemHeight = 16;
            this.EmpsListBox.Location = new System.Drawing.Point(93, 171);
            this.EmpsListBox.Name = "EmpsListBox";
            this.EmpsListBox.Size = new System.Drawing.Size(120, 84);
            this.EmpsListBox.TabIndex = 16;
            this.EmpsListBox.SelectedIndexChanged += new System.EventHandler(this.EmpsListBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 16);
            this.label6.TabIndex = 17;
            this.label6.Text = "Department num";
            // 
            // SalaryNumericUpDown
            // 
            this.SalaryNumericUpDown.Location = new System.Drawing.Point(535, 223);
            this.SalaryNumericUpDown.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.SalaryNumericUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            -2147483648});
            this.SalaryNumericUpDown.Name = "SalaryNumericUpDown";
            this.SalaryNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.SalaryNumericUpDown.TabIndex = 18;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 420);
            this.Controls.Add(this.SalaryNumericUpDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.EmpsListBox);
            this.Controls.Add(this.DeptsComboBox);
            this.Controls.Add(this.EmpIdNumericUpDown);
            this.Controls.Add(this.EmpLNameTextBox);
            this.Controls.Add(this.DeptIdNumericUpDown);
            this.Controls.Add(this.EmpFNameTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.FemaleCheckBox);
            this.Controls.Add(this.MaleCheckBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeptIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalaryNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ComboBox DeptsComboBox;
        private System.Windows.Forms.NumericUpDown EmpIdNumericUpDown;
        private System.Windows.Forms.TextBox EmpLNameTextBox;
        private System.Windows.Forms.NumericUpDown DeptIdNumericUpDown;
        private System.Windows.Forms.TextBox EmpFNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.CheckBox FemaleCheckBox;
        private System.Windows.Forms.CheckBox MaleCheckBox;
        private System.Windows.Forms.ListBox EmpsListBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown SalaryNumericUpDown;
    }
}

