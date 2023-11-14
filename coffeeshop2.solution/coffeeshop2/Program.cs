namespace coffeeshop2
{
	 class Program
	{
		static void Main()
		{
			double Americano;
			Americano = 2.50;
			int Latte;
			Latte = 3;
			double Cappuccino;
			Cappuccino = 3.50;



			Console.WriteLine("Welcome to the Coffee Shop \n Menue: ");
			Console.WriteLine("1. Americano - " + Americano);
			Console.WriteLine("2. Latte - " + Latte);
			Console.WriteLine("3. Cappuccino - " + Cappuccino);
			Console.Write("\nSelect an option: ");



			string userChoice = Console.ReadLine();
			string message = "";

			if (userChoice == "1")
			{

				message = " Americano!\n" + "\nPrice" +" "+ Americano;
			}
			else if (userChoice == "2")
			{

				message = " Latte!\n" + "Price" + Latte;
			}
			else if (userChoice == "3")
			{

				message = " Cappuccino!\n" + "Price" + Cappuccino;
			}

			Console.Write("\nCustomize Your Drink: ");
			Console.Write("\n 1.Small ");
			Console.Write("\n 2.Medium ");
			Console.Write("\n 3.Large \n");

			string userCustomize = Console.ReadLine();
			string message1 = "";

			if (userCustomize == "1")
				message1 = "You choose a Small size ";
			else if (userCustomize == "2")
				message1 = "You choose a Medium size";
			else if (userCustomize == "3")
				message1 = "You choose a Large size!";


			Console.WriteLine(message1);


			Console.Write("\nDo you went add a sugar ");
			Console.Write("\n 1.Yes ");
			Console.Write("\n 2.No \n");


			string addSugar = Console.ReadLine();
			string message2 = "";

			if (addSugar == "1")
				message2 = "Your drink is with sugar ";
			else if (addSugar == "2")
				message2 = "Your drink is without sugar";

			Console.WriteLine(message2);

			Console.WriteLine("Do you went milk? ");
			Console.WriteLine("1.Yes");
			Console.WriteLine("2.No");

			string addMilk = Console.ReadLine();
			string message3 = "";

			if (addMilk == "1")
			{

				message3 = "You add a milk";
			}
			else if (addMilk == "2")
			{


				message3 = "You don't add a milk";
			}




			Console.ReadLine();
			Console.WriteLine("Your Order Summary is ");
			Console.WriteLine(message + "" + message1 + "\n" + message2 + message3);
		}
	}
}