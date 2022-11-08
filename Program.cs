using System;
using System.Linq;

public class Program
{
        static void GetPerson()
    {
        // Create a new Person object:
        Person person = new Person();

        // Print out the name and the age associated with the person:
        Console.WriteLine("Person details - {0}", person);

        // Set some values on the person object:
        person.Name = "Joe";
        person.Age = 99;
        Console.WriteLine("Person details - {0}", person);

        // Increment the Age property:
        person.Age += 1;
        Console.WriteLine("Person details - {0}", person);

        // Keep the console window open in debug mode.
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }
	public static void Main()
	{
		string[] empty = new string[5];
		var totalElements = empty.Count();
		Console.WriteLine(totalElements);
		
		string[] operators = {"Telia", "DNA", "Elisa", "Telenor", "T-Mobile", "France Telecom"};
		totalElements = operators.Count();
		Console.WriteLine(totalElements);
		
		int[] nums = {1, 2, 3, 4, 3, 55, 23, 2, 5, 6, 2, 2};
		totalElements = nums.Count();
		Console.WriteLine(totalElements);

        // haetaan henkilötiedot
        GetPerson();

	}
}