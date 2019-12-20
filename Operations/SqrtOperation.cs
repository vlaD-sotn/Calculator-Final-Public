using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class SqrtOperation : IOperations
    {
        public string Name { get { return "Sqrt"; } }

        public double[] Execute(double arg, double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Sqrt(arr[i]);
            }

            return arr;
        }
    }
}
