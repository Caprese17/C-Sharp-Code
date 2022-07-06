using System;

public class Cookie
{
	public Cookie()
	{ }
		public string CookieName;
		public int CookieAmt;
		public double CookiePrice;
		public static int count = 0;

	public Cookie(string name, int amt, double price)
    {
		this.CookieName = name;
		this.CookieAmt = amt;
		this.CookiePrice = price;
			//count++;
    }
	public void Display()
    {
		Console.WriteLine(CookieName + "          " + CookieAmt);

    }

	}

