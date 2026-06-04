using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calcular
    {
        //ejemplo recursivo 
        //forma 1
        public void Imprimir1(int n)
        {
            if (n > 0)
            {
                Imprimir1(n - 1);
            }
            Console.WriteLine(n);
        }
        //forma 2
        public void Imprimir2(int n) 
        {
            int m;
            Console.WriteLine(n);
            if (n < m) 
            {
                Imprimir2 (n + 1);

            }
        }
        //forma 3
        public void Imprimir3(int n)
        {
            for (int i = 0; i <= n; i++) 
            {
                Console.WriteLine(i);
            }
        }
        public void quickSort(int[]v, int ini, int F)
        {
            ini = ini + 1;
            int D = v[ini];
            while ()
            
        }


        
    }
}
