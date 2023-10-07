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
    public partial class selectProjectPlace : Form
    {
        public selectProjectPlace()
        {
            InitializeComponent();
        }

        private void buttonSelectIdam_Click(object sender, EventArgs e)
        {
            this.Hide();
            informationOfProjectPlace selectIdam = new informationOfProjectPlace();
            selectIdam.Closed += (s, args) => this.Close();
             selectIdam.Show();
        }

        private void buttonSelectTowa_Click(object sender, EventArgs e)
        {
            this.Hide();
            informationOfProjectPlace selectTowa = new informationOfProjectPlace();
            selectTowa.Closed += (s, args) => this.Close(); 
            selectTowa.Show();
        }

        private void buttonSelectAbwan_Click(object sender, EventArgs e)
        {
            this.Hide();
            informationOfProjectPlace selectAbwan = new informationOfProjectPlace();
            selectAbwan.Closed += (s, args) => this.Close();
            selectAbwan.Show();
        }

        private void buttonSelectBardnoha_Click(object sender, EventArgs e)
        {
            this.Hide();
            informationOfProjectPlace selectBardnoha = new informationOfProjectPlace();
            selectBardnoha.Closed += (s, args) => this.Close();
            selectBardnoha.Show();
        }

        private void buttonSelectMansafis_Click(object sender, EventArgs e)
        {
            this.Hide();
            informationOfProjectPlace selectMansafis = new informationOfProjectPlace();
            selectMansafis.Closed += (s, args) => this.Close();
            selectMansafis.Show();
        }

        private void buttonAddProjectPlace_Click(object sender, EventArgs e)
        {
            this.Hide();
            addProjectPlace selectAddNeWProject = new addProjectPlace();
            selectAddNeWProject.Closed += (s, args) => this.Close();
            selectAddNeWProject.Show();
        }

        private void buttonEditProjectPlace_Click(object sender, EventArgs e)
        {
           this.Hide();
            editOfProjectPlace selectEditProject = new editOfProjectPlace();
            selectEditProject.Closed += (s, args) => this.Close();
            selectEditProject.Show();
           
        }

        private void buttonAddComingMoney_Click(object sender, EventArgs e)
        {
            this.Hide();
            addComingMoney selectAddComing = new addComingMoney();
            selectAddComing.Closed += (s, args) => this.Close();
            selectAddComing.Show();
        }

    }
}
