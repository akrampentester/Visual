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
    public partial class Project_Description : Form
    {
        public Project_Description()
        {
            InitializeComponent();
           
            tryAgain.Hide();
            projectPlaceDataGridView.Hide();
        
        }

        private void project_description(object sender, EventArgs e)
        {
            
            tryAgain.Show();
            this.projectPlaceTableAdapter.getDataByName(this.projectPlaceDBDataSet.projectPlace, projectPLACE.Text);
            projectPlaceDataGridView.Show();

        }

        private void try_again(object sender, EventArgs e)
        {
            this.Hide();
            Project_Description another_try = new Project_Description();
            another_try.Closed += (s, args) => this.Close();
            another_try.Show();
        }

        private void exit(object sender, EventArgs e)
        {
            this.Hide();
            informationOfProjectPlace back = new informationOfProjectPlace();
            back.Closed += (s, args) => this.Close();
            back.Show();


        }

        private void Project_Description_Load(object sender, EventArgs e)
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
