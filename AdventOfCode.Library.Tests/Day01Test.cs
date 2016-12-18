using NUnit.Framework;
using System;
namespace AdventOfCode.Library.Tests
{
	[TestFixture()]
	public class Day01Test
	{
		[TestCase(Heading.North, Direction.Left, Heading.West)]
		[TestCase(Heading.North, Direction.Right, Heading.East)]
		[TestCase(Heading.East, Direction.Left, Heading.North)]
		[TestCase(Heading.East, Direction.Right, Heading.South)]
		[TestCase(Heading.South, Direction.Left, Heading.East)]
		[TestCase(Heading.South, Direction.Right, Heading.West)]
		[TestCase(Heading.West, Direction.Left, Heading.South)]
		[TestCase(Heading.West, Direction.Right, Heading.North)]
		public void GetNewHeading(Heading heading, Direction direction, Heading expected)
		{
			Assert.AreEqual(expected, Library.Day01.GetNewHeading(heading, direction));
		}

		[TestCase('L', Direction.Left)]
		[TestCase('R', Direction.Right)]
		public void GetDirection(char input, Direction expected)
		{
			Assert.AreEqual(expected, Library.Day01.GetDirection(input));
		}

		[TestCase("R123", 123)]
		public void GetDistance(string input, int expected)
		{
			Assert.AreEqual(expected, Library.Day01.GetDistance(input));
		}

		[Test]
		public void ProcessInput()
		{
			string input = "L4, L3, R1, L4, R2, R2, L1, L2, R1, R1, L3, R5, L2, R5, L4, L3, R2, R2, L5, L1, R4, L1, R3, L3, R5, R2, L5, R2, R1, R1, L5, R1, L3, L2, L5, R4, R4, L2, L1, L1, R1, R1, L185, R4, L1, L1, R5, R1, L1, L3, L2, L1, R2, R2, R2, L1, L1, R4, R5, R53, L1, R1, R78, R3, R4, L1, R5, L1, L4, R3, R3, L3, L3, R191, R4, R1, L4, L1, R3, L1, L2, R3, R2, R4, R5, R5, L3, L5, R2, R3, L1, L1, L3, R1, R4, R1, R3, R4, R4, R4, R5, R2, L5, R1, R2, R5, L3, L4, R1, L5, R1, L4, L3, R5, R5, L3, L4, L4, R2, R2, L5, R3, R1, R2, R5, L5, L3, R4, L5, R5, L3, R1, L1, R4, R4, L3, R2, R5, R1, R2, L1, R4, R1, L3, L3, L5, R2, R5, L1, L4, R3, R3, L3, R2, L5, R1, R3, L3, R2, L1, R4, R3, L4, R5, L2, L2, R5, R1, R2, L4, L4, L5, R3, L4";
			int expected = 332;
			Assert.AreEqual(expected, new Day01().ProcessInput(input));
		}
	}
}
