using System;

namespace StaticPreexecutionTest
{
	class LazySingleton
	{
		private static LazySingleton instance;
		public static LazySingleton Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new LazySingleton();
				}

				return instance;
			}
		}

		private LazySingleton()
		{
			Console.WriteLine("LazySingleton Constructor");
		}

		public string LazyTest()
		{
			return "LazySingleton:Test()";
		}
	}
}
