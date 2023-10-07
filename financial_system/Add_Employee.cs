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
    public partial class AddEmployee : Form
    {
        public AddEmployee()
        {
            InitializeComponent();
        }

        private void employee_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialProjectDatabaseDataSet);

        }

        private void AddEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectPlaceDBDataSet.projectPlace' table. You can move, or remove it, as needed.
            this.projectPlaceTableAdapter.Fill(this.projectPlaceDBDataSet.projectPlace);
            // TODO: This line of code loads data into the 'financialProjectDat;abaseDataSet.Employee_Table' table. You can move, or remove it, as needed.
            this.employee_TableTableAdapter.Fill(this.financialProjectDatabaseDataSet.Employee_Table);

        }
        
     
       

      
        string countryName,Employee_name, Job_Title, Date;

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            informationOfProjectPlace Add_Information = new informationOfProjectPlace();
            Add_Information.Closed += (s, args) => this.Close();
            Add_Information.Show();
        }

        double Salary;
        
        private void AddEmployeebutton_Click(object sender, EventArgs e)
        {// add employee information
            //Grep country name , Employee name , Job title , Salary ,data
            countryName = country_NameComboBox.Text;
            Employee_name = EmployeeNameTextBoxAdd.Text;
            Job_Title = JobTitleTextBoxAddEmployee.Text;
            Salary = double.Parse(SalaryTextBoxAddEmployee.Text);
            Date = dateTimePickerAddEmployee.Value.ToString("yyyy-MM-dd");

            //add employee data to dataBase 
            this.employee_TableTableAdapter.InsertEmployee(countryName,Employee_name,Job_Title,Salary,Date);
            this.employee_TableTableAdapter.Fill(this.financialProjectDatabaseDataSet.Employee_Table);
            this.employee_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialProjectDatabaseDataSet);

            int id = (int)this.projectPlaceTableAdapter.getIDbyName(countryName);
            //update number of employee 
            int oldnumber = (int)this.projectPlaceTableAdapter.getNumberOfEmployeeByName(countryName);
            int newnumber = oldnumber + 1;
            this.projectPlaceTableAdapter.UpdateNumberOfEmployee(newnumber, id, countryName);
            MessageBox.Show("DONE");
        }
    }
}
