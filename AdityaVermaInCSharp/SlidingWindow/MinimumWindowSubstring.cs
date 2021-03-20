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
			Dictionary<char, int> targetCharMap = new Dictionary<char, int>();

			foreach(char c in target)
			{
				if(targetCharMap.ContainsKey(c))
				{
					targetCharMap[c]++;
				}
				else
				{
					targetCharMap.Add(c,1);
				}
			}

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
	}
}
