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
    public partial class Financial_Information : Form
    {
        public Financial_Information()
        {
            InitializeComponent();
            projectBudget.Hide();
            employeesMoney.Hide();
            trainingMoney.Hide();
            shortfallBudget.Hide();
            requiredBudget.Hide();
            budgetLabel.Hide();
            employeeMoneyLabel.Hide();
            extraLabel.Hide();
            traingsMoneyLabel.Hide();
            requiredBudgetLabel.Hide();
            shortfallLabel.Hide();
            ExtraiMONEY.Hide();
            tryAgain.Hide();
            Flag.Hide();

        }
        


        private void Show_Financial_Information(object sender, EventArgs e)
        {
            projectBudget.Show();
            employeesMoney.Show();
            trainingMoney.Show();
            shortfallBudget.Show();
            requiredBudget.Show();
            ExtraiMONEY.Show();
            tryAgain.Show();
            decimal budget,employeeMoney,extraiMoney,trainingsMoney,requiredbudget,shortage;
            requiredbudget = 0;
            shortage= 0;
            //get budget and display it
            budget=(decimal)this.projectPlaceTableAdapter.getBudgetByName(projectPLACE.Text);
            budgetLabel.Text=budget.ToString();
            budgetLabel.Show();

            //get employee money and display it
            employeeMoney = (decimal)this.projectPlaceTableAdapter.employeeExpenses(projectPLACE.Text);
            employeeMoneyLabel.Text = employeeMoney.ToString();
            employeeMoneyLabel.Show();

            //get extra money and display it
            extraiMoney = (decimal)this.projectPlaceTableAdapter.getExpensesbyName(projectPLACE.Text);
            extraLabel.Text=extraiMoney.ToString();
            extraLabel.Show();

            //get training money and display
            trainingsMoney=(decimal)this.projectPlaceTableAdapter.getExpesesOfTraininsByName(projectPLACE.Text);
            traingsMoneyLabel.Text=trainingsMoney.ToString();
            traingsMoneyLabel.Show();

            //calculate required budget and display it 
            requiredbudget = employeeMoney + extraiMoney + trainingsMoney;
            requiredBudgetLabel.Text=requiredbudget.ToString();
            requiredBudgetLabel.Show();

            //calculate shortage 
            shortage= budget - requiredbudget;
            if (shortage>0)
            {
                Flag.Text = "No shortfall Money , remain is ";
                shortfallLabel.Text = shortage.ToString();
           

            }
            else
            {
                Flag.Text = "shortfall Money , Needed is ";
                shortfallLabel.Text=shortage.ToString();
            }
            shortfallLabel.Show();
            Flag.Show();





        }

        private void TryAgain(object sender, EventArgs e)
        {

            this.Hide();
            Financial_Information another_try = new Financial_Information();
            another_try.Closed += (s, args) => this.Close();
            another_try.Show();
        }

        
        private void exit(object sender, EventArgs e)
        {
            this.Hide();
            informationOfProjectPlace back = new informationOfProjectPlace();
            back.Closed +=(s, args) => this.Close();
            back.Show();
        }

        private void Financial_Information_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectPlaceDBDataSet.projectPlace' table. You can move, or remove it, as needed.
            this.projectPlaceTableAdapter.Fill(this.projectPlaceDBDataSet.projectPlace);

        }

        private void projectPlaceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectPlaceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectPlaceDBDataSet);

        }
      
    }
}
