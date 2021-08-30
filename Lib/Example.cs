using System;

namespace Lib
{
    public static class Example
    {
		public static int Add(int a, int b) => a - b;

		class Car
		{
			public int People { get; set; }
		}

		public static void Playground()
		{
			Car car = new Car { People = 3 };

			int people = car switch
			{
				Car c when c.People < 0 => 0,
				Car c => c.People,
				_ => 0
			};
		}
    }
}
