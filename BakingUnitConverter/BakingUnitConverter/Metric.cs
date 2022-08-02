using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingUnitConverter
{
    public class Metric : Measurement
    {
        #region Cup/Gram Conversion
        public override double CupToGramConversion(double input)
        {
            return input * 132.25;
        }

        public override double GramToCupConversion(double input)
        {
            return input / 132.25;
        }
        #endregion

        #region Cup/mL Conversion
        public override double CupToMlConversion(double input)
        {
            return input * 250;
        }

        public override double MlToCupConversion(double input)
        {
            return input / 250;
        }
        #endregion

        #region Quart/mL Conversion
        public override double QuartToMlConversion(double input)
        {
            return input * 1136.5226;
        }

        public override double MlToQuartConversion(double input)
        {
            return Math.Round((input / 1136.5226), 4);
        }
        #endregion

        #region Cup/Quart Conversion
        public override double CupToQuartConversion(double input)
        {
            return input * .22;
        }

        public override double QuartToCupConversion(double input)
        {
            return Math.Round((input / .22), 4);
        }
        #endregion

        #region Gram/Quarts Conversion
        public override double GramToQuartConversion(double input)
        {
            return Math.Round((input / 601.2204), 4);
        }

        public override double QuartToGramConversion(double input)
        {
            return input * 601.2204;
        }
        #endregion

        #region Ounces/mL Conversion
        public override double OuncesTomLConversion(double input)
        {
            return input * 53.5908;
        }

        public override double mLToOuncesConversion(double input)
        {
            return Math.Round((input / 53.5908), 4);
        }

        #endregion

        #region Ounces/Oz to Gram
        public override double OuncesToGramConversion(double input)
        {
            return input * 28.3495;
        }

        public override double GramToOuncesConversion(double input)
        {
            return Math.Round((input / 28.3495), 4);
        }

        #endregion

        #region Ounces/Oz to Quarts
        public override double OuncesToQuartConversion(double input)
        {
            return Math.Round((input / 21.2074), 4);
        }

        public override double QuartToOuncesConversion(double input)
        {
            return input * 21.2074;
        }

        #endregion

        #region Ounces/Oz to Cups
        public override double OuncesToCupConversion(double input)
        {
            return Math.Round((input / 4.665), 4);
        }

        public override double CupToOunceConversion(double input)
        {
            return input * 4.665;
        }
        #endregion
    }
}
