using System;

namespace StaticPreexecutionTest
{
	public sealed class Singleton
	{
		private static readonly Singleton instance = new Singleton();
		public static Singleton Instance {
			get { return instance; }
		}

		/*
		static Singleton()
		{
			Console.WriteLine("Static Constructor");
		}
		*/

		private Singleton()
		{
			Console.WriteLine("Singleton Constructor");
		}

		public string Test()
		{
			return "Singleton:Test()";
		}
	}
}
