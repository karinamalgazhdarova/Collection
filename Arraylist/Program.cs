using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList mylist = new ArrayList();
            mylist.Add(1);
            mylist.Add("два");
            mylist.Add(3);
            mylist.Add("четыре");
            mylist.Add(5);
            mylist.AddRange(new string[] { "вышел", "зайчик погулять" });


            foreach (object o in mylist)
            {
                Console.WriteLine(o);
            }

            mylist.Remove(1);
            mylist.Remove("вышел");
            mylist.Reverse();

            Console.WriteLine("-----------------------");

            for (int i = 0; i < mylist.Count; i++)
            {
                Console.WriteLine(mylist[i]);
            }

            Console.WriteLine("-----------------------");

            List<string> team = new List<string>();
            team.Insert(0, "Сергей");
            team.Insert(1, "Карина");
            team.Insert(2, "Оля");
            team.Insert(3, "Роман");
            team.RemoveAt(0);
            int index = team.IndexOf("Карина");
            

            Console.WriteLine(index);

            foreach(object o in team)
            {
                Console.WriteLine(o);
            }

           
            Console.ReadKey(); }


       

    }
}

