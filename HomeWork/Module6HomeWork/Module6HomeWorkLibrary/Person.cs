namespace Module6HomeWorkLibrary
{
    public class Person
    {
        public string FirstName {  get; set; }
        public string LastName { get; set; }    
        public int Age { get; set; }

    }

    public class PersonProccess
    {

        public static string PersonProccessFunction(Person person)
        {
            return $"{person.FirstName} {person.LastName}, Age:{person.Age}";
        }

    }
}