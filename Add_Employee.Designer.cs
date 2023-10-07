namespace financial_system
{
    partial class AddEmployee
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label country_NameLabel;
            this.dateTimePickerAddEmployee = new System.Windows.Forms.DateTimePicker();
            this.Datelabel = new System.Windows.Forms.Label();
            this.AddEmployeebutton = new System.Windows.Forms.Button();
            this.JobTitleTextBoxAddEmployee = new System.Windows.Forms.TextBox();
            this.JobTitle = new System.Windows.Forms.Label();
            this.SalaryTextBoxAddEmployee = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextBoxAdd = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.employee_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.financialProjectDatabaseDataSet = new financial_system.FinancialProjectDatabaseDataSet();
            this.employee_TableTableAdapter = new financial_system.FinancialProjectDatabaseDataSetTableAdapters.Employee_TableTableAdapter();
            this.tableAdapterManager = new financial_system.FinancialProjectDatabaseDataSetTableAdapters.TableAdapterManager();
            this.country_NameComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.employee_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.projectPlaceDBDataSet = new financial_system.ProjectPlaceDBDataSet();
            this.projectPlaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectPlaceTableAdapter = new financial_system.ProjectPlaceDBDataSetTableAdapters.projectPlaceTableAdapter();
            this.tableAdapterManager1 = new financial_system.ProjectPlaceDBDataSetTableAdapters.TableAdapterManager();
            country_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialProjectDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // country_NameLabel
            // 
            country_NameLabel.AutoSize = true;
            country_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            country_NameLabel.Location = new System.Drawing.Point(338, 104);
            country_NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            country_NameLabel.Name = "country_NameLabel";
            country_NameLabel.Size = new System.Drawing.Size(185, 29);
            country_NameLabel.TabIndex = 59;
            country_NameLabel.Text = "Country Name:";
            // 
            // dateTimePickerAddEmployee
            // 
            this.dateTimePickerAddEmployee.Location = new System.Drawing.Point(826, 234);
            this.dateTimePickerAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePickerAddEmployee.Name = "dateTimePickerAddEmployee";
            this.dateTimePickerAddEmployee.Size = new System.Drawing.Size(352, 24);
            this.dateTimePickerAddEmployee.TabIndex = 57;
            // 
            // Datelabel
            // 
            this.Datelabel.AutoSize = true;
            this.Datelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Datelabel.Location = new System.Drawing.Point(734, 231);
            this.Datelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Datelabel.Name = "Datelabel";
            this.Datelabel.Size = new System.Drawing.Size(57, 25);
            this.Datelabel.TabIndex = 56;
            this.Datelabel.Text = "Date";
            // 
            // AddEmployeebutton
            // 
            this.AddEmployeebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmployeebutton.Location = new System.Drawing.Point(478, 290);
            this.AddEmployeebutton.Margin = new System.Windows.Forms.Padding(2);
            this.AddEmployeebutton.Name = "AddEmployeebutton";
            this.AddEmployeebutton.Size = new System.Drawing.Size(175, 39);
            this.AddEmployeebutton.TabIndex = 55;
            this.AddEmployeebutton.Text = "Add Employee";
            this.AddEmployeebutton.UseVisualStyleBackColor = true;
            this.AddEmployeebutton.Click += new System.EventHandler(this.AddEmployeebutton_Click);
            // 
            // JobTitleTextBoxAddEmployee
            // 
            this.JobTitleTextBoxAddEmployee.Location = new System.Drawing.Point(187, 226);
            this.JobTitleTextBoxAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.JobTitleTextBoxAddEmployee.Multiline = true;
            this.JobTitleTextBoxAddEmployee.Name = "JobTitleTextBoxAddEmployee";
            this.JobTitleTextBoxAddEmployee.Size = new System.Drawing.Size(349, 25);
            this.JobTitleTextBoxAddEmployee.TabIndex = 54;
            // 
            // JobTitle
            // 
            this.JobTitle.AutoSize = true;
            this.JobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JobTitle.Location = new System.Drawing.Point(47, 226);
            this.JobTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.JobTitle.Name = "JobTitle";
            this.JobTitle.Size = new System.Drawing.Size(96, 25);
            this.JobTitle.TabIndex = 53;
            this.JobTitle.Text = "Job Title";
            // 
            // SalaryTextBoxAddEmployee
            // 
            this.SalaryTextBoxAddEmployee.Location = new System.Drawing.Point(826, 180);
            this.SalaryTextBoxAddEmployee.Margin = new System.Windows.Forms.Padding(2);
            this.SalaryTextBoxAddEmployee.Multiline = true;
            this.SalaryTextBoxAddEmployee.Name = "SalaryTextBoxAddEmployee";
            this.SalaryTextBoxAddEmployee.Size = new System.Drawing.Size(349, 25);
            this.SalaryTextBoxAddEmployee.TabIndex = 52;
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumberLabel.Location = new System.Drawing.Point(734, 185);
            this.NumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(74, 25);
            this.NumberLabel.TabIndex = 51;
            this.NumberLabel.Text = "Salary\r\n";
            // 
            // EmployeeNameTextBoxAdd
            // 
            this.EmployeeNameTextBoxAdd.Location = new System.Drawing.Point(187, 185);
            this.EmployeeNameTextBoxAdd.Margin = new System.Windows.Forms.Padding(2);
            this.EmployeeNameTextBoxAdd.Multiline = true;
            this.EmployeeNameTextBoxAdd.Name = "EmployeeNameTextBoxAdd";
            this.EmployeeNameTextBoxAdd.Size = new System.Drawing.Size(349, 25);
            this.EmployeeNameTextBoxAdd.TabIndex = 50;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(9, 185);
            this.NameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(169, 25);
            this.NameLabel.TabIndex = 49;
            this.NameLabel.Text = "Employee Name";
            // 
            // employee_TableBindingSource
            // 
            this.employee_TableBindingSource.DataMember = "Employee_Table";
            this.employee_TableBindingSource.DataSource = this.financialProjectDatabaseDataSet;
            // 
            // financialProjectDatabaseDataSet
            // 
            this.financialProjectDatabaseDataSet.DataSetName = "FinancialProjectDatabaseDataSet";
            this.financialProjectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_TableTableAdapter
            // 
            this.employee_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Employee_TableTableAdapter = this.employee_TableTableAdapter;
            this.tableAdapterManager.Training_TableTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = financial_system.FinancialProjectDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // country_NameComboBox
            // 
            this.country_NameComboBox.FormattingEnabled = true;
            this.country_NameComboBox.Items.AddRange(new object[] {
            "Towa",
            "Bardnoha",
            "Mansafis",
            "Abwan",
            "IDAM"});
            this.country_NameComboBox.Location = new System.Drawing.Point(584, 104);
            this.country_NameComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.country_NameComboBox.Name = "country_NameComboBox";
            this.country_NameComboBox.Size = new System.Drawing.Size(237, 24);
            this.country_NameComboBox.TabIndex = 60;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(707, 290);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 39);
            this.button1.TabIndex = 61;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // employee_TableDataGridView
            // 
            this.employee_TableDataGridView.AutoGenerateColumns = false;
            this.employee_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.employee_TableDataGridView.DataSource = this.employee_TableBindingSource;
            this.employee_TableDataGridView.Location = new System.Drawing.Point(121, 370);
            this.employee_TableDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.employee_TableDataGridView.Name = "employee_TableDataGridView";
            this.employee_TableDataGridView.RowHeadersWidth = 51;
            this.employee_TableDataGridView.RowTemplate.Height = 26;
            this.employee_TableDataGridView.Size = new System.Drawing.Size(936, 220);
            this.employee_TableDataGridView.TabIndex = 61;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CountryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CountryName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Employee Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = " Job Title";
            this.dataGridViewTextBoxColumn4.HeaderText = " Job Title";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn5.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // projectPlaceDBDataSet
            // 
            this.projectPlaceDBDataSet.DataSetName = "ProjectPlaceDBDataSet";
            this.projectPlaceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectPlaceBindingSource
            // 
            this.projectPlaceBindingSource.DataMember = "projectPlace";
            this.projectPlaceBindingSource.DataSource = this.projectPlaceDBDataSet;
            // 
            // projectPlaceTableAdapter
            // 
            this.projectPlaceTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.projectPlaceTableAdapter = this.projectPlaceTableAdapter;
            this.tableAdapterManager1.UpdateOrder = financial_system.ProjectPlaceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // AddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1197, 644);
            this.Controls.Add(this.employee_TableDataGridView);
            this.Controls.Add(this.button1);
            this.Controls.Add(country_NameLabel);
            this.Controls.Add(this.country_NameComboBox);
            this.Controls.Add(this.dateTimePickerAddEmployee);
            this.Controls.Add(this.Datelabel);
            this.Controls.Add(this.AddEmployeebutton);
            this.Controls.Add(this.JobTitleTextBoxAddEmployee);
            this.Controls.Add(this.JobTitle);
            this.Controls.Add(this.SalaryTextBoxAddEmployee);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.EmployeeNameTextBoxAdd);
            this.Controls.Add(this.NameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddEmployee";
            this.Text = "Add_Employee";
            this.Load += new System.EventHandler(this.AddEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialProjectDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerAddEmployee;
        private System.Windows.Forms.Label Datelabel;
        private System.Windows.Forms.Button AddEmployeebutton;
        private System.Windows.Forms.TextBox JobTitleTextBoxAddEmployee;
        private System.Windows.Forms.Label JobTitle;
        private System.Windows.Forms.TextBox SalaryTextBoxAddEmployee;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox EmployeeNameTextBoxAdd;
        private System.Windows.Forms.Label NameLabel;
        private FinancialProjectDatabaseDataSet financialProjectDatabaseDataSet;
        private System.Windows.Forms.BindingSource employee_TableBindingSource;
        private FinancialProjectDatabaseDataSetTableAdapters.Employee_TableTableAdapter employee_TableTableAdapter;
        private FinancialProjectDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox country_NameComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView employee_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private ProjectPlaceDBDataSet projectPlaceDBDataSet;
        private System.Windows.Forms.BindingSource projectPlaceBindingSource;
        private ProjectPlaceDBDataSetTableAdapters.projectPlaceTableAdapter projectPlaceTableAdapter;
        private ProjectPlaceDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
    }
}