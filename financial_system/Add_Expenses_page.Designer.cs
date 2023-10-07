namespace financial_system
{
    partial class Add_Expenses_page
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
            System.Windows.Forms.Label expense_DescriptionLabel;
            System.Windows.Forms.Label money_amountLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.expenses_DBDataSet = new financial_system.Expenses_DBDataSet();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesTableAdapter = new financial_system.Expenses_DBDataSetTableAdapters.ExpensesTableAdapter();
            this.tableAdapterManager = new financial_system.Expenses_DBDataSetTableAdapters.TableAdapterManager();
            this.expensesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country_NameComboBox = new System.Windows.Forms.ComboBox();
            this.expense_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.money_amountTextBox = new System.Windows.Forms.TextBox();
            this.AddExpenses = new System.Windows.Forms.Button();
            this.projectPlaceDBDataSet = new financial_system.ProjectPlaceDBDataSet();
            this.projectPlaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectPlaceTableAdapter = new financial_system.ProjectPlaceDBDataSetTableAdapters.projectPlaceTableAdapter();
            this.tableAdapterManager1 = new financial_system.ProjectPlaceDBDataSetTableAdapters.TableAdapterManager();
            this.backbutton = new System.Windows.Forms.Button();
            country_NameLabel = new System.Windows.Forms.Label();
            expense_DescriptionLabel = new System.Windows.Forms.Label();
            money_amountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expenses_DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // country_NameLabel
            // 
            country_NameLabel.AutoSize = true;
            country_NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            country_NameLabel.Location = new System.Drawing.Point(23, 34);
            country_NameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            country_NameLabel.Name = "country_NameLabel";
            country_NameLabel.Size = new System.Drawing.Size(185, 29);
            country_NameLabel.TabIndex = 2;
            country_NameLabel.Text = "Country Name:";
            // 
            // expense_DescriptionLabel
            // 
            expense_DescriptionLabel.AutoSize = true;
            expense_DescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            expense_DescriptionLabel.Location = new System.Drawing.Point(344, 34);
            expense_DescriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            expense_DescriptionLabel.Name = "expense_DescriptionLabel";
            expense_DescriptionLabel.Size = new System.Drawing.Size(261, 29);
            expense_DescriptionLabel.TabIndex = 4;
            expense_DescriptionLabel.Text = "Expense Description:";
            // 
            // money_amountLabel
            // 
            money_amountLabel.AutoSize = true;
            money_amountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            money_amountLabel.Location = new System.Drawing.Point(15, 132);
            money_amountLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            money_amountLabel.Name = "money_amountLabel";
            money_amountLabel.Size = new System.Drawing.Size(189, 29);
            money_amountLabel.TabIndex = 6;
            money_amountLabel.Text = "money amount:";
            // 
            // expenses_DBDataSet
            // 
            this.expenses_DBDataSet.DataSetName = "Expenses_DBDataSet";
            this.expenses_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.expenses_DBDataSet;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExpensesTableAdapter = this.expensesTableAdapter;
            this.tableAdapterManager.UpdateOrder = financial_system.Expenses_DBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // expensesDataGridView
            // 
            this.expensesDataGridView.AllowUserToAddRows = false;
            this.expensesDataGridView.AllowUserToDeleteRows = false;
            this.expensesDataGridView.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.expensesDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.expensesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.expensesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.expensesDataGridView.DataSource = this.expensesBindingSource;
            this.expensesDataGridView.Location = new System.Drawing.Point(24, 242);
            this.expensesDataGridView.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.expensesDataGridView.Name = "expensesDataGridView";
            this.expensesDataGridView.ReadOnly = true;
            this.expensesDataGridView.RowHeadersWidth = 51;
            this.expensesDataGridView.RowTemplate.Height = 26;
            this.expensesDataGridView.Size = new System.Drawing.Size(522, 220);
            this.expensesDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Country Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Country Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Expense Description";
            this.dataGridViewTextBoxColumn3.HeaderText = "Expense Description";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "money amount";
            this.dataGridViewTextBoxColumn4.HeaderText = "money amount";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // country_NameComboBox
            // 
            this.country_NameComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Country Name", true));
            this.country_NameComboBox.FormattingEnabled = true;
            this.country_NameComboBox.Items.AddRange(new object[] {
            "Towa",
            "Bardnoha",
            "Mansafis",
            "Abwan",
            "IDAM"});
            this.country_NameComboBox.Location = new System.Drawing.Point(24, 66);
            this.country_NameComboBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.country_NameComboBox.Name = "country_NameComboBox";
            this.country_NameComboBox.Size = new System.Drawing.Size(190, 24);
            this.country_NameComboBox.TabIndex = 3;
            this.country_NameComboBox.SelectedIndexChanged += new System.EventHandler(this.country_NameComboBox_SelectedIndexChanged);
            // 
            // expense_DescriptionTextBox
            // 
            this.expense_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "Expense Description", true));
            this.expense_DescriptionTextBox.Location = new System.Drawing.Point(327, 71);
            this.expense_DescriptionTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.expense_DescriptionTextBox.Multiline = true;
            this.expense_DescriptionTextBox.Name = "expense_DescriptionTextBox";
            this.expense_DescriptionTextBox.Size = new System.Drawing.Size(461, 126);
            this.expense_DescriptionTextBox.TabIndex = 5;
            // 
            // money_amountTextBox
            // 
            this.money_amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.expensesBindingSource, "money amount", true));
            this.money_amountTextBox.Location = new System.Drawing.Point(18, 164);
            this.money_amountTextBox.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.money_amountTextBox.Name = "money_amountTextBox";
            this.money_amountTextBox.Size = new System.Drawing.Size(190, 24);
            this.money_amountTextBox.TabIndex = 7;
            // 
            // AddExpenses
            // 
            this.AddExpenses.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddExpenses.Location = new System.Drawing.Point(578, 276);
            this.AddExpenses.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.AddExpenses.Name = "AddExpenses";
            this.AddExpenses.Size = new System.Drawing.Size(190, 36);
            this.AddExpenses.TabIndex = 8;
            this.AddExpenses.Text = "Add Expenses";
            this.AddExpenses.UseVisualStyleBackColor = true;
            this.AddExpenses.Click += new System.EventHandler(this.addExpense);
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
            // backbutton
            // 
            this.backbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backbutton.Location = new System.Drawing.Point(578, 378);
            this.backbutton.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(190, 36);
            this.backbutton.TabIndex = 9;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Add_Expenses_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(812, 487);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.AddExpenses);
            this.Controls.Add(money_amountLabel);
            this.Controls.Add(this.money_amountTextBox);
            this.Controls.Add(expense_DescriptionLabel);
            this.Controls.Add(this.expense_DescriptionTextBox);
            this.Controls.Add(country_NameLabel);
            this.Controls.Add(this.country_NameComboBox);
            this.Controls.Add(this.expensesDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.Name = "Add_Expenses_page";
            this.Text = "Add_Expenses_page";
            this.Load += new System.EventHandler(this.Add_Expenses_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expenses_DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Expenses_DBDataSet expenses_DBDataSet;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private Expenses_DBDataSetTableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private Expenses_DBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView expensesDataGridView;
        private System.Windows.Forms.ComboBox country_NameComboBox;
        private System.Windows.Forms.TextBox expense_DescriptionTextBox;
        private System.Windows.Forms.TextBox money_amountTextBox;
        private System.Windows.Forms.Button AddExpenses;
        private ProjectPlaceDBDataSet projectPlaceDBDataSet;
        private System.Windows.Forms.BindingSource projectPlaceBindingSource;
        private ProjectPlaceDBDataSetTableAdapters.projectPlaceTableAdapter projectPlaceTableAdapter;
        private ProjectPlaceDBDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.Button backbutton;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}