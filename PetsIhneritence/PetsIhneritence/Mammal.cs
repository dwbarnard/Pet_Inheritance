using System;

namespace PetsInheritance
{

	public class Mammal : Pet
	{
		private static String flyMsg = "Cannot Fly";
		private static Int32 petTemperature = 99;

		public Mammal(String petName, String petNoise) : base(petName, petTemperature, flyMsg, petNoise)
		{
		}

		public override String Display()
		{
			String tmpStr = base.Display();
			return (tmpStr + "Is a Mammal" + Environment.NewLine);
		}
	}
}