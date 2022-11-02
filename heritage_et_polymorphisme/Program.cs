using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage_et_polymorphisme
{
    class Program
    {
        static void Main(string[] args)
        {

            string n, p, pro;
            int a;
            Console.WriteLine("donner le nom puis le prenom puis l'age puis la profession");
            n = Console.ReadLine();
            p = Console.ReadLine();
            a = int.Parse(Console.ReadLine());
            pro = Console.ReadLine();
            Personne p1 = new Personne(n, p, a,pro);
            Console.WriteLine(p1.sePresenter());
            Chanteur C1 = new Chanteur("ayoub","alaoui",17);
            Console.WriteLine(C1.sePresenter());
            Console.WriteLine(C1.SetProfession(pro));
            Console.ReadKey();

        }
    }
}
