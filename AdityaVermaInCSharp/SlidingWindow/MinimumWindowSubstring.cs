using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class MinimumWindowSubstring
	{
		public static int minimumSubstring(int size, string source, string target)
		{
			int left = 0;
			int right = 0;
			int leastSubsting = int.MaxValue;
			int count = 0;
			Dictionary<char, int> targetCharMap = returnFrequencyCountOfString(target);

			count = targetCharMap.Count;

			while(right < size)
			{
				if(targetCharMap.ContainsKey(source[right]))
				{
					targetCharMap[source[right]]--;
					if(targetCharMap[source[right]] == 0)
					{
						count--;
					}
				}
				if(count == 0)
				{
					while(count == 0)
					{
						leastSubsting = Math.Min(leastSubsting, right - left + 1);
						if (targetCharMap.ContainsKey(source[left]))
						{
							targetCharMap[source[left]]++;
							if(targetCharMap[source[left]] == 1)
							{
								count++;
							}
						}
						left++;
					}
				}
				right++;
			}
			return leastSubsting;
		}


		public static int minimumSubstringBruteForce(int size, string source, string target)
		{
			Dictionary<char, int> charMap = returnFrequencyCountOfString(target);

			int minimumSubstring = int.MaxValue;


			for(int windowSize = 1; windowSize < size; windowSize++)
			{
				for (int left = 0; left < size - windowSize + 1; left++)
				{
					Dictionary<char, int> tempMap = new Dictionary<char, int>(charMap);
					int count = tempMap.Count;

					for(int right = left; right < left + windowSize; right++)
					{
						if(tempMap.ContainsKey(source[right]))
						{
							tempMap[source[right]]--;
							if(tempMap[source[right]] == 0)
							{
								count--;
							}
						}
						if(count == 0)
						{
							minimumSubstring = Math.Min(minimumSubstring, windowSize);
						}
					}
				}
			}
			return minimumSubstring;
		}

		public static Dictionary<char,int> returnFrequencyCountOfString(string target)
		{
			Dictionary<char, int> charMap = new Dictionary<char, int>();
			foreach (char c in target)
			{
				if (charMap.ContainsKey(c))
				{
					charMap[c]++;
				}
				else
				{
					charMap.Add(c, 1);
				}
			}
			return charMap;
		}
	}
}
