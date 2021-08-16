using System;

namespace FinalOOPSConcept
{

		class fruit
	{
		int a = 100, b = 40, c = 190;
		String sweetfruit = "Mango", Berryfruit = "Straberry", Carbfruit = "banana";
		void Fruitsalad()
		{
			Console.WriteLine("The fruit salads is made of fruits");
		}

		void addvals()
		{
			int sum = a + b + c;
			Console.WriteLine(sum);

		}

	class Car
	{

		String color = "Red";
		int carlenght = 60;
		String model ;
		String maxspeed;
			int wheels;
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			//Create oject using car class and pull in meathods variables and assign values for variables declared in car class
			Car audi = new Car();
				Console.WriteLine (audi.carlenght);
				Console.WriteLine(audi.color);
				Console.WriteLine(audi.model= "The Audi");
				Console.WriteLine(audi.maxspeed = "6660km/hr");
				Console.WriteLine(audi.wheels = 8);

				Car FMustang = new Car();
				Console.WriteLine(FMustang.carlenght);
				Console.WriteLine(FMustang.color);
				Console.WriteLine(FMustang.model = "Ford E Mustang");
				FMustang.maxspeed = "220km/h";
				FMustang.wheels = 4;
				Console.WriteLine(FMustang.maxspeed);
				Console.WriteLine(FMustang.wheels);


				fruit apple = new fruit();
				apple.addvals();
				apple.Fruitsalad();
				Console.WriteLine(apple.Berryfruit);
				Console.WriteLine(apple.Carbfruit);
				Console.WriteLine("The sweetest and my fav fruits is   " +apple.sweetfruit);
				Console.WriteLine((apple.a) +(apple.b));
				Console.ReadLine();

		}
	}
	}
}
