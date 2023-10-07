namespace financial_system
{
    partial class Project_Description
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
            this.tryAgain = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.projectPLACE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showFinancialInformation = new System.Windows.Forms.Button();
            this.projectPlaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectPlaceDBDataSet = new financial_system.ProjectPlaceDBDataSet();
            this.projectPlaceDataGridView = new System.Windows.Forms.DataGridView();
            this.projectPlaceTableAdapter = new financial_system.ProjectPlaceDBDataSetTableAdapters.projectPlaceTableAdapter();
            this.tableAdapterManager = new financial_system.ProjectPlaceDBDataSetTableAdapters.TableAdapterManager();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tryAgain
            // 
            this.tryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgain.Location = new System.Drawing.Point(601, 436);
            this.tryAgain.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(142, 48);
            this.tryAgain.TabIndex = 27;
            this.tryAgain.Text = "Try Again";
            this.tryAgain.UseVisualStyleBackColor = true;
            this.tryAgain.Click += new System.EventHandler(this.try_again);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(896, 436);
            this.Exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(119, 48);
            this.Exit.TabIndex = 26;
            this.Exit.Text = "Back";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit);
            // 
            // projectPLACE
            // 
            this.projectPLACE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectPLACE.Location = new System.Drawing.Point(404, 58);
            this.projectPLACE.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projectPLACE.Name = "projectPLACE";
            this.projectPLACE.Size = new System.Drawing.Size(292, 30);
            this.projectPLACE.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 31);
            this.label1.TabIndex = 19;
            this.label1.Text = "Project Place Name : ";
            // 
            // showFinancialInformation
            // 
            this.showFinancialInformation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showFinancialInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFinancialInformation.ForeColor = System.Drawing.Color.Black;
            this.showFinancialInformation.Location = new System.Drawing.Point(796, 48);
            this.showFinancialInformation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.showFinancialInformation.Name = "showFinancialInformation";
            this.showFinancialInformation.Size = new System.Drawing.Size(219, 55);
            this.showFinancialInformation.TabIndex = 18;
            this.showFinancialInformation.Text = "Show Project Description";
            this.showFinancialInformation.UseVisualStyleBackColor = true;
            this.showFinancialInformation.Click += new System.EventHandler(this.project_description);
            // 
            // projectPlaceBindingSource
            // 
            this.projectPlaceBindingSource.DataMember = "projectPlace";
            this.projectPlaceBindingSource.DataSource = this.projectPlaceDBDataSet;
            // 
            // projectPlaceDBDataSet
            // 
            this.projectPlaceDBDataSet.DataSetName = "ProjectPlaceDBDataSet";
            this.projectPlaceDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // projectPlaceDataGridView
            // 
            this.projectPlaceDataGridView.AllowUserToAddRows = false;
            this.projectPlaceDataGridView.AllowUserToDeleteRows = false;
            this.projectPlaceDataGridView.AutoGenerateColumns = false;
            this.projectPlaceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.projectPlaceDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.projectPlaceDataGridView.DataSource = this.projectPlaceBindingSource;
            this.projectPlaceDataGridView.Location = new System.Drawing.Point(48, 138);
            this.projectPlaceDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.projectPlaceDataGridView.Name = "projectPlaceDataGridView";
            this.projectPlaceDataGridView.ReadOnly = true;
            this.projectPlaceDataGridView.RowHeadersWidth = 51;
            this.projectPlaceDataGridView.Size = new System.Drawing.Size(967, 271);
            this.projectPlaceDataGridView.TabIndex = 28;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name Of Project Place";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name Of Project Place";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Number Of Employee";
            this.dataGridViewTextBoxColumn3.HeaderText = "Number Of Employee";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 125;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Number of trainings";
            this.dataGridViewTextBoxColumn4.HeaderText = "Number of trainings";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 125;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Budget";
            this.dataGridViewTextBoxColumn5.HeaderText = "Budget";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 125;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Expenses of trainings";
            this.dataGridViewTextBoxColumn6.HeaderText = "Expenses of trainings";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 125;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Expenses of extra things";
            this.dataGridViewTextBoxColumn7.HeaderText = "Expenses of extra things";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 125;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Expenses of Employee";
            this.dataGridViewTextBoxColumn8.HeaderText = "Expenses of Employee";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 125;
            // 
            // Project_Description
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1060, 519);
            this.Controls.Add(this.projectPlaceDataGridView);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.projectPLACE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showFinancialInformation);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Project_Description";
            this.Text = "Project_Description";
            this.Load += new System.EventHandler(this.Project_Description_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button tryAgain;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox projectPLACE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showFinancialInformation;
        private ProjectPlaceDBDataSet projectPlaceDBDataSet;
        private System.Windows.Forms.BindingSource projectPlaceBindingSource;
        private ProjectPlaceDBDataSetTableAdapters.projectPlaceTableAdapter projectPlaceTableAdapter;
        private ProjectPlaceDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView projectPlaceDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}