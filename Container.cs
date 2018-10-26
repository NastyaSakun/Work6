using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Work6.Program;

namespace Work6
{
    class Container_for_Zal
    {

        public List<Inventar> cont;

        public Container_for_Zal()
        {
            cont = new List<Inventar>();
        }


        public void Push(Inventar El)
        {
            cont.Add(El);
        }

        public void Delete(Inventar El)
        {
            for (int i = 0; i < cont.Count; i++)
            {
                if (El.Equals(cont[i]))
                {
                    cont.RemoveAt(i);
                }
            }
        }

        public void Show()
        {
            for (int i = 0; i < cont.Count; i++)
            {
                cont[i].Print_();
            }
            Console.WriteLine();
        }

        public void Count_()
        {
            int Count = 0;
            for (int i = 0; i < cont.Count; i++)
            {
                Count = Count + cont[i].count;
            }
            Console.WriteLine($"{Count}");
        }
    }
}
