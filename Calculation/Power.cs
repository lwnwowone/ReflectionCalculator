using System;
namespace Calculation
{
	public class Power : BaseCalculator
	{
		public override string GetResult()
		{
			return Math.Pow(number1, number2).ToString();
		}
	}
}
