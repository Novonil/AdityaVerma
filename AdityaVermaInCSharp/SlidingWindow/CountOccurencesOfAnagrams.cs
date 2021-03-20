using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.SlidingWindow
{
	class CountOccurencesOfAnagrams
	{
		public static int countOfAnagrams(string str, string s)
		{
			
			int i = 0;
			int j = 0;
			int count = 0;
			int countOfNonZeroCharacters = 0;
			int shortStringLength = s.Length;
			int longStringLength = str.Length;
			Dictionary<char, int> freqMap = new Dictionary<char, int>();

			foreach(char c in s)
			{
				if(freqMap.ContainsKey(c))
				{
					freqMap[c]++;
				}
				else
				{
					freqMap.Add(c, 1);
				}
			}

			countOfNonZeroCharacters = freqMap.Count;

			while(j < longStringLength)
			{
				if(freqMap.ContainsKey(str[j]))
				{
					freqMap[str[j]]--;
					if(freqMap[str[j]] == 0)
					{
						countOfNonZeroCharacters--;
					}
				}

				if(j-i+1 < shortStringLength)
				{
					j++;
				}
				else if(j-i+1 == shortStringLength)
				{
					if(countOfNonZeroCharacters == 0)
					{
						count++;
					}
					if (freqMap.ContainsKey(str[i]))
					{
						freqMap[str[i]]++;
						if(freqMap[str[i]] == 1)
						{
							countOfNonZeroCharacters++;
						}
					}
					i++;
					j++;
				}
			}
			return count;
		}

		public static int countOfAnagramsBruteForce(string str, string s)
		{
			int count = 0;
			int countOfNonZeroElements = 0;
			int sizeOfShorterString = s.Length;
			Dictionary<char, int> freqMap = new Dictionary<char, int>();
			

			for(int i = 0; i< s.Length; i++)
			{
				if(freqMap.ContainsKey(s[i]))
				{
					freqMap[s[i]]++;
				}
				else
				{
					freqMap.Add(s[i], 1);
				}
			}

			countOfNonZeroElements = freqMap.Count;

			for (int i = 0; i<str.Length - sizeOfShorterString + 1; i++)
			{
				Dictionary<char, int> freq = new Dictionary<char, int>(freqMap);
				//freq = freqMap;
				int countOfNonZero = countOfNonZeroElements;
				for (int j = i; j < i+sizeOfShorterString; j++)
				{
					if(freq.ContainsKey(str[j]))
					{
						freq[str[j]]--;
						if(freq[str[j]] == 0)
						{
							countOfNonZero--;
						}
					}
					if(countOfNonZero == 0)
					{
						count++;
					}
				}
			}
			return count;
		}
	}
}
