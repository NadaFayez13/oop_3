namespace oop_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Theoretical Questions - q1 
            // a)  What is the difference between Method Overloading and Method Overriding?
            // Method Overloading is when multiple methods in the same class have the same name but different parameters. It allows class to have multiple methods that perform similar functions but with different input.
            // Method Overriding is when derived class provides specific implementation of method that is already defined in its base class. The method in the derived class has the same name, return type, and parameters as the method in the base class.

            //b)  What is the difference between Static Binding and Dynamic Binding?
            // Static Binding occurs at compile time, where the method to be called is determined based on the reference type. It's used with method overloading and static methods.
            // Dynamic Binding occurs at runtime, where the method to be called is determined based on the actual object type. It;s used with method overriding.
            #endregion


            #region practical 9.d 9.e 9.f
            DeliveryAddress addr1 = new DeliveryAddress("12 Street", "Alex", '1');
            StandardShipment std = new StandardShipment("01", "Books", 3.0m, 50.0m, addr1);

            DeliveryAddress addr2 = new DeliveryAddress("456 Street", "Cairo", '2');
            ExpressShipment exp = new ExpressShipment("02", "Electronics", 2.0m, 100.0m, addr2, 30.0m);

            DeliveryAddress addr3 = new DeliveryAddress("789 Street", "Aswan", '3');
            InternationalShipment inter = new InternationalShipment("03", "Documents", 1.5m, 150.0m, addr3, "egy", 70.0m);
            #endregion
        }
    }
}
