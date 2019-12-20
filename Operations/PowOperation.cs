using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class PowOperation : IOperations
    {
        public string Name { get { return "Squaring"; } }

        public double[] Execute(double arg, double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Pow(arr[i], 2);
            }

            return arr;
        }
    }
}
