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
    public partial class employee_salary_page : Form
    {
        public employee_salary_page()
        {
            InitializeComponent();
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            informationOfProjectPlace back = new informationOfProjectPlace();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }

        private void pay_salary_Click(object sender, EventArgs e)
        {
            
            //get data from user
            string countryName=this.countryNameComboBox.Text;
            //loشd old Employees expenses
            decimal addedSalary=(decimal) this.employee_TableTableAdapter.CountryAllEmployeesSalary(countryName);
            // add the salary to the project place

            int id = (int)this.projectPlaceTableAdapter.getIDbyName(countryName);
            decimal oldEmployeeExpenses = (decimal)this.projectPlaceTableAdapter.employeeExpenses(countryName);
            decimal newEmployeeExpenses = addedSalary + oldEmployeeExpenses;
            //update employe expenses
            this.projectPlaceTableAdapter.UpdateEmployeeExpenses(newEmployeeExpenses, id, countryName);
            MessageBox.Show("DONE");
        }

        private void projectPlaceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectPlaceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectPlaceDBDataSet);

        }

        private void employee_salary_page_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'financialProjectDatabaseDataSet.Employee_Table' table. You can move, or remove it, as needed.
            this.employee_TableTableAdapter.Fill(this.financialProjectDatabaseDataSet.Employee_Table);
            // TODO: This line of code loads data into the 'projectPlaceDBDataSet.projectPlace' table. You can move, or remove it, as needed.
            this.projectPlaceTableAdapter.Fill(this.projectPlaceDBDataSet.projectPlace);

        }

        private void search_Click(object sender, EventArgs e)
        {
            string countryName = this.countryNameComboBox.Text;
            this.employee_TableTableAdapter.EmployeesInPlace(this.financialProjectDatabaseDataSet.Employee_Table, countryName);
        }
    }
}
