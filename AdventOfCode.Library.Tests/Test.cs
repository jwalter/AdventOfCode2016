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
			Heading newDirection = Day01.GetNewDirection(Heading.North);
			Assert.AreSame(Heading.North, newDirection);
		}
	}
}
