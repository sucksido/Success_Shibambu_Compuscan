using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Compuscan
{
    class Calculator
    {
        public string expression { get; set; }

        public Calculator(string expression)
        {
            this.expression = expression;
        }

        public string getTotal()
        {
            string line = expression;
            string[] split = line.Split(new char[] { ',' });
            string toBeCalculated = split[0];
            Queue<String> valuesQueue = new Queue<String>();
            Queue<String> operatorQueue = new Queue<String>();

            Regex regex = new Regex(@"[\/\+\-\*]");
            Match match = regex.Match(toBeCalculated);

            var startWithOperator = false;
            var firstChar = "";
            if (match.Index == 0)
            {
                firstChar = toBeCalculated.Substring(0, 1);
                toBeCalculated = toBeCalculated.Substring(1);
                match = regex.Match(toBeCalculated);
                startWithOperator = true;
            }

            while (match.Length != 0)
            {
                operatorQueue.Enqueue(match.ToString());
                if (startWithOperator)
                {
                    valuesQueue.Enqueue(firstChar + toBeCalculated.Substring(0, match.Index));
                    startWithOperator = false;
                }
                else
                {
                    valuesQueue.Enqueue(toBeCalculated.Substring(0, match.Index));
                }
                toBeCalculated = toBeCalculated.Substring(match.Index + 1);
                match = regex.Match(toBeCalculated);
            }
            valuesQueue.Enqueue(toBeCalculated);
            double notANumber = 0;
            double totalNumber = 0;
            string totalString = "";
            var firstValue = valuesQueue.Dequeue();
            if (Double.TryParse(firstValue, out notANumber))
            {
                totalNumber = double.Parse(firstValue);
                while (valuesQueue.Count != 0)
                {
                    var mOperator = operatorQueue.Dequeue();
                    switch (mOperator)
                    {
                        case "+":
                            totalNumber += double.Parse(valuesQueue.Dequeue());
                            break;
                        case "/":
                            totalNumber /= double.Parse(valuesQueue.Dequeue());
                            break;
                        case "*":
                            totalNumber *= double.Parse(valuesQueue.Dequeue());
                            break;
                        case "-":
                            totalNumber -= double.Parse(valuesQueue.Dequeue());
                            break;

                    }
                }
            }
            else
            {
                totalString = firstValue;
                while (valuesQueue.Count != 0)
                {
                    var mOperator = operatorQueue.Dequeue();
                    switch (mOperator)
                    {
                        case "+":
                            totalString += valuesQueue.Dequeue();
                            break;
                    }
                }
            }
            return totalString == "" ? totalNumber.ToString() : totalString;
        }
    }
}
