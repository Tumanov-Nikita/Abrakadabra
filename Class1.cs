using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Podgotovka
{
    class Class1 : Interface1
    {
        private int[] mass;

        Random r = new Random();


        int[] arr;

        public int this[int index]
        {
            set { arr[index] = value; }
            get { return arr[index]; }
        }

        public Class1 (int a)
        {
            arr = new int[a];
            if (a < 10)
            {
                a = r.Next(10, 20);
            }
            mass = new int[a];
        }


        public string method1( int a)  
        {
            int res = 0;
            mass = new int[a];
            for (int i = 0; i < a; i++)
            {
                mass[i] = r.Next(1, 10);
            }

            for (int i = 0; i < mass.Length; i++)
            {
                if (24 % mass[i] == 0)
                {
                    res++;
                }
            }
            string result = res.ToString();
            return result;
        }



        public string method1()
        {
            int res = 0;
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(1, 10);
            }

            for (int i = 0; i < mass.Length; i++)
            {
                if (24 % mass[i] == 0)
                {
                    res++;
                }
            }
            string result = res.ToString();
            return result;
        }


        public string method2( int a, int b)
        {
            mass = new int[a];
            for (int i=0; i<a; i++)
            {
                mass[i] = r.Next(1, 10);
            }
            string result = "";
            for (int i = 0; i < mass.Length; i++)
            {
                if (b % mass[i] == 0 && mass[i]>0)
                {
                    result+=" "+ mass[i];
                }
            }

            return result;
        }

        public string method2( int b)
        {

            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = r.Next(1, 10);
            }
            string result = "";
            for (int i = 0; i < mass.Length; i++)
            {
                if (b % mass[i] == 0 && mass[i] > 0)
                {
                    result += " " + mass[i];
                }
            }

            return result;
        }

    }
}
