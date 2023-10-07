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
    public partial class editOfProjectPlace : Form
    {
        public editOfProjectPlace()
        {
            InitializeComponent();
        }

        private void projectPlaceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.projectPlaceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectPlaceDBDataSet);

        }

        private void editOfProjectPlace_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectPlaceDBDataSet.projectPlace' table. You can move, or remove it, as needed.
            this.projectPlaceTableAdapter.Fill(this.projectPlaceDBDataSet.projectPlace);

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectProjectPlace selectBack = new selectProjectPlace();
            selectBack.Closed += (s, args) => this.Close();
            selectBack.Show();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.projectPlaceTableAdapter.searchByNameProject(this.projectPlaceDBDataSet.projectPlace, searchTextBox.Text);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {//edit project place data
            //get data from user
            string nameProject = this.nameProjectComboBox.Text;
            int id = (int)this.projectPlaceTableAdapter.getIDbyName(nameProject);
            int numberOfEmoloyee = (int)employeeNumericUpDown.Value;
            int numberOfTraining = (int)trainingNumericUpDown.Value;
            decimal budget = budgetNumericUpDown.Value;
            decimal expensesTraining = expensesThingsNumericUpDown.Value;
            decimal expensesExtraThings = expensesThingsNumericUpDown.Value;
            decimal expensesOfEmployee = expensesEmployeeNumericUpDown.Value;

            nameProject = nameProject.ToString();
            //update data base information
            this.projectPlaceTableAdapter.UpdateDataProjectPlace(expensesExtraThings, numberOfEmoloyee, numberOfTraining, budget, expensesTraining, id, nameProject);
            this.projectPlaceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projectPlaceDBDataSet);
            this.projectPlaceTableAdapter.Fill(this.projectPlaceDBDataSet.projectPlace);
            MessageBox.Show("DONE");
        }

    }
}
