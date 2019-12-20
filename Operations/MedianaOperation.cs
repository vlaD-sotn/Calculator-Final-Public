using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    class MedianaOperation : IOperations
    {
        public string Name { get { return "Mediana"; } }

        public double[] Execute(double arg, double[] arr)
        {
            double[] sum = { 0 };
            for (int i = 0; i < arr.Length; i++)
            {
                sum[0] += arr[i];
            }

            sum[0] = sum[0] / arr.Length;

            return sum;
        }
    }
}
