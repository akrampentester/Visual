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
    public partial class addProjectPlace : Form
    {
        public addProjectPlace()
        {
            InitializeComponent();
        }

        private void projectPlaceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectPlaceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectPlaceDBDataSet);

        }

        private void addProjectPlace_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'total_moneyDataSet.specifiedMoney' table. You can move, or remove it, as needed.
            this.specifiedMoneyTableAdapter.Fill(this.total_moneyDataSet.specifiedMoney);
            // TODO: This line of code loads data into the 'projectPlaceDBDataSet.projectPlace' table. You can move, or remove it, as needed.
            this.projectPlaceTableAdapter.Fill(this.projectPlaceDBDataSet.projectPlace);

        }

        private void add_Click(object sender, EventArgs e)
        {
            //add project place
            //get data from user
            string nameProject = this.name_Of_Project_PlaceTextBox.Text;
            int numberOfEmoloyee = (int)employeeNumericUpDown.Value;
            int numberOfTraining = (int)trainingNumericUpDown.Value;
            decimal budget = budgetNumericUpDown.Value;
            decimal expensesTraining = expensesTrainingNumericUpDown1.Value;
            decimal expensesExtraThings = expensesThingsNumericUpDown.Value;
            decimal expensesOfEmployee = expensesEmployeeNumericUpDown.Value;
            this.projectPlaceTableAdapter.InsertNewProjectPlace(nameProject, numberOfEmoloyee, numberOfTraining, budget, expensesTraining, expensesExtraThings, expensesOfEmployee);
            this.projectPlaceTableAdapter.Fill(this.projectPlaceDBDataSet.projectPlace);
            this.projectPlaceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectPlaceDBDataSet);
            MessageBox.Show("DONE");
        }

        private void name_Of_Project_PlaceTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void budgetTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectProjectPlace back = new selectProjectPlace();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }

    }
}
