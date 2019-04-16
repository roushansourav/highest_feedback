using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace highest_feedback
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            int[] b = new int[n];
            int[] c = new int[2 * n];
            for (int i = 0; i < n; i++)
                a[i] = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
                b[i] = int.Parse(Console.ReadLine());
            int k = 0;

            for(int i=0;i<n-1;i=i+2)
            {
                bool match = false;
                for(int j=0;j<n-1;j=j+2)
                {
                    if(a[i]==b[j])
                    {
                        if(a[i+1]>b[j+1])
                        {
                            c[k] = a[i];
                            c[k + 1] = a[i + 1];
                            k = k + 2;
                            b[j] = 0;
                            b[j + 1] = 0;
                            match = true;
                        }
                        else
                        {
                            c[k] = b[j];
                            c[k + 1] = b[j + 1];
                            b[j] = 0;b[j+ 1] = 0;
                            k = k + 2;
                            match = true;
                        }
                    }
                }
                if(!match)
                {
                    c[k] = a[i];
                    c[k + 1] = a[i + 1];
                    k = k + 2;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (b[i] != 0)
                {
                    c[k] = b[i];
                    k++;
                }
            }
            for (int i = 0; c[i] != 0&&i<k; i++)
                Console.Write(c[i]+" ");
            Console.WriteLine();
            for (int i = 0; i < n; i++)
                Console.Write(b[i] + " ");
        }
    }
}
