using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_sharp_features.Delegates
{
    public class WeirdCalculator
    {
        public delegate int ProcessTwoNumbersDelegate(int a, int b);

        public ProcessTwoNumbersDelegate processNumbersDelegate;
       
        public string ProcessNumbersWithMsg(int a, int b)
        {
            return ProcessNumbersWithMsg(a, b, processNumbersDelegate);
        }

        private string ProcessNumbersWithMsg(int a, int b, ProcessTwoNumbersDelegate processNumbersDelegate)
        {
            if (processNumbersDelegate == null)
                return "Press Add/Subtract first!";

            return "Weird msg! " + processNumbersDelegate(a, b);
        }
    }
}
