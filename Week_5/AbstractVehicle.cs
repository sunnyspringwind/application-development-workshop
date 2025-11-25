namespace AppDev.Week_5.Abstract
{
	public abstract class Vehicle
	{
		// abstract methods
		public abstract void StartEngine();
		public abstract void StopEngine();

		// concrete method
		public void Display()
		{
			Console.WriteLine("This is a vehicle");
		}

	}

	// DERIVED CLASSES

	// Car
	public class Car : Vehicle
	{
		public override void StartEngine()
		{
			Console.WriteLine("Car Engine Started");
		}

		public override void StopEngine()
		{
			Console.WriteLine("Car Engine Stopped");
		}
	}

	//Bike
	public class Bike : Vehicle
	{
		public override void StartEngine()
		{
			Console.WriteLine("Bike Engine Started");
		}

		public override void StopEngine()
		{
			Console.WriteLine("Bike Engine Stopped");
		}
	}

}