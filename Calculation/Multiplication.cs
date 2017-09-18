using System;
namespace Calculation
{
	public class Multiplication : BaseCalculator
	{
		public override string GetResult()
		{
			return (number1 * number2).ToString();
		}
	}
}
