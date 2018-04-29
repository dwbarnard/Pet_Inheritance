using System;

namespace PetsInheritance
{

	public class Mammal : Pet
	{
		private String flyMsg = "Cannot Fly";
		private Int32 petTemperature = 99;

		public Mammal(String petName, String petNoise) : base(petName, petTemperature, flyMsg, petNoise)
		{
		}

		public String Display()
		{
			String tempStr = base.Display();
			return (tempStr + "\nIs a Mammal");
		}
	}
}