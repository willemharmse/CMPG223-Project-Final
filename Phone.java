public class Phone extends Samsung
{
	
	// Hey Guys
	int batteryCap;
	int yearReleased;

	public Phone()
	{
		
	}
	
	public Phone(int osVersion, String model, double screenSize, int batteryCap, int yearReleased)
	{
		super(osVersion, model, screenSize);
		setBatteryCap(batteryCap);
		setYearReleased(yearReleased);
	}
	
	public void setBatteryCap(int batteryCap)
	{
		this.batteryCap = batteryCap;
	}

	public int getBatteryCap()
	{
		return batteryCap;
	}
	
	public void setYearReleased(int yearReleased)
	{
		this.yearReleased = yearReleased;
	}

	public int getYearReleased()
	{
		return yearReleased;
	}
	
	@Override
	public String toString()
	{
		return "The device is a Phone\nModel: " + getModel() + "\nOperating system version: " + getOSVersion() + "\nScreen size of: " + getScreenSize() + "\nBattery Capacity: " + getBatteryCap() + "\nYear Released: " + getYearReleased();
	}
	
	public double calculatePrice()
	{
		double baseCost = 0;
		
		//We have a base cost for the device which is R7500 if the device was released after 2020 and R5500 if it was released earlier
		if (getYearReleased() < 2020)
		{
			baseCost = 7500;
		}
		else
		{
			baseCost = 5500;
		}
		
		//we then determine the relationship between the screen size and the battery capacity and divide it by 100000
		double screenBatteryRelation = (getScreenSize() * getBatteryCap()) / 10000;
		
		//We then return the price of the device
		return (baseCost + (screenBatteryRelation * 900));
	}
	
	public int deviceLifetime()
	{
		//The device has a normal lifetime of 0 years
		int lifetime = 0;
		
		//we then use the year the device was released to determine how long the device will last
		if (getYearReleased() >= 2020)
		{
			lifetime += 4;
		}
		else if (getYearReleased() >= 2016)
		{
			lifetime += 2;
		}
		else
		{
			lifetime += 1;
		}
		
		//we also use the battery capacity to add some lifetime to the device
		if (getBatteryCap() >= 5000)
		{
			lifetime += 4;
		}
		else if (getBatteryCap() >= 3000)
		{
			lifetime += 3;
		}
		else
		{
			lifetime += 1;
		}
		
		//return the lifetime
		return lifetime;
	}
}