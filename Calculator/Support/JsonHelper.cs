using System;
using System.Collections.Generic;

namespace Calculator
{
	public class JsonHelper
	{
		public static Dictionary<string,string> GetDictionaryFromJson(string jsonStr)
		{
			Dictionary<string, string> result = null;

			try{
				result = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<string, string>>(jsonStr);
			}
			catch (Exception ex){
				Console.WriteLine("Read json string failed, error message = " + ex.Message);
			}

			return result;
		}

		public static bool WriteJsonFromDictionary(string path,Dictionary<string, string> oDic)
		{
			try
			{
				string jsonStr = Newtonsoft.Json.JsonConvert.SerializeObject(oDic);
				System.IO.File.WriteAllText(path, jsonStr);
				return true;
			}
			catch (Exception ex)
			{
				Console.WriteLine("Write json string failed, error message = " + ex.Message);
			}

			return false;
		}
	}
}
