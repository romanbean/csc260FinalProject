using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Documents;
using System.Threading.Tasks;

namespace BakingUnitConverter
{
    /*
     * This class checks the recipes the user provide
     */
    internal class Recipe
    {
        // Measurements from two different systems (some is similar but some is noticeably different)
        UnitedStates us = new UnitedStates();
        Metric m = new Metric();

        // DRY Method
        // Don't Repeat Yourself
        // Declaring those variables is easier to maintain (I believe)
        public string gram = "g";
        public string cup = "cup";
        public string cups = "cups";
        public string oz = "oz";
        public string ounces = "ounces";
        public string quart = "quart";
        public string quarts = "quarts";
        public string mL = "mL";

        // TODO: Add an error messagebox if there is nothing to replace
        public void QuickReplace(RichTextBox rtb, TextBox tb_prevNum, TextBox tb_newNum, ComboBox cb_prevUnit, ComboBox cb_newUnit)
        {
            string previousValue = tb_prevNum.Text + " " + cb_prevUnit.Text;
            string newValue = tb_newNum.Text + " " + cb_newUnit.Text;

            if (rtb.Text.Contains(previousValue))
            {
                rtb.Text = rtb.Text.Replace(previousValue, newValue);
            } else
            {
                MessageBox.Show("Nothing to Convert", "WARNING: Value doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }

        public void UnitConversion(TextBox tb_prevNum, ComboBox cb_prevUnit, ComboBox cb_NewUnit, TextBox tb_newNum, RadioButton rb_Metric, RadioButton rb_US)
        {
            double prevNum = ValidateNumber(tb_prevNum.Text);
            
            if (rb_Metric.Checked)
            {
                ConvertMetricUnits(cb_prevUnit.Text, cb_NewUnit.Text, prevNum, tb_newNum);
            }
            else if (rb_US.Checked)
            {
                ConvertUSUnits(cb_prevUnit.Text, cb_NewUnit.Text, prevNum, tb_newNum);
            } else
            {
                MessageBox.Show("No System wasn't checked", "WARNING: No System Checked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private double ValidateNumber(string tb_prevNum)
        {
            double prevNum;

            bool isNumber = Double.TryParse(tb_prevNum, out prevNum);
            if (isNumber)
            {
                return prevNum;

            }
            else if (!isNumber)
            {
                MessageBox.Show("The number you entered is not valid. Try again.", "ERROR: Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return 0;
        }
        private string ConvertMetricUnits(string prevUnit, string newUnit, double prevNum, TextBox tb)
        {
            string result = "";

            switch (prevUnit)
            {
                case "cup":
                case "cups":
                    if (newUnit == gram)
                    {
                        result = Convert.ToString(m.CupToGramConversion(prevNum));
                    }
                    else if (newUnit == mL)
                    {
                        result = Convert.ToString(m.CupToMlConversion(prevNum));
                    }
                    else if (newUnit == quart || newUnit == quarts)
                    {
                        result = Convert.ToString(m.CupToQuartConversion(prevNum));
                    }
                    else if (newUnit == oz || newUnit == ounces)
                    {
                        result = Convert.ToString(m.CupToOunceConversion(prevNum));
                    }
                    break;
                case "g":
                    if (newUnit == cup || newUnit == cups)
                    {
                        result = Convert.ToString(m.GramToCupConversion(prevNum));
                    }
                    else if (newUnit == mL)
                    {
                        result = tb.Text;
                    }
                    else if (newUnit == quart || newUnit == quarts)
                    {
                        result = Convert.ToString(m.GramToQuartConversion(prevNum));
                    }
                    else if (newUnit == oz || newUnit == ounces)
                    {
                        result = Convert.ToString(m.GramToOuncesConversion(prevNum));
                    }
                    break;
                case "mL":
                    if (newUnit == cup || newUnit == cups)
                    {
                        result = Convert.ToString(m.MlToCupConversion(prevNum));
                    }
                    else if (newUnit == gram)
                    {
                        result = tb.Text;
                    }
                    else if (newUnit == quart || newUnit == quarts)
                    {
                        result = Convert.ToString(m.MlToQuartConversion(prevNum));
                    }
                    else if (newUnit == oz || newUnit == ounces)
                    {
                        result = Convert.ToString(m.mLToOuncesConversion(prevNum));
                    }
                    break;
                case "quart":
                case "quarts":
                    if (newUnit == cup || newUnit == cups)
                    {
                        result = Convert.ToString(m.QuartToCupConversion(prevNum));
                    }
                    else if (newUnit == mL)
                    {
                        result = Convert.ToString(m.QuartToMlConversion(prevNum));
                    }
                    else if (newUnit == gram)
                    {
                        result = Convert.ToString(m.QuartToGramConversion(prevNum));
                    }
                    else if (newUnit == oz || newUnit == ounces)
                    {
                        result = Convert.ToString(m.QuartToOuncesConversion(prevNum));
                    }
                    break;
                case "oz":
                case "ounces":
                    if (newUnit == cup || newUnit == cups)
                    {
                        result = Convert.ToString(m.OuncesToCupConversion(prevNum));
                    }
                    else if (newUnit == mL)
                    {
                        result = Convert.ToString(m.OuncesTomLConversion(prevNum));
                    }
                    else if (newUnit == gram)
                    {
                        result = Convert.ToString(m.OuncesToGramConversion(prevNum));
                    }
                    else if (newUnit == quart || newUnit == quarts)
                    {
                        result = Convert.ToString(m.OuncesToQuartConversion(prevNum));
                    }
                    break;
            }

            return tb.Text = result;
        }
        private string ConvertUSUnits(string prevUnit, string newUnit, double prevNum, TextBox tb)
        {
            string result = "" + prevNum;

            switch (prevUnit)
            {
                case "cup":
                case "cups":
                    if (newUnit == gram)
                    {
                        result = Convert.ToString(us.CupToGramConversion(prevNum));
                    }
                    else if (newUnit == mL)
                    {
                        result = Convert.ToString(us.CupToMlConversion(prevNum));
                    }
                    else if (newUnit == quart || newUnit == quarts)
                    {
                        result = Convert.ToString(us.CupToQuartConversion(prevNum));
                    }
                    else if (newUnit == oz || newUnit == ounces)
                    {
                        result = Convert.ToString(m.CupToOunceConversion(prevNum));
                    }
                    break;
                case "g":
                    if (newUnit == cup || newUnit == cups)
                    {
                        result = Convert.ToString(us.GramToCupConversion(prevNum));
                    }
                    else if (newUnit == mL)
                    {
                        result = tb.Text;
                    }
                    else if (newUnit == quart || newUnit == quarts)
                    {
                        result = Convert.ToString(us.GramToQuartConversion(prevNum));
                    }
                    else if (newUnit == oz || newUnit == ounces)
                    {
                        result = Convert.ToString(us.GramToOuncesConversion(prevNum));
                    }
                    break;
                case "mL":
                    if (newUnit == cup || newUnit == cups)
                    {
                        result = Convert.ToString(us.MlToCupConversion(prevNum));
                    }
                    else if (newUnit == gram)
                    {
                        result = tb.Text;
                    }
                    else if (newUnit == quart || newUnit == quarts)
                    {
                        result = Convert.ToString(us.MlToQuartConversion(prevNum));
                    }
                    else if (newUnit == oz || newUnit == ounces)
                    {
                        result = Convert.ToString(us.mLToOuncesConversion(prevNum));
                    }
                    break;
                case "quart":
                case "quarts":
                    if (newUnit == cup || newUnit == cups)
                    {
                        result = Convert.ToString(us.QuartToCupConversion(prevNum));
                    }
                    else if (newUnit == mL)
                    {
                        result = Convert.ToString(us.QuartToMlConversion(prevNum));
                    }
                    else if (newUnit == gram)
                    {
                        result = Convert.ToString(us.QuartToGramConversion(prevNum));
                    }
                    else if (newUnit == oz || newUnit == ounces)
                    {
                        result = Convert.ToString(us.QuartToOuncesConversion(prevNum));
                    }
                    break;
                case "oz":
                case "ounces":
                    if (newUnit == cup || newUnit == cups)
                    {
                        result = Convert.ToString(us.OuncesToCupConversion(prevNum));
                    }
                    else if (newUnit == mL)
                    {
                        result = Convert.ToString(us.OuncesTomLConversion(prevNum));
                    }
                    else if (newUnit == gram)
                    {
                        result = Convert.ToString(us.OuncesToGramConversion(prevNum));
                    }
                    else if (newUnit == quart || newUnit == quarts)
                    {
                        result = Convert.ToString(us.OuncesToQuartConversion(prevNum));
                    }
                    break;
            }

            return tb.Text = result;
        }
    }
}
