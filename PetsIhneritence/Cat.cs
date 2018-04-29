using System;

namespace PetsInheritance
{
	public class Cat : Mammal
	{
		private String myNoise = "meow meow";

		public Cat(String petName) : base(petName, myNoise)
		{
		}

		public String Display()
		{
			String tempStr = base.Display();
			return (tempStr + "\nIs a Cat");
		}
	}
}