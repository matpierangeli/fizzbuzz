using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz
{
	public class Number
	{
		private static readonly IEnumerable<Tuple<Predicate<int>, string>> FizzBuzzRuleSet = new List<Tuple<Predicate<int>, string>>
		{
			new Tuple<Predicate<int>, string>(n => n % 3 == 0, "Fizz"),
			new Tuple<Predicate<int>, string>(n => n % 5 == 0, "Buzz")
		};

		private static readonly IEnumerable<Tuple<Predicate<int>, string>> FizzBuzzWoofRuleSet = new List<Tuple<Predicate<int>, string>>(FizzBuzzRuleSet.Concat(new[]
		{
			new Tuple<Predicate<int>, string>(n => n % 7 == 0, "Woof")
		}));

		private readonly int _number;

		public Number(int number)
		{
			_number = number;
		}

		public string FizzBuzzify()
		{
			return Resolve(FizzBuzzRuleSet, _number);
		}

		public string FizzBuzzWoofify()
		{
			return Resolve(FizzBuzzWoofRuleSet, _number);
		}

		private static string Resolve(IEnumerable<Tuple<Predicate<int>, string>> rules, int number)
		{
			var result = rules.Aggregate("", (acc, e) => acc + (e.Item1(number) ? e.Item2 : ""));
			return string.IsNullOrEmpty(result) ? number.ToString() : result;
		}
	}
}