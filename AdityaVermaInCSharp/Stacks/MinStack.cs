using System;
using System.Collections.Generic;
using System.Text;

namespace AdityaVermaInCSharp.Stacks
{
	class MinStack
	{
		static Stack<int> stack = new Stack<int>();
		static Stack<int> supportingStack = new Stack<int>();

		public static void Push(int x)
		{
			if(stack.Count == 0)
			{
				stack.Push(x);
				supportingStack.Push(x);
				return;
			}
			stack.Push(x);
			if(x <= supportingStack.Peek())
			{
				supportingStack.Push(x);
			}
		}
		public static int Pop()
		{
			if(stack.Count == 0)
			{
				return -1;
			}

			int poppedElement = stack.Peek();
			stack.Pop();

			if(supportingStack.Peek() == poppedElement)
			{
				supportingStack.Pop();
			}
			return poppedElement;
		}

		public static int Peek()
		{
			if (stack.Count == 0)
				return -1;
			return stack.Peek();
		}

		public static int Min()
		{
			if (stack.Count == 0)
				return -1;
			return supportingStack.Peek();
		}

		public static bool IsEmpty()
		{
			if (stack.Count == 0)
				return true;
			return false;
		}
	}
}
