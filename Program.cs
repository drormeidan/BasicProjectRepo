using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BasicProject
{
    class Program
    {
        public void SubmitInvitation() 
        {
            Console.WriteLine("Welcome to Hamburger resturant");
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
                    Console.WriteLine("choose extra: 0-cucamber, 1-tomato, 2-lettuce, 3-pickels, 4-onion");
                    sextras.Add(Convert.ToInt32(Console.ReadLine()));
                    Console.WriteLine("add extra?: 0-No, 1-Yes");
                    contE = Convert.ToInt32(Console.ReadLine());
                }

                hamburgers.Add(new Hamburger(smeat, sextras, sbread));
                sextras.Clear();
                Console.WriteLine("add diner?: 0-No, 1-Yes");
                contD = Convert.ToInt32(Console.ReadLine());
            }

            int Tprice = new int();
            Tprice = 0;
            foreach (Hamburger item in hamburgers)
            {
                Tprice += item.price();
            }

            Console.WriteLine("The total price");
            Console.WriteLine(Tprice);

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.SubmitInvitation();
        }
    }
}
