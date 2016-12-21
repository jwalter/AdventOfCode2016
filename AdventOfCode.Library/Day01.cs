using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace AdventOfCode.Library
{

	public class Day01
	{
		public Tuple<int, int> ProcessInput(string input)
		{
			Tuple<int, int> location = new Tuple<int, int>(0, 0);
			Heading heading = Heading.North;
			var visitedLocations = new Dictionary<Tuple<int, int>, bool>();
			Tuple<int, int> firstRevisited = null;
			foreach (var navigationCommand in input.Split(','))
			{
				heading = GetNewHeading(heading, GetDirection(navigationCommand.Trim()[0]));
				int distance = GetDistance(navigationCommand);
				while (distance-- > 0)
				{
					location = Move(location, heading, 1);
					if (firstRevisited == null)
					{
						if (visitedLocations.ContainsKey(location))
						{
							firstRevisited = location;
						}
						else
						{
							visitedLocations[location] = true;
						}
					}
				
				}

			}
			return new Tuple<int, int>(DistanceTo(location), DistanceTo(firstRevisited));
		}

		int DistanceTo(Tuple<int, int> location)
		{
			return Math.Abs(location.Item1) + Math.Abs(location.Item2);
		}

		public static Direction GetDirection(char v)
		{
			if (v == 'L') return Direction.Left;
			return Direction.Right;
		}

		public static Heading GetNewHeading(Heading heading, Direction direction)
		{
			if (direction == Direction.Left)
			{
				return TurnLeft(heading);
			}
			else
			{
				return TurnRight(heading);
			}
		}

		Tuple<int, int> Move(Tuple<int, int> location, Heading heading, int distance)
		{
			switch (heading)
			{
				case Heading.North:
					return new Tuple<int, int>(location.Item1, location.Item2 + distance);
				case Heading.East:
					return new Tuple<int, int>(location.Item1 + distance, location.Item2);
				case Heading.South:
					return new Tuple<int, int>(location.Item1, location.Item2 - distance);
				case Heading.West:
					return new Tuple<int, int>(location.Item1 - distance, location.Item2);
				default:
					return location;
			}
		}

		public static int GetDistance(string navigationCommand)
		{
			return int.Parse(navigationCommand.Trim().Substring(1));
		}

		static Heading TurnLeft(Heading heading)
		{
			switch (heading)
			{
				case Heading.North:
					return Heading.West;
				case Heading.South:
					return Heading.East;
				case Heading.West:
					return Heading.South;
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
				case Heading.East:
					return Heading.South;
				case Heading.South:
					return Heading.West;
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
