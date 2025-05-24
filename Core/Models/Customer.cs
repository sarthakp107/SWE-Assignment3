using System;
namespace AWE_Electronics.Core.Models
{
	public class Customer : User
	{
		public Customer(string name, string email, string password):base(name, email, password)
		{
		}
		public override bool isAdmin => false;
		//Methods
		public void AddToCart(string product_name)
		{
			Console.WriteLine($"{product_name} added to cart");
		}
    }
}

