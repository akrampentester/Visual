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
    public partial class AddTraining : Form
    {
        public AddTraining()
        {
            InitializeComponent();
        }

        private void AddTraining_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'projectPlaceDBDataSet.projectPlace' table. You can move, or remove it, as needed.
            this.projectPlaceTableAdapter.Fill(this.projectPlaceDBDataSet.projectPlace);
            // TODO: This line of code loads data into the 'financialProjectDatabaseDataSet.Training_Table' table. You can move, or remove it, as needed.
            this.training_TableTableAdapter.Fill(this.financialProjectDatabaseDataSet.Training_Table);

        }

        private void training_TableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.training_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialProjectDatabaseDataSet);

        }
        string countryName,Training_Name,Date,Description;

        private void AddEmployeebutton_Click(object sender, EventArgs e)
        { // to return home
            this.Hide();
            informationOfProjectPlace Add_Information = new informationOfProjectPlace();
            Add_Information.Closed += (s, args) => this.Close();
            Add_Information.Show();
        }

        decimal Break_cost, Trainer_fees, Material_cost, Hall_reservation, Transports_money, Extra_costs;
        int Number_of_Trainee;
        private void AddTrainingbutton_Click(object sender, EventArgs e)
        { // add Training Information
            countryName = country_NameComboBox.Text;
            Training_Name= TrainingNameTextBoxAdd.Text;
            Number_of_Trainee =int.Parse(NumberOfTraineeTextBoxAdd.Text);
            Break_cost = decimal.Parse(BreakTextBoxAddTraining.Text);
            Trainer_fees = decimal.Parse(TrainerFeesTextBoxAdd.Text);
            Material_cost = decimal.Parse(MaterialTextBoxAddTraining.Text);
            Hall_reservation = decimal.Parse(HallTextBoxAddTraining.Text);
            Transports_money = decimal.Parse(TransportsTextBoxaddTraining.Text);
            Date = dateTimePickerAddTraining.Value.ToString("yyy-MM-dd");
            Extra_costs = decimal.Parse(ExtraTextBoxAddTraining.Text);
            Description = DescriptionTextBoxAddTraining.Text;

            this.training_TableTableAdapter.InsertTraining(countryName,Training_Name,Number_of_Trainee,Break_cost,Trainer_fees,Material_cost,Hall_reservation,Transports_money,Date,Extra_costs,Description);
            this.training_TableTableAdapter.Fill(this.financialProjectDatabaseDataSet.Training_Table);
            this.training_TableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.financialProjectDatabaseDataSet);
            //add Training money
            int id = (int)this.projectPlaceTableAdapter.getIDbyName(countryName);
            decimal oldTrainingExpenses = (decimal)this.projectPlaceTableAdapter.getExpesesOfTraininsByName(countryName);
            decimal newTrainingExpenses = oldTrainingExpenses+(Break_cost * Number_of_Trainee)+Trainer_fees+Material_cost+Hall_reservation+Transports_money+Extra_costs ;
            
            //update expense of project place expenses
            this.projectPlaceTableAdapter.UpdateTrainingExpenses(newTrainingExpenses, id, countryName);
            
            //update number of trainings
            int oldnumber = (int)this.projectPlaceTableAdapter.getNumberOftrainingsByName(countryName);
            int newnumber = oldnumber+1 ;
            this.projectPlaceTableAdapter.UpdateNumberOfTrainings(newnumber, id, countryName);
            this.projectPlaceTableAdapter.Fill(this.projectPlaceDBDataSet.projectPlace);
            this.projectPlaceBindingSource.EndEdit();
            MessageBox.Show("DONE");
        }
    }
}
