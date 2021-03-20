using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class PickToys
	{
		public static int countOfToysBruteForce(int size, List<string> toys, int maxToys)
		{
			int maxCountOfToys = int.MinValue;
			for(int windowSize = 1; windowSize < size; windowSize++)
			{
				for(int left = 0; left < size - windowSize + 1; left++)
				{
					Dictionary<string, int> toyFreq = new Dictionary<string, int>();
					for(int right = left; right < left + windowSize; right++)
					{
						if(toyFreq.ContainsKey(toys[right]))
						{
							toyFreq[toys[right]]++;
						}
						else
						{
							toyFreq.Add(toys[right], 1);
						}
					}
					if(toyFreq.Count == maxToys)
					{
						maxCountOfToys = Math.Max(maxCountOfToys, windowSize);
					}
				}
			}
			return maxCountOfToys;
		}

		public static int countOfToys(int size, List<string> toys, int K)
		{
			int left = 0;
			int right = 0;
			int maxCountOfToys = int.MinValue;
			Dictionary<string, int> toyFreq = new Dictionary<string, int>();


			while(right<size)
			{
				if(toyFreq.ContainsKey(toys[right]))
				{
					toyFreq[toys[right]]++;
				}
				else
				{
					toyFreq.Add(toys[right],1);
				}
				if(toyFreq.Count == K)
				{
					maxCountOfToys = Math.Max(maxCountOfToys, right - left + 1);
				}
				else if(toyFreq.Count > K)
				{
					while(toyFreq.Count > K)
					{
						if(toyFreq.ContainsKey(toys[left]))
						{
							toyFreq[toys[left]]--;
						}
						if(toyFreq[toys[left]] == 0)
						{
							toyFreq.Remove(toys[left]);
						}
						left++;
					}
					if(toyFreq.Count == K)
					{
						maxCountOfToys = Math.Max(maxCountOfToys, right - left + 1);
					}
				}
				right++;
			}

			return maxCountOfToys;
		}
	}
}
