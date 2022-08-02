using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingUnitConverter
{
    internal class UnitedStates : Measurement
    {
        // Special thanks to https://www.thecalculatorsite.com/cooking/cooking-calculator.php to ensure my calculations is accurate.

        #region Cup/Gram Conversion
        public override double CupToGramConversion(double input)
        {
            return input * 125.1552;
        }

        public override double GramToCupConversion(double input)
        {
            return Math.Round((input / 125.1552), 4);
        }
        #endregion

        #region Cup/mL Conversion
        public override double CupToMlConversion(double input)
        {
            return input * 236.5882;
        }

        public override double MlToCupConversion(double input)
        {
            return Math.Round((input / 236.5882), 4);
        }
        #endregion

        #region Quart/mL Conversion
        public override double QuartToMlConversion(double input)
        {
            return input * 946.3529;
        }

        public override double MlToQuartConversion(double input)
        {
            return Math.Round((input / 946.3529), 4);
        }
        #endregion

        #region Cup/Quart Conversion
        public override double CupToQuartConversion(double input)
        {
            return input * .25;
        }

        public override double QuartToCupConversion(double input)
        {
            return Math.Round((input / .25), 4);
        }
        #endregion

        #region Gram/Quarts Conversion
        public override double GramToQuartConversion(double input)
        {
            return Math.Round((input / 500.6207), 4);
        }

        public override double QuartToGramConversion(double input)
        {
            return input * 500.6207;
        }
        #endregion

        #region Oz/mL Conversion
        public override double OuncesTomLConversion(double input)
        {
            return input * 53.5908;
        }

        public override double mLToOuncesConversion(double input)
        {
            return Math.Round((input / 53.5908), 4);
        }

        #endregion

        #region Oz/Gram Conversion
        public override double OuncesToGramConversion(double input)
        {
            return input * 28.3495;
        }

        public override double GramToOuncesConversion(double input)
        {
            return Math.Round((input / 28.3495), 4);
        }

        #endregion

        #region Oz/Quart Conversion
        public override double OuncesToQuartConversion(double input)
        {
            return Math.Round((input / 17.6589), 4);
        }

        public override double QuartToOuncesConversion(double input)
        {
            return input * 17.6589;
        }

        #endregion

        #region Oz/Cup Conversion
        public override double OuncesToCupConversion(double input)
        {
            return input * 4.4147;
        }

        public override double CupToOunceConversion(double input)
        {
            return Math.Round((input / 4.4147), 4);
        }
        #endregion
    }
}
