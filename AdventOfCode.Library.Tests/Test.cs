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
			Heading newHeading = Day01.GetNewHeading(Heading.North);
			Assert.AreSame(Heading.North, newHeading);
		}
	}
}
