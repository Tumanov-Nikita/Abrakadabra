using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka
{
    class Class2 : Interface1
    {
        LinkedList<int> list;

        Random r = new Random();

        public int this[int index]
        {
            get
            {
                return list.ElementAt(index);
            }
            set
            {
                int k = 0;
                LinkedList<int> temp = new LinkedList<int>();
                foreach (int val in list)
                {
                    if (k != index)
                    {
                        temp.AddLast(val);
                    }
                    else
                    {
                        temp.AddLast(value);
                    }
                    k++;
                }
                list = new LinkedList<int>(temp);
            }
        }



        public Class2(int a)
        {
            list = new LinkedList<int>();
            for (int i = 0; i < a; i++)
                list.AddLast(r.Next() % 10);
        }






        public string method1()
        {
            int res = 0;
            for (int i = 0; i < list.Count; i++)
            {
                list.AddLast(r.Next(1, 10));
            }

            for (int i = 0; i < list.Count; i++)
            {
                if (24 % (int)list.ElementAt(i) == 0)
                {
                    res++;
                }
            }
            string result = res.ToString();
            return result;
        }



        public string method2(int b)
        {

            for (int i = 0; i < list.Count; i++)
            {
                list.AddLast(r.Next(1, 10));
            }
            string result = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (b % (int)list.ElementAt(i) == 0 && (int)list.ElementAt(i) > 0)
                {
                    result += " " + (int)list.ElementAt(i);
                }
            }

            return result;
        }

    }
}
