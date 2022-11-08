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
        person.Name = "Jokke";
        person.Age = 46;
        person.Restaurant = "Kotipizza";
        Console.WriteLine("Person details - {0}", person);

        // Increment the Age property:
        person.Age += 1;
        person.Restaurant = "Burger King";
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

        // customer
                // Initialize a new object.
        Customer cust1 = new Customer(4987.63, "Northwind", 90108);
        // Modify a property.
        cust1.TotalPurchases += 499.99;

        //metodin kutsu
        cust1.GetTransactionHistory();

       Console.WriteLine("ID: " + cust1.CustomerId + " Name: " + cust1.Name + " Kaikki ostokset: " + cust1.TotalPurchases  );


	}
}