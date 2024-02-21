using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProject
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnLottoMax_Click(object sender, EventArgs e)
        {
            LottoMax obj = new LottoMax();

            obj.ShowDialog();
        }

        private void btnLotto649_Click(object sender, EventArgs e)
        {
            Lotto649 obj = new Lotto649();

            obj.ShowDialog();
        }

        private void btnMoneyExchange_Click(object sender, EventArgs e)
        {
            MoneyExchange obj = new MoneyExchange();

            obj.ShowDialog();
        }

        private void btnTemperatureConverter_Click(object sender, EventArgs e)
        {
            TemperatureConverter obj = new TemperatureConverter();

            obj.ShowDialog();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            SimpleCalc obj = new SimpleCalc();

            obj.ShowDialog();
        }

        private void btnIPvalidator_Click(object sender, EventArgs e)
        {
            IP4validator obj = new IP4validator();

            obj.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the Dashboard? ", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
