using System;
using System.Diagnostics.Contracts;

namespace AdventOfCode.Library
{
	public class Day01
	{
		public Day01()
		{
		}

		public static Heading GetNewDirection(Heading heading) {
			Contract.Ensures(Contract.Result<Heading>() != null);
			return Heading.North;
		}

	}

	public class Heading
	{
		public static Heading North { get; internal set; }
		public static Heading West { get; internal set; }
		public static Heading South { get; internal set; }
		public static Heading East { get; internal set; }
	}
}
