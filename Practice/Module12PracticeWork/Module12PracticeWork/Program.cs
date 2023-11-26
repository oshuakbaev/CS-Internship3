namespace Module12PracticeWork
{

    class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.Propertychanged += MyClass_Propertychanged;

            myClass.MyProperty = "New Value";
            myClass.MyProperty = "New Value3";
        }

        private static void MyClass_Propertychanged(object sender, PropertyEventArgs e)
        {
            Console.WriteLine("Property changed: " + e.PropertyName);
        }

    }

}
