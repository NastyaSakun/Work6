using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Work6.Program;

namespace Work6
{
    class Controller : Container_for_Zal
    {

        public Container_for_Zal cont1 = new Container_for_Zal();

        public Controller(Container_for_Zal cont1)
        {
            this.cont1 = cont1;
        }

        public void Sort()
        {
            Inventar temp;
            for (int i = 0; i < cont1.cont.Count - 1; i++)
            {
                for (int j = i + 1; j < cont1.cont.Count; j++)
                {
                    if (cont1.cont[i].count > cont1.cont[j].count)
                    {
                        temp = cont1.cont[i];
                        cont1.cont[i] = cont1.cont[j];
                        cont1.cont[j] = temp;
                    }
                }
            }
            Console.WriteLine("\0Отсортированные вещи:");
            for (int f = 0; f < cont1.cont.Count; f++)
            {
                cont1.cont[f].Print_();
            }
        }
    }
}
