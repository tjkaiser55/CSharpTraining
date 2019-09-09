using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DMVTraining
{
	/// <summary>
	/// This class is a blueprint for a custom datatype
	/// 
	/// </summary>
	class Automobile
	{
		// member variable
		private string hp;
		private string make;
		private string model;
		private string vin;
		private int modelYear;
		private string vehicleName;
		private string valueStatus;


		public enum ValueValid
		{
			Valid,
			Spaces,
			LowValues,
			Custom
		}

		public string ValueStatus
		{
			get
			{
				return this.valueStatus;
			}
			set
			{
				this.valueStatus = value;
			}
		}

		public int ModelYear {
			get
			{
				return this.modelYear;
			}
			set
			{
				this.modelYear = value;
			}
		}
		public string Hp
		{
			get
			{
				return this.hp;
			}
			set
			{
				this.hp = value;
			}
		}

		public string Vin
		{
			get
			{
				return this.vin;
			}
			set
			{
				this.vin = value;
			}
		}

		public string VehicleName
		{
			get
			{
				return this.vehicleName;
			}
			set
			{
				this.vehicleName = value;
			}
		}
		


		// default constructor
		public Automobile(string vin, string make)
		{
			this.vin = vin;
			this.make = make;
		}

		public Automobile(string make, string model, string hp)
		{
			
			this.make = make;
			this.model = model;
			this.Hp = hp;
		}

		public Automobile(string vehicleName, string make, string model, string hp)
		{
			this.vehicleName = vehicleName;
			this.make = make;
			this.model = model;
			this.Hp = hp;
		}

		public void Honk()
		{
			//
			if (!string.IsNullOrEmpty(vehicleName) && hp != null && !string.IsNullOrEmpty(make) && !string.IsNullOrEmpty(model) && !string.IsNullOrEmpty(vin))
			{
				Console.WriteLine("Honk from {0}. My vin is {1} and I have {2} horsepower. I am a {3} {4}.", vehicleName, vin, hp, make, model);
			}
			else if (vehicleName != null && !string.IsNullOrEmpty(make) && !string.IsNullOrEmpty(hp))
			{
				Console.WriteLine("Honk from {0}. My make is {1} and my horsepower is {2}.", vehicleName, make, hp);
			}
			else
			{
				Console.WriteLine("Honk from {0}.", make);
			}

		}

		public void WriteToLog(string logEntry)
		{
			using (System.IO.StreamWriter writer = new System.IO.StreamWriter("Logfile.txt", true))
			{
				DateTime dt = DateTime.Now;
				string todaysDate = dt.ToShortDateString();
				writer.WriteLine("Log entry on {0}", dt.ToString());
				writer.WriteLine(logEntry);
			}

		}


	}
}
