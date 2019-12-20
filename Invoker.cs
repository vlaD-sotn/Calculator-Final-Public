using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Invoker
    {
        public List<IOperations> list;
        private double[] Arr;
        public Invoker(double[] arr)
        {
            this.Arr = arr;
            list = new List<IOperations>();
        }

        public void AddOperation(IOperations operations)
        {
            list.Add(operations);
        }

        public double[] DoOperation(double arg)
        {
            return list.Last().Execute(arg, Arr);
        }
    }
}
