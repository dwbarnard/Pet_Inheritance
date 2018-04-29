using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetsInheritance
{
	public class Bird : Pet
	{
		private static String flyMsg = "Flying like the wind";
		private static Int32 petTemperature = 105;
		private static String birdNoise = "Tweet Tweet";

		public Bird(String petName) : base(petName, petTemperature, flyMsg, birdNoise)
		{
		}

		public override String Display()
		{
			String tmpStr = base.Display();
			return (tmpStr + "Is a Bird" + Environment.NewLine);
		}
	}
}
