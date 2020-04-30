using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RGIT_AssetDepreciationApp
{
    public partial class frmRGITAnnualAssetDepreciationApp : Form
    {


        public frmRGITAnnualAssetDepreciationApp()
        {
            InitializeComponent();


        }



        private void txtAssetCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }
        }

        private void txtSalvageValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8)
            {
                e.Handled = true;
            }

        }

        private void btnDepreciationSchedules_Click(object sender, EventArgs e)
        {
            double dAssetCost = Double.Parse(txtAssetCost.Text);
            double dSalvageValue = Double.Parse(txtSalvageValue.Text);
            int iUsefulLife = int.Parse(cmbUsefulLife.Text);

            double dRatePercentage = 0;
            double dDepExpense = 0;
            double dAccDepr = 0;
            double dBookValue = 0;
 
            lstDDB.Items.Add("Year        Depreciation");
            lstSYD.Items.Add("Year        Depreciation");


            CalculateDDB(dAssetCost,dSalvageValue,iUsefulLife,dRatePercentage,dDepExpense, dAccDepr, dBookValue);
            CalculateSYD(dAssetCost, dSalvageValue, iUsefulLife, dRatePercentage, dDepExpense, dAccDepr, dBookValue);

        }

        private void CalculateSYD(double dAssetCost, double dSalvageValue, int iUsefulLife, double dRatePercentage, double dDepExpense, double dAccDepr, double dBookValue)
        {
            int iUseful01 = iUsefulLife;
            int iUseful02 = iUsefulLife;

            double dSumOfYearDig;
            double dDepreBase = dAssetCost - dSalvageValue;

            double dFractionDenominator = 0;

            for (int i = iUseful01; i > 0; i--)
            {
                dFractionDenominator = dFractionDenominator + i;
            }

            for (int i = 0; i < iUseful02; i++)
            {
                dSumOfYearDig = ((iUseful02-i) / dFractionDenominator) * dDepreBase;
                lstSYD.Items.Add((i+1).ToString() + "             " + Math.Round(dSumOfYearDig, 2).ToString("#,###.##"));
            }



        }

        private void CalculateDDB(double dAssetCost, double dSalvageValue, int iUsefulLife, double dRatePercentage, double dDepExpense, double dAccDepr, double dBookValue)
        {
            for (int i = 1; i <= iUsefulLife; i++)
            {
                dRatePercentage = Double.Parse((((dAssetCost / iUsefulLife) / dAssetCost) * 2).ToString());
                dDepExpense = dAssetCost * dRatePercentage;

                if (dSalvageValue > dDepExpense)
                {
                    return;
                }
                else
                {
                    dAccDepr = +dDepExpense;
                    dBookValue = dAssetCost - dAccDepr;

                    lstDDB.Items.Add(i.ToString() + "             " + Math.Round(dDepExpense, 2).ToString("#,###.##"));
                    dAssetCost = Double.Parse(dBookValue.ToString());
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
