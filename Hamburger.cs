using System;
using System.Collections.Generic;

public class Hamburger
{
	public Hamburger(int smeat, List<int> sextras, int sbread)
	{
		this.meat = smeat;
		this.extras = sextras;
		this.bread = sbread;
	}
	public int meat { get; set; } // 0-meat, 1-lamb, 2-tofo
	public List<int> extras { get; set; } // 0-cucamber, 1-tomato, 2-lettuce, 3-pickels, 4-onion
	public int bread { get; set; } // 0- brown, 1-white
	public int price(Dictionary<string,int> ExtraPrices, Dictionary<int, string> IdxExtra) 
	{
		//Console.WriteLine(ExtraPrices["tomato"]);
		int rprice = new int();
		switch (this.meat) 
		{
			case 0:
				rprice=50;
				break;

			case 1:
				rprice=55;
				break;

			case 2:
				rprice =60;
				break;
		}

		//Console.WriteLine(this.extras.Count);
		foreach (int Iextra in this.extras) 
		{
			Console.WriteLine(Iextra);
			rprice += ExtraPrices[IdxExtra[Iextra]];
		}

		return rprice;
			
	}
}
