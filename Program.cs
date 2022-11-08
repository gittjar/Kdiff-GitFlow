using System;
using System.Linq;

public class Program
{
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
	}
}