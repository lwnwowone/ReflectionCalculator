using System;
namespace Calculator
{
	public class DllHelper
	{
		public static string DLLFileName
		{
			get
			{
				return "Calculation";
			}
		}

		public static string DLLFileNameWithxtension
		{
			get
			{
				return "Calculation.dll";
			}
		}

		public static string DLLFilePath
		{
			get
			{
				return FileHelper.GetDLLPathByName(DLLFileNameWithxtension);
			}
		}
	}
}
