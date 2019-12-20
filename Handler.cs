using Calculator.Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Handler
    {
        IOperations operations;
        double[] arr;
        Invoker Invoker;
        double argument;

        public void GetArgument(string str)
        {
            argument = Convert.ToDouble(str);
        }

        public void CreateInvoker()
        {
            Invoker = new Invoker(arr);
        }

        public void RecognizeOperations(string str)
        {
            switch (str)
            {
                case "+":
                    operations = new PlusOperation();
                    break;
                case "-":
                    operations = new MinusOperation();
                    break;
                case "*":
                    operations = new MultOperation();
                    break;
                case "/":
                    operations = new DivOperation();
                    break;
                case "!":
                    operations = new FactOperation();
                    break;
                case "Sqrt(2)":
                    operations = new SqrtOperation();
                    break;
                case "Sqrt()":
                    operations = new CertainSqrtOperation();
                    break;
                case "Log":
                    operations = new LogOperation();
                    break;
                case "Mediana":
                    operations = new MedianaOperation();
                    break;
                case "Pow(2)":
                    operations = new PowOperation();
                    break;
                case "Pow()":
                    operations = new CertainPowOperation();
                    break;
                default:
                    break;
            }
        }

        public void RecognizeArray(string str)
        {
            string[] arrayOfStrings = str.Split(',');
            arr = new double[arrayOfStrings.Length];

            for(int i = 0; i < arrayOfStrings.Length; i++)
            {
                arr[i] = Convert.ToDouble(arrayOfStrings[i].Trim());
            }
        }

        public double[] Result()
        {
            Invoker.AddOperation(operations);
            return Invoker.DoOperation(argument);
        }
    }
}
