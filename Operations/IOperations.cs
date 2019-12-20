using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Operations
{
    public interface IOperations
    {
        string Name { get; }
        double[] Execute(double arg, double[] arr);
    }
}
