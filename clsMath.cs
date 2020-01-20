using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JasickiMidterm
{
    class clsMath
    {
        Double x;

        private String a;
        public String A //primary holder
        {
            get 
            {
                return a;
            }
            set
            {
                if (A == ".")
                {
                    a = value;
                }
                else
                {                   
                    Double N;
                    bool result = Double.TryParse(value, out N); // Validation of data, testing for numbers.
                    if (result)
                    {
                        a = value;
                    }
                    else
                    {
                        a = "Error";
                    }
      
                }

            }
        }

        private String b;
        public String B //secondary holder
        {
            get
            {
                return b;
            }
            set
            {
                b = value;
            }
        }
        private string Op;
        public string Operation // operator holder
        {
            get
            {
                return Op;
            }
            set
            {
                Op = value;
            }
        }
        public Double nMath(Double value1, Double value2, string Op)// does the math
        {
            
            switch (Op)
            {
                case "+":
                    return value1 + value2;
                case "-":
                    return value2 - value1;
                case "x":
                    return value1 * value2;                    
                case "/":
                    return x = value2 / value1;
                //try
                //{
                //    x = value2 / value1;
                //}
                //catch
                //{
                //    x = value2 / value1;
                //}
                //finally
                //{
                //}
                //if (double.IsInfinity(x))
                //{
                //    return x;
                //}
                //return x;
                default:
                    return 0;
            }
        }
    }
}
