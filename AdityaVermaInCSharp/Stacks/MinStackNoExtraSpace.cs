using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Stacks
{
	class MinStackNoExtraSpace
	{
		static int min;
		static Stack<int> stack = new Stack<int>();

		public static void Push(int x)
		{
			if (stack.Count == 0)
			{
				stack.Push(x);
				return;
			}
			if(x < min) 
			{
				int temp = 2 * x - min;
				min = x;
				x = temp;
			}
			stack.Push(x);
		}

		public static int Pop()
		{
			if (stack.Count == 0)
				return int.MaxValue;

			int poppedElement = stack.Peek();
			stack.Pop();
			if(poppedElement < min)
			{
				int temp = min;
				min = 2 * min - poppedElement;
				poppedElement = temp;
			}
			return poppedElement;
		}

		public static int Peek()
		{
			return stack.Count == 0 ? int.MaxValue : stack.Peek() < min ? min : stack.Peek() ;
		}



		public static int Min()
		{
			return stack.Count == 0 ? int.MaxValue : min;
		}


		public static bool IsEmpty()
		{
			return stack.Count == 0 ? true : false;
		}

	}
}
