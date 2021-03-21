using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class LongestSubstringWithKUniqueCharacters
	{
		public static int longestSubstring(int size, string str, int K)
		{
			int i = 0;
			int j = 0;
			int count = 0;
			int maxLengthOfSubstring = int.MinValue;
			Dictionary<char, int> charMap = new Dictionary<char, int>();

			while(j<size)
			{
				if(charMap.ContainsKey(str[j]))
				{
					charMap[str[j]]++;
				}
				else
				{
					charMap.Add(str[j], 1);
				}
				count = charMap.Count;

				if (count == K)
				{
					maxLengthOfSubstring = Math.Max(maxLengthOfSubstring, j - i + 1);

				}
				else
				{
					while (count > K)
					{
						charMap[str[i]]--;
						if (charMap[str[i]] == 0)
						{
							count--;
							charMap.Remove(str[i]);
						}
						i++;
					}
					if (count == K)
					{
						maxLengthOfSubstring = Math.Max(maxLengthOfSubstring, j - i + 1);
						
					}
				}
				j++;
			}
			return maxLengthOfSubstring;
		}

		public static int longestSubstringBruteForce(int size, string str, int K)
		{
			int maxSubstring = 0;

			for(int windowSize = 1; windowSize <= size; windowSize++)
			{
				for(int left = 0; left < size - windowSize + 1; left++)
				{
					Dictionary<char, int> charMap = new Dictionary<char, int>();
					for (int right = left; right < left + windowSize; right++)
					{
						if(charMap.ContainsKey(str[right]))
						{
							charMap[str[right]]++;
						}
						else
						{
							charMap.Add(str[right], 1);
						}
					}
					if(charMap.Count == K)
					{
						maxSubstring = windowSize;
						break;
					}
				}
			}
			return maxSubstring;
		}
	}
}
