using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace financial_system
{
    public partial class Add_Expenses_page : Form
    {
        public Add_Expenses_page()
        {
            InitializeComponent();
        }

        private void expensesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.expensesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.expenses_DBDataSet);

        }

        private void Add_Expenses_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'expenses_DBDataSet.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this.expenses_DBDataSet.Expenses);
        }
        
        private void addExpense(object sender, EventArgs e)
        {//add expenses to project place
            //save entered expenses
            string countryName = this.country_NameComboBox.Text;
            string expenseDescription = this.expense_DescriptionTextBox.Text;
            decimal money = decimal.Parse(this.money_amountTextBox.Text);

            //add expenses to expenses data base
            this.expensesTableAdapter.InsertExpense(countryName, expenseDescription, money);
            this.expensesTableAdapter.Fill(this.expenses_DBDataSet.Expenses);
            this.expensesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.expenses_DBDataSet);

            // add money of expenses to the project place
            int id = (int) this.projectPlaceTableAdapter.getIDbyName(countryName);
            decimal oldExpenses= (decimal)this.projectPlaceTableAdapter.getExpensesbyName(countryName);
            decimal newExpenses = money + oldExpenses;
            this.projectPlaceTableAdapter.UpdateExpenses(newExpenses,id,countryName);
            MessageBox.Show("DONE");
        }

        private void country_NameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            informationOfProjectPlace back = new informationOfProjectPlace();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }
    }
}
