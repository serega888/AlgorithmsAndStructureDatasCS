using AlgorithmsAndStructuresDataLib;
using System.Diagnostics;

namespace AlgorithmsAndStructureData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TestTreeSum();
			Console.Read();
		}

		private static void TestTreeSum()
		{
			var ints = In.ReadInts("D:\\AlgorithmsAndStructureDatasCS\\AlgorithmsAndStructureData\\AlgorithmsAndStructureData\\bin\\Release\\net6.0\\Data\\1Kints.txt").ToArray();
			var watch = new Stopwatch();
			watch.Start();

			var triplets = ThreeSum.Count(ints);

			watch.Stop();

			Console.WriteLine($"Count of \"zero-sum\" triplets: {triplets}");
			Console.WriteLine($"Time: {watch.Elapsed}");
		}
	}
}