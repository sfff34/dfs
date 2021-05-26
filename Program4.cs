using System;
using System.Collections;

namespace ConsoleApp39
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList fh = new ArrayList() { 'q', 21, 'n', 6, 'U', 2, 'Y', 'k', 13, 'y', 'a', 'Z', 675, 'p' };
            string j = " ";
            for (int i = 0; i < fh.Count; i++)
            {
                j += fh[i] + "  ";
            }

            ArrayList nl = new ArrayList();
            string a = "";
            for (int i = 0; i < fh.Count; i++)
            {
                if (Char.IsNumber(fh[i].ToString().ToCharArray()[0]) == false)
                {
                    if (Char.IsUpper(fh[i].ToString().ToCharArray()[0]))
                    {
                        nl.Add(fh[i]);
                    }
                    fh.RemoveAt(i);
                    i--;
                }
                else
                {
                    a += fh[i] + "  ";
                }
            }
            Console.WriteLine("Цифры: " + a);
            a = "";
            for (int i = 0; i < nl.Count; i++)
            {
                a += nl[i] + "  ";
            }
            Console.WriteLine("Заглавные буквы: " + a);
        }
    }
}
