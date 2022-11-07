using System;

namespace lab_function
{
	class Program
	{
		static int Add(int input1, int input2)
		{
			return input1 + input2;
		}
		static void Main(string[] args)
		{
			int sum = Add(1, 10);
			Console.WriteLine("Sum: " + sum);  
		}

	}
}