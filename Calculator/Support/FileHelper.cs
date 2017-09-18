using System;
namespace Calculator
{
	public class FileHelper
	{
		public static string AppResourceDirectoryPath
		{
			get {
				string result = Environment.GetFolderPath(Environment.SpecialFolder.Resources) + @"/Resources";
				if (!System.IO.Directory.Exists(result))
					System.IO.Directory.CreateDirectory(result);
				return Environment.GetFolderPath(Environment.SpecialFolder.Resources) + @"/Resources";
			}
		}

		public static string AppDLLDirectoryPath
		{
			get
			{
				string result = Environment.GetFolderPath(Environment.SpecialFolder.Resources) + @"/DLL";
				if (!System.IO.Directory.Exists(result))
					System.IO.Directory.CreateDirectory(result);
				return Environment.GetFolderPath(Environment.SpecialFolder.Resources) + @"/DLL";
			}
		}

		public static string GetFilePathByName(string fileName)
		{
			return AppResourceDirectoryPath + "/" + fileName;
		}

		public static string GetDLLPathByName(string dllName)
		{
			return AppDLLDirectoryPath + "/" + dllName;
		}
	}
}
