using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    internal class Types
    {
        public void TypesMethod()
        {
            byte b = 10; // 0 - 255
            short s = 100;
            int x = 10;
            long l = 2L;
            const float Pi = 3.14f;
            double y = 100.45d;
            decimal m = 2m;
            char c = 'H';
            bool bul = false;
            string str = "vamsi";

            int i = 1;
            float f = i; // implicit type conversion

            int i1 = 1;
            // byte b1 = i1; // compile time error due to data loss
            byte b1 = (byte)i1; // explict type conversion or casting

            string s1 = "1";
            // int i = (int)s // won't complie since string and int are not compatible
            int i2 = Convert.ToInt32(s1);
            int i3 = int.Parse(s1);

            Console.WriteLine("My First Program");
            Console.WriteLine("{0} {1}",byte.MinValue,byte.MaxValue);


            // overflow

            checked
            {
                byte number = 255;

            }
        }
    }
}
