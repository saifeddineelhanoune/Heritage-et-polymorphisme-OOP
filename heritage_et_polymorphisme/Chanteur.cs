using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage_et_polymorphisme
{
    class Chanteur : Personne 
    {
        public Chanteur(string n,string p,int a,string pro) : base(n,p,a,pro)
        {
            SetProfession(pro);
        }
        public override  string sePresenter()
        {
            return base.sePresenter() + "je suis un chanteur";
        }
    }
}
