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
			return Heading.West;
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
