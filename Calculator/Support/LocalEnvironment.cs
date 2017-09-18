using System;
namespace Calculator
{
	public static class LocalEnvironment
	{
		public static bool InitLocalEnvironment()
		{
			Console.WriteLine("Application resource path = " + FileHelper.AppResourceDirectoryPath);
			try
			{
				string configBundlePath = Foundation.NSBundle.MainBundle.PathForResource("CalculatorConfig", "json");
				System.IO.File.Copy(configBundlePath, ConfigHelper.ConfigFilePath,false);
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Init localEnvironment failed, error message = " + ex.Message);
			}

			return false;
		}
	}
}
