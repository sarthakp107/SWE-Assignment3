using AWE_Electronics.Core.Models;
using System;
namespace AWE_Electronics.Data
{
	public class DataStore
	{
		public static Dictionary<Product, int> Stock { get; } = new Dictionary<Product, int>();
		public static List<User> Users { get; } = new List<User>();

		public static void InitializeData()
		{
			Product p1 = new Product("Computer", "Big Intelligent Box", 1500, 15);
			User admin1 = new Admin("Prabesh", "prabesh@email.com", "pass1");
			User cust1 = new Customer("Sarthak", "sarthak@email.com", "pass1");
			Users.Add(admin1);
            Users.Add(cust1);
        }
	}
}

