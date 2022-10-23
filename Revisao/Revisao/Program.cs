using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao
{
    public class A
    {
        private int _value = 10;

        public class B : A
        {
            public int GetValue()
            {
                return _value;
            }
        }
    }

    public class C : A
    {
           public int GetValue()
          {
               return _value;
           }
    }
    public class AcessExample
    {
        public static void Main(string[] args)
        
        {
            var b = new A.B();
            Console.WriteLine(b.GetValue());
        }
    }
}
