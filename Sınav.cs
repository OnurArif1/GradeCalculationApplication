using System;
using System.Collections.Generic;
using System.Text;

namespace example8
{
    public class Sınav : VizeFinalNots, ITotalNots
    {
        public decimal CalculateNot(decimal vize,decimal final)
        {
            var x = 40 / 100;
            var y = (decimal)40 / 100;
            var z = y * 5;
            decimal w = vize * y;
            var a = 60 / 100;
            var b = (decimal)60 / 100;
            var c = b * 1;
            decimal d = final * b;


            
            decimal calculateRatioVize = vize * y;
            decimal calculateRatioFinal = final * b;
            decimal total = calculateRatioVize + calculateRatioFinal;


            return total;



        }
    }
}
