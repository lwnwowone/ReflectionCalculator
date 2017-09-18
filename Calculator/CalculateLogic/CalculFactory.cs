using System;
using System.Collections.Generic;
using System.Reflection;
using CalculationInterface;

namespace Calculator
{
	public class CalculFactory
	{
		public static ICalculation GetCalculatorByOperator(string theOperator)
		{
			ICalculation result = null;
			string operationName = FindTypeByOperator(theOperator);
			if (!string.IsNullOrEmpty(operationName) && System.IO.File.Exists(DllHelper.DLLFilePath))
			{
				try
				{
					Assembly assembly = Assembly.LoadFile(DllHelper.DLLFilePath);
					string typeName = string.Format("{0}.{1}", DllHelper.DLLFileName, operationName);
					Type type = assembly.GetType(typeName);
					foreach (var item in type.GetMethods()) {
						Console.WriteLine("item.method.name = "+item.Name);
					}
					object tmp = assembly.CreateInstance(typeName);
					ICalculation instance = tmp as ICalculation;
					if (null != instance)
						result = instance;
				}
				catch (Exception ex)
				{
					Console.WriteLine("Get type failed, error message = " + ex.Message);
				}
			}
			return result;
		}

		private static string FindTypeByOperator(string theOperator)
		{
			string result = "";
			if (null != ConfigHelper.ConfigDictionary && ConfigHelper.ConfigDictionary.ContainsKey(theOperator))
			{
				result = ConfigHelper.ConfigDictionary[theOperator];
			}
			return result;
		}
	}
}
