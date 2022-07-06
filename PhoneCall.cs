using System;
using static System.Console;

namespace PhoneCall
{
    class Program
    {
        private static double CalcPhoneCallPrice(int mintutes, double rate)
        {
            const double BASE_FEE = 0.25;
            double callFee;
            callFee = BASE_FEE + mintutes * rate;
            return callFee;
        }
        static void Main()
        {
            int[] callLength = { 2, 5 };
            double[] rates = { 0.03, 0.12 };
            double priceOfCall;
            WriteLine("{0, 10}{1, 10}{2, 10}", "Minutes", "Rate", "Price");
            for(int x = 0; x < callLength.Length;++x)
                for(int y = 0; y < rates.Length; ++y)
                {
                    priceOfCall = CalcPhoneCallPrice(callLength[x], rates[y]);
                    WriteLine("{0, 10}{1, 10}{2, 10}", callLength[x], rates[y], priceOfCall.ToString("C"));
                }
        }

    }

}
