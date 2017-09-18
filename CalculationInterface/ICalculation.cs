using System;
namespace CalculationInterface
{
	public interface ICalculation
	{
		double Number1 { get; set; }
		double Number2 { get; set; }
		string GetResult();
	}
}
