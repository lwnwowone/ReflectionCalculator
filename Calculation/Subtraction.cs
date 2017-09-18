using System;

namespace Calculation
{
	public class Subtraction : BaseCalculator
	{
		public override string GetResult()
		{
			return (number1 - number2).ToString();
		}
	}
}
