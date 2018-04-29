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
		public virtual String Display()
		{
			return ("Name: " + name + Environment.NewLine + "BodyTemperature: " + temperature + Environment.NewLine + "Able to Fly? " + flyMsg + Environment.NewLine + noise + Environment.NewLine);
		}

		public String petName
		{
			get
			{
				return name;
			}
		}
	}
}
