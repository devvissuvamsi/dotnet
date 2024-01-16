namespace Basics
{
    public class EnumEample
    {
        public static void EnumExample()
        {
            var shippingMethod = ShippingMethod.BlueDart;

            var shippingMethodNumber = (int)shippingMethod; // from enum to integer

            Console.WriteLine(shippingMethodNumber);

            var shippingNumber = 2;

            Console.WriteLine((ShippingMethod)shippingNumber);

            var shippingMethodString = "Speedpost";

            var enumShippingMethod = (ShippingMethod)Enum.Parse(typeof(ShippingMethod), shippingMethodString);

            Console.WriteLine((int)enumShippingMethod);
        }
    }
}
