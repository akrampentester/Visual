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
    public partial class informationOfProjectPlace : Form
    {
        public informationOfProjectPlace()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectProjectPlace back = new selectProjectPlace();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }

        private void addExpenses(object sender, EventArgs e)
        {
            this.Hide();
            Add_Expenses_page addExpense = new Add_Expenses_page();
            addExpense.Closed += (s, args) => this.Close();
            addExpense.Show();
        }

        private void buttonAddTraning_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddTraining Add_Training = new AddTraining();
            Add_Training.Closed += (s, args) => this.Close();
            Add_Training.Show();
        }

        private void buttonAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddEmployee add_Employee = new AddEmployee();
            add_Employee.Closed += (s, args) => this.Close();
            add_Employee.Show();
        }

        private void employeeSalary_Click(object sender, EventArgs e)
        {
            this.Hide();
            employee_salary_page employeeSalary = new employee_salary_page();
            employeeSalary.Closed += (s, args) => this.Close();
            employeeSalary.Show();
        }

       

        private void buttonDisplayFinancial_Click(object sender, EventArgs e)
        {
            this.Hide();
            Financial_Information back = new Financial_Information();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }

        private void buttonDisplayDescription_Click(object sender, EventArgs e)
        {
            this.Hide();
            Project_Description back = new Project_Description();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }

        
    }
}
