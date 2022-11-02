using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace heritage_et_polymorphisme
{
    class Personne
    {
        private string nom;
        private string prenom;
        private int age;
        private string profession;
        private string a;
        public void SetProfession(string p)
        {
            this.profession = p;
        }
        public string Nom
        {
            get
            {
                return nom;
            }

            set
            {
                nom = value;
            }
        }

        public string Prenom
        {
            get
            {
                return prenom;
            }

            set
            {
                prenom = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Profession
        {
            get
            {
                return profession;
            }

            set
            {
                profession = value;
            }
        }
        public Personne() { }
        public Personne(string nom,string prenom,int age)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.profession = "";
        }
        public Personne(string nom, string prenom)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = -1;
            this.profession = "";
        }
        public Personne(string nom, string prenom, int age,string profession)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.age = age;
            this.profession = profession;
        }

        public Personne(string nom, string prenom, string a) : this(nom, prenom)
        {
            this.a = a;
        }

        public string sePresenter()
        {
            if(this.age == -1)
            {
                return "je m'appelle " + this.nom + this.prenom;
            }
            else
            {
                return "je m'appelle " + this.nom + this.prenom + " et j'ai " + this.age.ToString() + " ans";
            }
        }
            
    }
}
