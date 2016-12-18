using System;
using System.Diagnostics.Contracts;

namespace AdventOfCode.Library
{
	public class Day01
	{
		public Day01()
		{
		}

		public static Heading GetNewHeading(Heading heading, Direction direction) {
			if (direction == Direction.Left)
			{
				return TurnLeft(heading);
			}
			else
			{
				return TurnRight(heading);
			}
		}

		static Heading TurnLeft(Heading heading)
		{
			switch (heading)
			{
				case Heading.North:
					return Heading.West;
				default:
					return Heading.North;
			}
		}

		static Heading TurnRight(Heading heading)
		{
			switch (heading)
			{
				case Heading.North:
					return Heading.East;
				default:
					return Heading.North;
			}
		}
}

	public enum Heading
	{
		North, East, South, West
	}
	public enum Direction
	{
		Left, Right
	}
}
