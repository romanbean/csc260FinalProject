using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BakingUnitConverter
{
    public abstract class Measurement
    {
        public abstract double CupToGramConversion(double input);
        public abstract double GramToCupConversion(double input);
        public abstract double CupToMlConversion(double input);
        public abstract double MlToCupConversion(double input);
        public abstract double QuartToMlConversion(double input);
        public abstract double MlToQuartConversion(double input);
        public abstract double CupToQuartConversion(double input);
        public abstract double QuartToCupConversion(double input);
        public abstract double GramToQuartConversion(double input);
        public abstract double QuartToGramConversion(double input);
        public abstract double OuncesTomLConversion(double input);
        public abstract double mLToOuncesConversion(double input);
        public abstract double OuncesToGramConversion(double input);
        public abstract double GramToOuncesConversion(double input);
        public abstract double OuncesToQuartConversion(double input);
        public abstract double QuartToOuncesConversion(double input);
        public abstract double OuncesToCupConversion(double input);
        public abstract double CupToOunceConversion(double input);
    }
}
