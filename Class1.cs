using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Tihtoan
{
    public class Class1
    {
        private int a, b;
        public  Class1(int a, int b)
        {
            this.a =a;
            this .b =b;
        }
        public int Execute(string Operation)
        {
            int result = 0;
            switch(Operation)
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
