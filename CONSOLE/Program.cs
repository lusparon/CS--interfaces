using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CONSOLE
{
    class Program
    {
        static void Main(string[] args)
        {
            var f1 = args[0];
            var f2 = args[1];
            if (f1 == f2)
            {
                Console.WriteLine("Каталоги имеют одинаковые имена!");
                return;
            }
            if (!Directory.Exists(f1) || !Directory.Exists(f2))
            {
                Console.WriteLine("Несуществующий каталог!");
                return;
            }
       
            var files1 = Directory.GetFiles(f1).Select(s => s.Split('\\').Last());
            var files2 = Directory.GetFiles(f2).Select(s => s.Split('\\').Last());
            var absin2 = files1.Where(x => !files2.Contains(x)).OrderBy(x => x.ToLower());
            var absin1 = files2.Where(x => !files1.Contains(x)).OrderBy(x => x.ToLower());
            var inboth = files1.Where(x => files2.Contains(x)).OrderBy(x => x.ToLower());
            Console.WriteLine("Список файлов, имеющихся в первом каталоге и отсутствующих во втором : ");
            foreach (string s in absin2)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Список файлов, имеющихся во втором и отсутствующих в первом : ");
            foreach (string s in absin1)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("Список файлов,  содержащихся в обоих каталогах : ");
            foreach (string s in inboth)
            {
                Console.WriteLine(s);
            }
        }
    }
}

