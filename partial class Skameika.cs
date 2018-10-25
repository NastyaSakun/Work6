using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Work6;

namespace Work6
{
    public partial class Skameika

    {
        public int E = 28;

        public override string ToString()
        {
            return ($"\0Информация об объекте:\0{E},\0{E.Equals(6)},\0{E.GetHashCode()},\0{E.GetType()}");
        }
    }
}
