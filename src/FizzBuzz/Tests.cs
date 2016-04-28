using System.Linq;
using NUnit.Framework;

namespace FizzBuzz
{
    public class Tests
    {
		[Test]
		public void Number()
		{
			var one = new Number(1);
			Assert.AreEqual("1", one.FizzBuzzify());
			Assert.AreEqual("1", one.FizzBuzzWoofify());
		}

		[Test]
		public void MultipleOf3()
		{
			var three = new Number(3);
			Assert.AreEqual("Fizz", three.FizzBuzzify());
			Assert.AreEqual("Fizz", three.FizzBuzzWoofify());
		}

		[Test]
		public void MultipleOf5()
		{
			var five = new Number(5);
			Assert.AreEqual("Buzz", five.FizzBuzzify());
			Assert.AreEqual("Buzz", five.FizzBuzzWoofify());
		}

		[Test]
		public void MultipleOf7()
		{
			var seven = new Number(7);
			Assert.AreEqual("7", seven.FizzBuzzify());
			Assert.AreEqual("Woof", seven.FizzBuzzWoofify());
		}

		[Test]
		public void MultipleOf3And5()
		{
			var fifteen = new Number(15);
			Assert.AreEqual("FizzBuzz", fifteen.FizzBuzzify());
			Assert.AreEqual("FizzBuzz", fifteen.FizzBuzzWoofify());
		}

		[Test]
		public void MultipleOf3And7()
		{
			var twentyOne = new Number(21);
			Assert.AreEqual("Fizz", twentyOne.FizzBuzzify());
			Assert.AreEqual("FizzWoof", twentyOne.FizzBuzzWoofify());
		}

		[Test]
		public void MultipleOf5And7()
		{
			var thirtyFive = new Number(35);
			Assert.AreEqual("Buzz", thirtyFive.FizzBuzzify());
			Assert.AreEqual("BuzzWoof", thirtyFive.FizzBuzzWoofify());
		}

		[Test]
		public void MultipleOf3And5And7()
		{
			var oneHundredAndFive = new Number(105);
			Assert.AreEqual("FizzBuzz", oneHundredAndFive.FizzBuzzify());
			Assert.AreEqual("FizzBuzzWoof", oneHundredAndFive.FizzBuzzWoofify());
		}

		[Test]
		public void FizzBuzzRange()
		{
			var numbers = Enumerable.Range(1, 15).Select(x => new Number(x));
			const string expected = "1-2-Fizz-4-Buzz-Fizz-7-8-Fizz-Buzz-11-Fizz-13-14-FizzBuzz";
			var actual = string.Join("-", numbers.Select(x => x.FizzBuzzify()));
			Assert.AreEqual(expected, actual);
		}

		[Test]
		public void FizzBuzzWoofRange()
		{
			var numbers = Enumerable.Range(1, 21).Select(x => new Number(x));
			const string expected = "1-2-Fizz-4-Buzz-Fizz-Woof-8-Fizz-Buzz-11-Fizz-13-Woof-FizzBuzz-16-17-Fizz-19-Buzz-FizzWoof";
			var actual = string.Join("-", numbers.Select(x => x.FizzBuzzWoofify()));
			Assert.AreEqual(expected, actual);
		}
	}
}