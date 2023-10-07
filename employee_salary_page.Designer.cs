namespace financial_system
{
    partial class employee_salary_page
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
            System.Windows.Forms.Label countryNameLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.backbutton = new System.Windows.Forms.Button();
            this.pay_salary = new System.Windows.Forms.Button();
            this.projectPlaceDBDataSet = new financial_system.ProjectPlaceDBDataSet();
            this.projectPlaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectPlaceTableAdapter = new financial_system.ProjectPlaceDBDataSetTableAdapters.projectPlaceTableAdapter();
            this.tableAdapterManager = new financial_system.ProjectPlaceDBDataSetTableAdapters.TableAdapterManager();
            this.financialProjectDatabaseDataSet = new financial_system.FinancialProjectDatabaseDataSet();
            this.employee_TableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employee_TableTableAdapter = new financial_system.FinancialProjectDatabaseDataSetTableAdapters.Employee_TableTableAdapter();
            this.tableAdapterManager1 = new financial_system.FinancialProjectDatabaseDataSetTableAdapters.TableAdapterManager();
            this.employee_TableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryNameComboBox = new System.Windows.Forms.ComboBox();
            this.search = new System.Windows.Forms.Button();
            countryNameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialProjectDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // countryNameLabel
            // 
            countryNameLabel.AutoSize = true;
            countryNameLabel.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            countryNameLabel.Location = new System.Drawing.Point(27, 72);
            countryNameLabel.Name = "countryNameLabel";
            countryNameLabel.Size = new System.Drawing.Size(138, 21);
            countryNameLabel.TabIndex = 13;
            countryNameLabel.Text = "Country Name:";
            // 
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(582, 371);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(194, 36);
            this.backbutton.TabIndex = 10;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // pay_salary
            // 
            this.pay_salary.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pay_salary.Location = new System.Drawing.Point(478, 72);
            this.pay_salary.Name = "pay_salary";
            this.pay_salary.Size = new System.Drawing.Size(169, 51);
            this.pay_salary.TabIndex = 13;
            this.pay_salary.Text = "Pay Salary";
            this.pay_salary.UseVisualStyleBackColor = true;
            this.pay_salary.Click += new System.EventHandler(this.pay_salary_Click);
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.projectPlaceTableAdapter = this.projectPlaceTableAdapter;
            this.tableAdapterManager.UpdateOrder = financial_system.ProjectPlaceDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // financialProjectDatabaseDataSet
            // 
            this.financialProjectDatabaseDataSet.DataSetName = "FinancialProjectDatabaseDataSet";
            this.financialProjectDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employee_TableBindingSource
            // 
            this.employee_TableBindingSource.DataMember = "Employee_Table";
            this.employee_TableBindingSource.DataSource = this.financialProjectDatabaseDataSet;
            // 
            // employee_TableTableAdapter
            // 
            this.employee_TableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Employee_TableTableAdapter = this.employee_TableTableAdapter;
            this.tableAdapterManager1.Training_TableTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = financial_system.FinancialProjectDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // employee_TableDataGridView
            // 
            this.employee_TableDataGridView.AllowUserToAddRows = false;
            this.employee_TableDataGridView.AllowUserToDeleteRows = false;
            this.employee_TableDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.employee_TableDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.employee_TableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employee_TableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.employee_TableDataGridView.DataSource = this.employee_TableBindingSource;
            this.employee_TableDataGridView.Location = new System.Drawing.Point(12, 187);
            this.employee_TableDataGridView.Name = "employee_TableDataGridView";
            this.employee_TableDataGridView.ReadOnly = true;
            this.employee_TableDataGridView.RowHeadersWidth = 51;
            this.employee_TableDataGridView.RowTemplate.Height = 26;
            this.employee_TableDataGridView.Size = new System.Drawing.Size(539, 220);
            this.employee_TableDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CountryName";
            this.dataGridViewTextBoxColumn2.HeaderText = "CountryName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Employee Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = " Job Title";
            this.dataGridViewTextBoxColumn4.HeaderText = " Job Title";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn5.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn6.HeaderText = "Date";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // countryNameComboBox
            // 
            this.countryNameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.employee_TableBindingSource, "CountryName", true));
            this.countryNameComboBox.FormattingEnabled = true;
            this.countryNameComboBox.Items.AddRange(new object[] {
            "Towa",
            "Bardnoha",
            "Mansafis",
            "Abwan",
            "IDAM"});
            this.countryNameComboBox.Location = new System.Drawing.Point(171, 73);
            this.countryNameComboBox.Name = "countryNameComboBox";
            this.countryNameComboBox.Size = new System.Drawing.Size(158, 24);
            this.countryNameComboBox.TabIndex = 14;
            // 
            // search
            // 
            this.search.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search.Location = new System.Drawing.Point(30, 127);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(160, 40);
            this.search.TabIndex = 15;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // employee_salary_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.search);
            this.Controls.Add(countryNameLabel);
            this.Controls.Add(this.countryNameComboBox);
            this.Controls.Add(this.employee_TableDataGridView);
            this.Controls.Add(this.pay_salary);
            this.Controls.Add(this.backbutton);
            this.Name = "employee_salary_page";
            this.Text = "Employee salary page";
            this.Load += new System.EventHandler(this.employee_salary_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.financialProjectDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employee_TableDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.Button pay_salary;
        private ProjectPlaceDBDataSet projectPlaceDBDataSet;
        private System.Windows.Forms.BindingSource projectPlaceBindingSource;
        private ProjectPlaceDBDataSetTableAdapters.projectPlaceTableAdapter projectPlaceTableAdapter;
        private ProjectPlaceDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private FinancialProjectDatabaseDataSet financialProjectDatabaseDataSet;
        private System.Windows.Forms.BindingSource employee_TableBindingSource;
        private FinancialProjectDatabaseDataSetTableAdapters.Employee_TableTableAdapter employee_TableTableAdapter;
        private FinancialProjectDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView employee_TableDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.ComboBox countryNameComboBox;
        private System.Windows.Forms.Button search;
    }
}