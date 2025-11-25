public abstract class ElectronicDevice
{
	// Private fields (hidden from outside)
	private string brand;
	private double price;


	// Public properties to access private fields
	public string Brand
	{
		get { return brand; }        
		set { brand = value; }        
	}

	public double Price
	{
		get { return price; }          
		set
		{
			if (value < 0)
				throw new Exception("Price cannot be negative!");
			price = value;         
		}
	}

	// Parameterized Constructor
	public ElectronicDevice(string brand, double price)
	{
		Brand = brand;   // using property
		Price = price;   // using property
	}

	// abstract method
	public abstract void ShowInfo();
	
}
