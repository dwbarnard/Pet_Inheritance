using System;

namespace PetsInheritance
{

	public class Dog : Mammal
	{
		private static String myNoise = "Bow Wow";

		public Dog(String petName) : base(petName, myNoise)
		{
		}

		public override String Display()
		{
			String tmpStr = base.Display();
			return (tmpStr + "Is a Dog" + Environment.NewLine);
		}
	}
}

