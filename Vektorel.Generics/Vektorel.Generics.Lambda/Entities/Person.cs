namespace Vektorel.Generics.Lambda.Models
{
    internal class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static implicit operator Person(string fullName)
        {
            var parts = fullName.Split(' ');
            var firstName = parts[0];
            var lastName = string.Empty;
            if (parts.Length > 0)
            {
                lastName = parts[1];
            }
            return new Person { FirstName = firstName, LastName = lastName };
        }
    }
}
