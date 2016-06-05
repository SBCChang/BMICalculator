
using System.ComponentModel;

namespace BMICalculator
{
    public enum BMIRank
    {
        [Description("適中")]
        middle = 0,

        [Description("太瘦")]
        thin = 1,

        [Description("太胖")]
        heavy = 2
    }

    public enum GenderType
    {
        Man = 0,
        Woman = 1
    }
}
