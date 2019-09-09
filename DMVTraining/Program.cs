using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DMVTraining.Automobile;

namespace DMVTraining
{
	class Program
	{
		static void Main(string[] args)
		{

			// create a new instance of automobile
			Automobile myAuto = new Automobile("25or6to4", "Chevy");
			myAuto.Honk();

			Automobile swampBuggy = new Automobile("Betsy", "Ford", "Ranger", "350");
			swampBuggy.Vin = "Rq234";
			Console.WriteLine("My new swamp buggy has {0} horsepower", swampBuggy.Hp);
			swampBuggy.Honk();
			swampBuggy.ValueStatus = "Spaces";

			

			Automobile myNewCar = new Automobile("ZZ123", "BMW");
			myNewCar.Hp = "230";
			myNewCar.ModelYear = 2019;
			myNewCar.Honk();
			//Console.WriteLine("MyNewCar has {0} horsepower and the model year is {1}.", myNewCar.Hp, myNewCar.ModelYear);

			//Console.WriteLine("New auto using second constructor");
			Automobile mySpareCar = new Automobile("Toyota", "Celica", "68");
			mySpareCar.ModelYear = 2016;
			mySpareCar.Honk();
			

			mySpareCar.WriteToLog(String.Format("Entered a new log entry for my {0} spare car.", mySpareCar.ModelYear));

			// Enums
			DateTime dt = new DateTime(2019, 8, 14);
			Console.WriteLine("Is Wednesday the day of the week for {0:d}?: {1}",
							   dt, dt.DayOfWeek == DayOfWeek.Wednesday);
			Console.WriteLine("The day of the week for {0:d} is {1}.", dt, dt.DayOfWeek);

	Console.ReadLine();
		}
	}
}
