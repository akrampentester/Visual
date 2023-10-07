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
    public partial class addComingMoney : Form
    {
        float money_amount, value_dolar;
        
        
        public addComingMoney()
        {
            InitializeComponent();
            value_dolar = 1;
        }

        private void textBoxValueMoney_TextChanged(object sender, EventArgs e)
        {
            money_amount = float.Parse(textBoxValueMoney.Text);

        }
        private void textBox2_value_dolar_TextChanged(object sender, EventArgs e)
        {
            value_dolar = float.Parse(textBox2_value_dolar.Text);

        }

        private void addMoney_Click(object sender, EventArgs e)
        {
            money_amount = money_amount * value_dolar;
            MessageBox.Show(money_amount.ToString());
            //add money to database
            this.specifiedMoneyTableAdapter.InsertTotalMoney((double)money_amount);
            this.specifiedMoneyTableAdapter.Fill(this.total_moneyDataSet.specifiedMoney);
            this.specifiedMoneyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.total_moneyDataSet);

            
        }

        private void specifiedMoneyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.specifiedMoneyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.total_moneyDataSet);

        }

        private void addComingMoney_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'total_moneyDataSet.specifiedMoney' table. You can move, or remove it, as needed.
            this.specifiedMoneyTableAdapter.Fill(this.total_moneyDataSet.specifiedMoney);

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            selectProjectPlace back = new selectProjectPlace();
            back.Closed += (s, args) => this.Close();
            back.Show();
        }

        private void button_dolar_Click(object sender, EventArgs e)
        {
            textBox2_value_dolar.Show();
            enterValue.Show();
        }

      
    }
}
