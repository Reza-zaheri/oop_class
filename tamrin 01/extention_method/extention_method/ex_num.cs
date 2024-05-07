using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extention_method
{
    public static class ex_num
    {
        public static string GetSum(this number n)
        {
            int sum = n.num1 + n.num2;
            return sum.ToString();
        }
        public static string minus(this number n)
        {
            int sum = n.num1 - n.num2;
            return sum.ToString();
        }
        public static string multi(this number n)
        {
            int sum = n.num1 * n.num2;
            return sum.ToString();
        }
        public static string divid(this number n)
        {
            int sum = n.num1 / n.num2;
            return sum.ToString();
        }
    }
}
