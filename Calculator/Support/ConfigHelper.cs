using System;
using System.Collections.Generic;

namespace Calculator
{
	public class ConfigHelper
	{
		public static string ConfigFileName
		{
			get
			{
				return "CalculatorConfig.json";
			}
		}

		public static string ConfigFilePath
		{
			get
			{
				return FileHelper.GetFilePathByName(ConfigFileName);
			}
		}

		public static Dictionary<string, string> ConfigDictionary{
			get	{
				try {
					string configContent = System.IO.File.ReadAllText(ConfigHelper.ConfigFilePath);
					Dictionary<string, string> operatorDic = JsonHelper.GetDictionaryFromJson(configContent);
					if (null != operatorDic)
						return operatorDic;
				} 
				catch (Exception ex) {
					Console.WriteLine("Get ConfigDictionary failed, error message = " + ex.Message);
				}
				return null;
			}
		}
	}
}
