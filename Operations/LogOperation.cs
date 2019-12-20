using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class LogOperation : IOperations
    {
        public string Name { get { return "Log"; } }

        public double[] Execute(double arg, double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = Math.Log(arr[i], arg);
            }

            return arr;
        }
    }
}
