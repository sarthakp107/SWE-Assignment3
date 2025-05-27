using System;
namespace AWE_Electronics.Core.Models
{
	public class Admin : User
	{
		public Admin(string name, string email, string password) : base (name, email, password)
		{
		}
        public override bool isAdmin => true;
        //Methods
        public void UpdateCatalogue(string product_name)
		{
			Console.WriteLine($"{product_name} Updated");
		}
    }
}

