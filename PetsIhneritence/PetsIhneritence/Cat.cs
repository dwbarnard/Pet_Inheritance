using System;

namespace PetsInheritance
{
	public class Cat : Mammal
	{
		private static String myNoise = "meow meow";

		public Cat(String petName) : base(petName, myNoise)
		{
		}

		public override String Display()
		{
			String tempStr = base.Display();
			return (tempStr + "Is a Cat" + Environment.NewLine);
		}
	}
}