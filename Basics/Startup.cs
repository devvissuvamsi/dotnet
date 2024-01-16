using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics
{
    public class Startup
    {
        static void Main(string[] args)
        {
            var types = new Types();
            types.TypesMethod();

            var arithmeticClass = new ArithmeticClass();
            arithmeticClass.Add(1, 2, 3);


            /******************* Enums example ******************/
            EnumEample.EnumExample();

            /***** value and referene type example ****/
            Console.WriteLine("***************** value reference type example ****************");
            ValueAndReferenceTypes.ValueAndReferenceTypesExample();
        }
    }
}
