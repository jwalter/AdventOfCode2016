using NUnit.Framework;
using System;
namespace AdventOfCode.Library.Tests
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void North_ToLeft_IsWest()
		{
			Assert.AreEqual(Heading.West, Day01.GetNewHeading(Heading.North, Direction.Left));
		}
		[Test()]
		public void North_ToRight_IsEast()
		{
			Assert.AreEqual(Heading.East, Day01.GetNewHeading(Heading.North, Direction.Right));
		}
	}
}
