using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Headers;

namespace BasicProject
{
    class Program
    {
        public void SubmitInvitation(Dictionary<string, int> ExtraPrices, Dictionary<int, string> IdxExtra) 
        {
            Console.WriteLine("Welcome to Hamburger resturant");
            //Console.WriteLine(ExtraPrices["tomato"]);
            List<Hamburger> hamburgers = new List<Hamburger>();
            int contD = new int();
            contD = 1;
            int smeat = new int();
            List<int> sextras = new List<int>();
            int sbread = new int();
            int contE = new int();

            while (Convert.ToBoolean(contD))
            {
                Console.WriteLine("choose meat: 0-meat, 1-lamb, 2-tofo");
                smeat = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("choose bread: 0- brown, 1-white");
                sbread = Convert.ToInt32(Console.ReadLine());
                contE = 1;
                while (Convert.ToBoolean(contE))
                {
                    // Console.WriteLine("choose extra: 0-cucamber, 1-tomato, 2-lettuce, 3-pickels, 4-onion");
                    foreach( KeyValuePair<int,string> valuePair in IdxExtra) 
                    {
                        Console.WriteLine("{0} -{1}", valuePair.Key, valuePair.Value);
                    }
                    sextras.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("add extra?: 0-No, 1-Yes");
                    contE = Convert.ToInt32(Console.ReadLine());
                }

                hamburgers.Add(new Hamburger(smeat, sextras, sbread));
                sextras = new List<int>();
                sextras.Clear();
                Console.WriteLine("add diner?: 0-No, 1-Yes");
                contD = Convert.ToInt32(Console.ReadLine());
            }

            int Tprice = new int();
            Tprice = 0;
            foreach (Hamburger item in hamburgers)
            {
                Tprice += item.price(ExtraPrices,IdxExtra);
            }

            Console.WriteLine("The total price");
            Console.WriteLine(Tprice);

        }

        public void ManagerRules(ref Dictionary<string, int> ExtraPrices, ref Dictionary<int, string> IdxExtra) 
        {
            int IdxOperation = new int();
            int COperation = new int();
            int ExtraChange = new int();
            int PriceChange = new int();
            string NewExtraName = new string("aaa");
            int NewExtraPrice = new int();
            COperation = 1;
            while (Convert.ToBoolean(COperation)) 
            {
                Console.WriteLine("choose operation: 0-change extra prices, 1-new extra");
                IdxOperation = Convert.ToInt32(Console.ReadLine());
                switch (IdxOperation) 
                {
                    case 0:
                        Console.WriteLine("choose which extra to change:");
                        foreach (KeyValuePair<int, string> valuePair in IdxExtra)
                        {
                            Console.WriteLine("{0} -{1}", valuePair.Key, valuePair.Value);
                        }
                        ExtraChange = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("new price:");
                        PriceChange = Convert.ToInt32(Console.ReadLine());
                        ExtraPrices[IdxExtra[ExtraChange]] = PriceChange;
                        break;

                    case 1:
                        Console.WriteLine("the name of the new extra:");
                        NewExtraName = Console.ReadLine();
                        Console.WriteLine("the price of new extra:");
                        NewExtraPrice = Convert.ToInt32(Console.ReadLine());
                        ExtraPrices.Add(NewExtraName, NewExtraPrice);
                        IdxExtra.Add(IdxExtra.Count, NewExtraName);
                        break;
                }

                Console.WriteLine("add operation?: 0-No, 1-Yes");
                COperation = Convert.ToInt32(Console.ReadLine());

            }

        }
        static void Main(string[] args)
        {
            Dictionary<string, int> ExtraPrices = new Dictionary<string, int>();
            ExtraPrices.Add("cucambers", 0);
            ExtraPrices.Add("tomato", 0);
            ExtraPrices.Add("lettuce", 0);
            ExtraPrices.Add("pickels", 0);
            ExtraPrices.Add("onion", 0);
            Dictionary<int, string> IdxExtra = new Dictionary<int, string>();
            IdxExtra.Add(0, "cucambers");
            IdxExtra.Add(1, "tomato");
            IdxExtra.Add(2, "lettuce");
            IdxExtra.Add(3, "pickels");
            IdxExtra.Add(4, "onion");
            
            Program p = new Program();
            p.ManagerRules(ref ExtraPrices, ref IdxExtra);
            //Console.WriteLine(ExtraPrices["tomato"]);
            p.SubmitInvitation(ExtraPrices,IdxExtra);
        }
    }
}
