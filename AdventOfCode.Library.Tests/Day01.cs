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
			Heading newHeading = Day01.GetNewHeading(Heading.North, Direction.Left);
			Assert.AreEqual(Heading.West, newHeading);
		}
	}
}
