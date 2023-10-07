namespace financial_system
{
    partial class Financial_Information
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
            this.shortfallBudget = new System.Windows.Forms.Label();
            this.requiredBudget = new System.Windows.Forms.Label();
            this.projectBudget = new System.Windows.Forms.Label();
            this.employeesMoney = new System.Windows.Forms.Label();
            this.trainingMoney = new System.Windows.Forms.Label();
            this.projectPLACE = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showFinancialInformation = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.tryAgain = new System.Windows.Forms.Button();
            this.projectPlaceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projectPlaceDBDataSet = new financial_system.ProjectPlaceDBDataSet();
            this.projectPlaceTableAdapter = new financial_system.ProjectPlaceDBDataSetTableAdapters.projectPlaceTableAdapter();
            this.tableAdapterManager = new financial_system.ProjectPlaceDBDataSetTableAdapters.TableAdapterManager();
            this.budgetLabel = new System.Windows.Forms.Label();
            this.employeeMoneyLabel = new System.Windows.Forms.Label();
            this.traingsMoneyLabel = new System.Windows.Forms.Label();
            this.requiredBudgetLabel = new System.Windows.Forms.Label();
            this.ExtraiMONEY = new System.Windows.Forms.Label();
            this.extraLabel = new System.Windows.Forms.Label();
            this.shortfallLabel = new System.Windows.Forms.Label();
            this.Flag = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // shortfallBudget
            // 
            this.shortfallBudget.AutoSize = true;
            this.shortfallBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortfallBudget.Location = new System.Drawing.Point(94, 550);
            this.shortfallBudget.Name = "shortfallBudget";
            this.shortfallBudget.Size = new System.Drawing.Size(195, 25);
            this.shortfallBudget.TabIndex = 15;
            this.shortfallBudget.Text = "Budget Shortfall :";
            // 
            // requiredBudget
            // 
            this.requiredBudget.AutoSize = true;
            this.requiredBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredBudget.Location = new System.Drawing.Point(92, 479);
            this.requiredBudget.Name = "requiredBudget";
            this.requiredBudget.Size = new System.Drawing.Size(182, 25);
            this.requiredBudget.TabIndex = 14;
            this.requiredBudget.Text = "Total Expenses:";
            // 
            // projectBudget
            // 
            this.projectBudget.AutoSize = true;
            this.projectBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectBudget.Location = new System.Drawing.Point(92, 210);
            this.projectBudget.Name = "projectBudget";
            this.projectBudget.Size = new System.Drawing.Size(247, 25);
            this.projectBudget.TabIndex = 13;
            this.projectBudget.Text = "Project Place Budget :";
            // 
            // employeesMoney
            // 
            this.employeesMoney.AutoSize = true;
            this.employeesMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeesMoney.Location = new System.Drawing.Point(92, 276);
            this.employeesMoney.Name = "employeesMoney";
            this.employeesMoney.Size = new System.Drawing.Size(317, 25);
            this.employeesMoney.TabIndex = 12;
            this.employeesMoney.Text = "Money Spent on employees :";
            // 
            // trainingMoney
            // 
            this.trainingMoney.AutoSize = true;
            this.trainingMoney.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainingMoney.Location = new System.Drawing.Point(92, 346);
            this.trainingMoney.Name = "trainingMoney";
            this.trainingMoney.Size = new System.Drawing.Size(283, 25);
            this.trainingMoney.TabIndex = 11;
            this.trainingMoney.Text = "Money Spent on training :";
            // 
            // projectPLACE
            // 
            this.projectPLACE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectPLACE.Location = new System.Drawing.Point(398, 116);
            this.projectPLACE.Name = "projectPLACE";
            this.projectPLACE.Size = new System.Drawing.Size(252, 26);
            this.projectPLACE.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Project Place : ";
            // 
            // showFinancialInformation
            // 
            this.showFinancialInformation.BackColor = System.Drawing.Color.SeaGreen;
            this.showFinancialInformation.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.showFinancialInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showFinancialInformation.ForeColor = System.Drawing.Color.Black;
            this.showFinancialInformation.Location = new System.Drawing.Point(713, 108);
            this.showFinancialInformation.Name = "showFinancialInformation";
            this.showFinancialInformation.Size = new System.Drawing.Size(183, 45);
            this.showFinancialInformation.TabIndex = 8;
            this.showFinancialInformation.Text = "Show Financial Information";
            this.showFinancialInformation.UseVisualStyleBackColor = false;
            this.showFinancialInformation.Click += new System.EventHandler(this.Show_Financial_Information);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(803, 612);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(102, 39);
            this.Exit.TabIndex = 16;
            this.Exit.Text = "Back";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.exit);
            // 
            // tryAgain
            // 
            this.tryAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tryAgain.Location = new System.Drawing.Point(652, 612);
            this.tryAgain.Name = "tryAgain";
            this.tryAgain.Size = new System.Drawing.Size(122, 39);
            this.tryAgain.TabIndex = 17;
            this.tryAgain.Text = "Try Again";
            this.tryAgain.UseVisualStyleBackColor = true;
            this.tryAgain.Click += new System.EventHandler(this.TryAgain);
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
            // budgetLabel
            // 
            this.budgetLabel.AutoSize = true;
            this.budgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budgetLabel.Location = new System.Drawing.Point(485, 219);
            this.budgetLabel.Name = "budgetLabel";
            this.budgetLabel.Size = new System.Drawing.Size(95, 25);
            this.budgetLabel.TabIndex = 19;
            this.budgetLabel.Text = "MONEY";
            // 
            // employeeMoneyLabel
            // 
            this.employeeMoneyLabel.AutoSize = true;
            this.employeeMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeMoneyLabel.Location = new System.Drawing.Point(485, 287);
            this.employeeMoneyLabel.Name = "employeeMoneyLabel";
            this.employeeMoneyLabel.Size = new System.Drawing.Size(95, 25);
            this.employeeMoneyLabel.TabIndex = 20;
            this.employeeMoneyLabel.Text = "MONEY";
            // 
            // traingsMoneyLabel
            // 
            this.traingsMoneyLabel.AutoSize = true;
            this.traingsMoneyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.traingsMoneyLabel.Location = new System.Drawing.Point(485, 355);
            this.traingsMoneyLabel.Name = "traingsMoneyLabel";
            this.traingsMoneyLabel.Size = new System.Drawing.Size(95, 25);
            this.traingsMoneyLabel.TabIndex = 21;
            this.traingsMoneyLabel.Text = "MONEY";
            // 
            // requiredBudgetLabel
            // 
            this.requiredBudgetLabel.AutoSize = true;
            this.requiredBudgetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requiredBudgetLabel.Location = new System.Drawing.Point(485, 491);
            this.requiredBudgetLabel.Name = "requiredBudgetLabel";
            this.requiredBudgetLabel.Size = new System.Drawing.Size(95, 25);
            this.requiredBudgetLabel.TabIndex = 22;
            this.requiredBudgetLabel.Text = "MONEY";
            // 
            // ExtraiMONEY
            // 
            this.ExtraiMONEY.AutoSize = true;
            this.ExtraiMONEY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExtraiMONEY.Location = new System.Drawing.Point(91, 415);
            this.ExtraiMONEY.Name = "ExtraiMONEY";
            this.ExtraiMONEY.Size = new System.Drawing.Size(318, 25);
            this.ExtraiMONEY.TabIndex = 23;
            this.ExtraiMONEY.Text = "Money Spent on Extra Thing:";
            // 
            // extraLabel
            // 
            this.extraLabel.AutoSize = true;
            this.extraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.extraLabel.Location = new System.Drawing.Point(485, 428);
            this.extraLabel.Name = "extraLabel";
            this.extraLabel.Size = new System.Drawing.Size(95, 25);
            this.extraLabel.TabIndex = 24;
            this.extraLabel.Text = "MONEY";
            // 
            // shortfallLabel
            // 
            this.shortfallLabel.AutoSize = true;
            this.shortfallLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shortfallLabel.Location = new System.Drawing.Point(724, 550);
            this.shortfallLabel.Name = "shortfallLabel";
            this.shortfallLabel.Size = new System.Drawing.Size(95, 25);
            this.shortfallLabel.TabIndex = 25;
            this.shortfallLabel.Text = "MONEY";
            // 
            // Flag
            // 
            this.Flag.AutoSize = true;
            this.Flag.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Flag.Location = new System.Drawing.Point(324, 550);
            this.Flag.Name = "Flag";
            this.Flag.Size = new System.Drawing.Size(95, 25);
            this.Flag.TabIndex = 26;
            this.Flag.Text = "MONEY";
            // 
            // Financial_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1028, 671);
            this.Controls.Add(this.Flag);
            this.Controls.Add(this.shortfallLabel);
            this.Controls.Add(this.extraLabel);
            this.Controls.Add(this.ExtraiMONEY);
            this.Controls.Add(this.requiredBudgetLabel);
            this.Controls.Add(this.traingsMoneyLabel);
            this.Controls.Add(this.employeeMoneyLabel);
            this.Controls.Add(this.budgetLabel);
            this.Controls.Add(this.tryAgain);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.shortfallBudget);
            this.Controls.Add(this.requiredBudget);
            this.Controls.Add(this.projectBudget);
            this.Controls.Add(this.employeesMoney);
            this.Controls.Add(this.trainingMoney);
            this.Controls.Add(this.projectPLACE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.showFinancialInformation);
            this.Name = "Financial_Information";
            this.Text = "Financial_Information";
            this.Load += new System.EventHandler(this.Financial_Information_Load);
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projectPlaceDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label shortfallBudget;
        private System.Windows.Forms.Label requiredBudget;
        private System.Windows.Forms.Label projectBudget;
        private System.Windows.Forms.Label employeesMoney;
        private System.Windows.Forms.Label trainingMoney;
        private System.Windows.Forms.TextBox projectPLACE;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showFinancialInformation;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button tryAgain;
        private ProjectPlaceDBDataSet projectPlaceDBDataSet;
        private System.Windows.Forms.BindingSource projectPlaceBindingSource;
        private ProjectPlaceDBDataSetTableAdapters.projectPlaceTableAdapter projectPlaceTableAdapter;
        private ProjectPlaceDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label budgetLabel;
        private System.Windows.Forms.Label employeeMoneyLabel;
        private System.Windows.Forms.Label traingsMoneyLabel;
        private System.Windows.Forms.Label requiredBudgetLabel;
        private System.Windows.Forms.Label ExtraiMONEY;
        private System.Windows.Forms.Label extraLabel;
        private System.Windows.Forms.Label shortfallLabel;
        private System.Windows.Forms.Label Flag;
    }
}