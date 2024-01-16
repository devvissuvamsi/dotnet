using System.Security.Cryptography;

namespace Basics
{
    public class ValueAndReferenceTypes
    {

        public static void ValueAndReferenceTypesExample()
        {
            /* value type example */
            var number = 1;
            Increment(number);
            Console.WriteLine(number);

            /* reference type example */
            var person = new Person() { Age = 20 };
            MakeOld(person);
            Console.WriteLine(person.Age);

        }

        static void Increment(int number)
        {
            number += 1;
        }

        static void MakeOld(Person person)
        {
            person.Age += 20;
        }
    }

    public class Person
    {
        public int Age { get; set; } = 10;
    }
}
