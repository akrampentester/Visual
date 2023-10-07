namespace financial_system
{
    partial class addComingMoney
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
            this.addMoney = new System.Windows.Forms.Button();
            this.enterValue = new System.Windows.Forms.Label();
            this.textBox2_value_dolar = new System.Windows.Forms.TextBox();
            this.button_dolar = new System.Windows.Forms.Button();
            this.textBoxValueMoney = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.specifiedMoneyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.total_moneyDataSet = new financial_system.total_moneyDataSet();
            this.specifiedMoneyTableAdapter = new financial_system.total_moneyDataSetTableAdapters.specifiedMoneyTableAdapter();
            this.tableAdapterManager = new financial_system.total_moneyDataSetTableAdapters.TableAdapterManager();
            this.specifiedMoneyDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.button_back = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedMoneyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_moneyDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedMoneyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addMoney
            // 
            this.addMoney.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMoney.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.addMoney.Location = new System.Drawing.Point(339, 358);
            this.addMoney.Margin = new System.Windows.Forms.Padding(2);
            this.addMoney.Name = "addMoney";
            this.addMoney.Size = new System.Drawing.Size(167, 57);
            this.addMoney.TabIndex = 8;
            this.addMoney.Text = "Add money";
            this.addMoney.UseVisualStyleBackColor = true;
            this.addMoney.Click += new System.EventHandler(this.addMoney_Click);
            // 
            // enterValue
            // 
            this.enterValue.AutoSize = true;
            this.enterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterValue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.enterValue.Location = new System.Drawing.Point(11, 223);
            this.enterValue.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.enterValue.Name = "enterValue";
            this.enterValue.Size = new System.Drawing.Size(432, 25);
            this.enterValue.TabIndex = 14;
            this.enterValue.Text = "if it is foreign currency ,enter the value of it :";
            this.enterValue.Visible = false;
            // 
            // textBox2_value_dolar
            // 
            this.textBox2_value_dolar.Location = new System.Drawing.Point(447, 227);
            this.textBox2_value_dolar.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2_value_dolar.Name = "textBox2_value_dolar";
            this.textBox2_value_dolar.Size = new System.Drawing.Size(153, 24);
            this.textBox2_value_dolar.TabIndex = 13;
            this.textBox2_value_dolar.Visible = false;
            this.textBox2_value_dolar.TextChanged += new System.EventHandler(this.textBox2_value_dolar_TextChanged);
            // 
            // button_dolar
            // 
            this.button_dolar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_dolar.Location = new System.Drawing.Point(571, 148);
            this.button_dolar.Margin = new System.Windows.Forms.Padding(2);
            this.button_dolar.Name = "button_dolar";
            this.button_dolar.Size = new System.Drawing.Size(159, 51);
            this.button_dolar.TabIndex = 12;
            this.button_dolar.Text = "Add foreign currency";
            this.button_dolar.UseVisualStyleBackColor = true;
            this.button_dolar.Click += new System.EventHandler(this.button_dolar_Click);
            // 
            // textBoxValueMoney
            // 
            this.textBoxValueMoney.Location = new System.Drawing.Point(245, 162);
            this.textBoxValueMoney.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxValueMoney.Name = "textBoxValueMoney";
            this.textBoxValueMoney.Size = new System.Drawing.Size(270, 24);
            this.textBoxValueMoney.TabIndex = 11;
            this.textBoxValueMoney.TextChanged += new System.EventHandler(this.textBoxValueMoney_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(26, 162);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(221, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter coming money :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(7, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 111);
            this.panel1.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(232, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 36);
            this.label1.TabIndex = 11;
            this.label1.Text = "Adding Coming Money";
            // 
            // specifiedMoneyBindingSource
            // 
            this.specifiedMoneyBindingSource.DataMember = "specifiedMoney";
            this.specifiedMoneyBindingSource.DataSource = this.total_moneyDataSet;
            // 
            // total_moneyDataSet
            // 
            this.total_moneyDataSet.DataSetName = "total_moneyDataSet";
            this.total_moneyDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // specifiedMoneyTableAdapter
            // 
            this.specifiedMoneyTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.specifiedMoneyTableAdapter = this.specifiedMoneyTableAdapter;
            this.tableAdapterManager.UpdateOrder = financial_system.total_moneyDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // specifiedMoneyDataGridView
            // 
            this.specifiedMoneyDataGridView.AllowUserToAddRows = false;
            this.specifiedMoneyDataGridView.AllowUserToDeleteRows = false;
            this.specifiedMoneyDataGridView.AutoGenerateColumns = false;
            this.specifiedMoneyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.specifiedMoneyDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2});
            this.specifiedMoneyDataGridView.DataSource = this.specifiedMoneyBindingSource;
            this.specifiedMoneyDataGridView.Location = new System.Drawing.Point(41, 288);
            this.specifiedMoneyDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.specifiedMoneyDataGridView.Name = "specifiedMoneyDataGridView";
            this.specifiedMoneyDataGridView.ReadOnly = true;
            this.specifiedMoneyDataGridView.RowHeadersWidth = 51;
            this.specifiedMoneyDataGridView.RowTemplate.Height = 24;
            this.specifiedMoneyDataGridView.Size = new System.Drawing.Size(243, 220);
            this.specifiedMoneyDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "specifiedMoney";
            this.dataGridViewTextBoxColumn2.HeaderText = "specifiedMoney";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 125;
            // 
            // button_back
            // 
            this.button_back.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_back.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_back.Location = new System.Drawing.Point(589, 358);
            this.button_back.Margin = new System.Windows.Forms.Padding(2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(167, 57);
            this.button_back.TabIndex = 21;
            this.button_back.Text = "Back";
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // addComingMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(791, 567);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.specifiedMoneyDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.addMoney);
            this.Controls.Add(this.enterValue);
            this.Controls.Add(this.textBox2_value_dolar);
            this.Controls.Add(this.button_dolar);
            this.Controls.Add(this.textBoxValueMoney);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "addComingMoney";
            this.Text = "addComingMoney";
            this.Load += new System.EventHandler(this.addComingMoney_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedMoneyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.total_moneyDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.specifiedMoneyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addMoney;
        private System.Windows.Forms.Label enterValue;
        private System.Windows.Forms.TextBox textBox2_value_dolar;
        private System.Windows.Forms.Button button_dolar;
        private System.Windows.Forms.TextBox textBoxValueMoney;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private total_moneyDataSet total_moneyDataSet;
        private System.Windows.Forms.BindingSource specifiedMoneyBindingSource;
        private total_moneyDataSetTableAdapters.specifiedMoneyTableAdapter specifiedMoneyTableAdapter;
        private total_moneyDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView specifiedMoneyDataGridView;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
    }
}