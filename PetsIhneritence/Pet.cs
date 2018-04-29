using System;

namespace PetsInheritance
{
	public class Pet
	{
		// member variables
		protected String name;
		protected Int32 temperature;
		protected String flyMsg;
		protected String noise;

		public Pet(String petName, Int32 petTemp, String petFlyMessage, String petNoise)
		{
			name = petName;
			temperature = petTemp;
			flyMsg = petFlyMessage;
			noise = petNoise;

		}
		public String Display()
		{
			return ("Name: " + name + "\nBodyTemperature: " + temperature + "\nAble to Fly? " + flyMsg + "\n");
		}

		public String ToString()
		{
			return name;
		}
	}
}
