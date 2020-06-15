using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TKACIKJoesAutomotive
{
    public partial class Form1 : Form
    {
        double laborLabor;
        double partsCharge = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void calcButton_Click(object sender, EventArgs e) //Calculates everything
        {
            double oilAndLubeCharge, flushCharge, miscCharge, partsAndLaborCharge;

            partsCharge = 0;
                laborLabor = 0;

            oilAndLubeCharge = oilLubeCharges();
            flushCharge = flushCharges();
            miscCharge = miscCharges();
            partsAndLaborCharge = otherCharges();

            totalOutPut(oilAndLubeCharge, flushCharge, miscCharge,partsAndLaborCharge);

        }
        // --------------------
        //Start methods
        //Total charges to go into the total fees 
        private void totalOutPut(double oil, double flush, double misc, double parts)
        {
            const double TAX = 0.06;
            double partcharge = parts;
            double oilcharge = oil;
            double flushcharge = flush;
            double miscCharge = misc;

            double taxParts = 0;
            double total = 0;
            double service = 0;
            //double taxCharge = 0;

            taxParts = partsCharge+partsCharge * TAX;
            total = (partcharge + oilcharge + flushcharge + miscCharge)+(partcharge + oilcharge + flushcharge + miscCharge)*TAX;
            service = oilcharge + flushcharge+miscCharge +laborLabor;


            partsOutput.Text = partsCharge.ToString();
            taxOutput.Text = taxParts.ToString();
            serviceOutput.Text = service.ToString();
            fessOutput.Text = total.ToString();


        }

        //Define oilLubeCharges

        private double oilLubeCharges()
        {
            double oilCharge=0.00, lubeCharge=0.00;
            if (oilCheck.Checked)
                oilCharge = 26.00;
            if (lubeCheck.Checked)
                lubeCharge = 18.00;
            return oilCharge + lubeCharge;
        }
        //radiator and transmission flush

        private double flushCharges()
        {
            double radiatorCharge = 0.00, transmissionCharge = 0.00;
            if (radiatorCheck.Checked)
                radiatorCharge = 30.00;
            if (transmissionCheck.Checked)
                transmissionCharge = 80.00;
            return radiatorCharge + transmissionCharge;
        }
        //Define misc charges

            private double miscCharges()
            {
            double inspectionCharge = 0, mufflerCharge = 0, tireRotation = 0;
            if (inspectCheck.Checked)
            {
                inspectionCharge = 15.00;
            }
           if (mufflerCheck.Checked)
            {
                mufflerCharge = 100.00;
            }
           if (tireCheck.Checked)
            {
                tireRotation = 20.00;
            }
                return mufflerCharge + inspectionCharge+ tireRotation;
            }

        // define OTHER charges method

            private double otherCharges()
        {
            double labor;
            if(double.TryParse(partsInput.Text, out partsCharge))
            {
                if(double.TryParse(laborInput.Text, out labor))
                {
                    laborLabor = labor * 20.00; 
                    //labor input is the hours worked
                }
            }
            return partsCharge + laborLabor;
        }



        //END METHODS -----------------------------------

        private void clearButton_Click(object sender, EventArgs e) //cleares everything.  These methods are required by the problem
        {
            ClearOilLube();
            ClearFlushes();
            ClearMisc();
            ClearOther();
            ClearFees();
        }
        private void quitButton_Click(object sender, EventArgs e) //exits the prgram
        {
            this.Close();
        }

        //clearing methods incoming
        private void ClearOilLube()
        {
            oilCheck.Checked = false;
            lubeCheck.Checked = false;
        }
        private void ClearFlushes()
        {
            transmissionCheck.Checked = false;
            radiatorCheck.Checked = false;
        }
        private void ClearMisc()
        {
            inspectCheck.Checked = false;
            mufflerCheck.Checked = false;
            tireCheck.Checked = false;
        }
        private void ClearOther()
        {
            partsInput.Text = "";
            laborInput.Text = "";
        }
        private void ClearFees()
        {
            serviceOutput.Text = "";
            partsOutput.Text = "";
            taxOutput.Text = "";
            fessOutput.Text = "";
        }

        //EVERYTHING BELOW THIS IS SO I CAN REMEMBER
        //Later note: I found that deleting the objects here and leaving them on the forms caused more issues than I wanted to handle in introductory C#
        //I also found it helped me to be able to scroll down rather than swap to the form to see the names of the controls.
        //I no longer need to do this.






        private void oilCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lubeCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiatorCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void transmissionCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void inspectCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void mufflerCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tireCheck_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void partsInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void laborInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void serviceOutput_Click(object sender, EventArgs e)
        {

        }

        private void partsOutput_Click(object sender, EventArgs e)
        {

        }

        private void taxOutput_Click(object sender, EventArgs e)
        {

        }

        private void fessOutput_Click(object sender, EventArgs e)
        {

        }

       
    }
}
