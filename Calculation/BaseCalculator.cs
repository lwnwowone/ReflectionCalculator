using System;

namespace Calculation
{
	public class BaseCalculator : CalculationInterface.ICalculation
	{
		protected double number1;
		public double Number1 { 
			get {
				return number1;
			}
			set {
				number1 = value;
			}
		}

		protected double number2;
		public double Number2
		{
			get
			{
				return number2;
			}
			set
			{
				number2 = value;
			}
		}

		public virtual string GetResult()
		{
			return "";
		}
	}
}
