namespace AlgorithmsAndStructuresDataLib
{
	public class ThreeSum
	{
		public static int Count(int[] a)
		{
			int n = a.Length;
			int counter = 0;

			// 4 5 -1 -5 0 3 2
			// 4 5 -1
			// 4 5 -5
			// 4 5 0
			// 4 5 3
			// 4 5 2
			// 4 -1 -5
			// 4 -1 0
			// 4 -1 3
			// 4 -1 2

			for (int i = 0; i < n; i++)
			{
				for (int j = i + 1; j < n; j++)
				{
					for (int k = j + 1; k < n; k++)
					{
						if (a[i] + a[j] + a[k] == 0)
						{
							counter++;
						}
					}
				}
			}

			return counter;
		}
	}
}