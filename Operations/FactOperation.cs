using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class FactOperation : IOperations
    {
        public string Name { get { return "Fact"; } }

        public double[] Execute(double arg, double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Fact(Convert.ToInt32(arr[i]));
            }

            return arr;
        }

        private int Fact(int number)
        {
            if (number < 0)
            {
                return 0;
            }
            if (number == 0)
            {
                return 1;
            }
            else
            {
                return number * Fact(number - 1);
            }
        }
    }
}
