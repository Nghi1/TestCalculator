using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _151901403_VuThanhNghi
{
    public class Calculator
    {
        private float a,b ;
            public Calculator(float a, float b)
        {
            this.a = a;
            this.b = b;
        }
        public float Exectute(string operation)
        {
            float result = 0;
            switch(operation)
            {
                case "+":
                    result = a + b;
                    break;
                case "-":
                    result = a - b;
                    break;
                case "*":
                    result = a * b;
                    break;
                case "/":
                    result = a / b;
                    break;            
            }
            return result;
        }
    }


}
