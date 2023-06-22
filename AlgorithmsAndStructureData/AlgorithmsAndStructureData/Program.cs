using AlgorithmsAndStructuresDataLib;
using System.Diagnostics;

namespace AlgorithmsAndStructureData
{
	internal class Program
	{
		static void Main(string[] args)
		{
			TestThreeSum();
			Console.Read();
		}

		private static void TestThreeSum()
		{
			var ints = In.ReadInts("D:\\AlgorithmsAndStructureDatasCS\\AlgorithmsAndStructureData\\AlgorithmsAndStructureData\\bin\\Release\\net6.0\\Data\\8Kints.txt").ToArray();
			var watch = new Stopwatch();
			watch.Start();

			var triplets = ThreeSum.Count(ints);

			watch.Stop();

			Console.WriteLine($"Count of \"zero-sum\" triplets: {triplets}");
			Console.WriteLine($"Time: {watch.Elapsed}");
		}
	}
}