using System;

namespace StaticPreexecutionTest
{
	class Program
	{
		static void Main(string[] args) {
			Console.WriteLine("Main: before Singleton usage");
			Console.WriteLine(Singleton.Instance.Test());
			//Console.WriteLine(LazySingleton.Instance.LazyTest());
			Console.WriteLine("Main: after Singleton usage");
			Console.ReadKey();
		}
	}
}
