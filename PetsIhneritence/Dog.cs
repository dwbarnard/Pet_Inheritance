using System;

namespace PetsInheritance
{

	public class Dog : Mammal
	{
		private String myNoise = "Bow Wow";

		public Dog(String petName) : base(petName, myNoise)
		{
		}

		public String Display()
		{
			String tempStr = base.Display();
			return (tempStr + "\nIs a Dog");
		}
	}
}

