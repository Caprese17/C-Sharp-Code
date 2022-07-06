using System;
namespace Program
{
	class leapyear
	{
		static void Main(string[] args)
		{
			leapyear obj = new leapyear();
			obj.readdata();
			obj.leap();
		}
		int y;
		public void readdata ()
		{
			Console.WriteLine("Enter the Year in Four Digits : ");
			y = Convert.ToInt32 (Console.ReadLine());
		}
		public void leap()
		{
			if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
			{
				Console.WriteLine("{0} is a Leap Year", y);
			}
			else
			{
				Console.WriteLine("{0} is not a Leap Year", y);
			}
			Console.ReadLine();
		}
	}
}
