using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class CurrencyValues
    {
        Double usdValue = 0.0;
        Double brlValue = 1.0;
        Double eurValue = 0.0;
        Double cnhValue = 0.0;

        public double UsdValue { get => usdValue; set => usdValue = value; }
        public double BrlValue { get => brlValue; set => brlValue = value; }
        public double EurValue { get => eurValue; set => eurValue = value; }
        public double CnhValue { get => cnhValue; set => cnhValue = value; }
    }
}
