using NUnit.Framework;
using System;
namespace AdventOfCode.Library.Tests
{
	[TestFixture()]
	public class Test
	{
		[Test()]
		public void North()
		{
			Direction newDirection = Day01.GetNewDirection(Direction.North);
			Assert.AreSame(Direction.North, newDirection);
		}
	}
}
