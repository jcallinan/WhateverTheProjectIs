using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class DomesticMammal: Mammal
    {
        public string Name { get; private set; }
        public string FavoriteToy { get; set; }
        private void Init(string name, string favoriteToy)
        {
            this.Name = name;
            this.FavoriteToy = favoriteToy;
            Console.WriteLine("DomesticMammal Created");
        }
        public virtual void Talk()
        {
            Console.WriteLine(String.Format("{0}: talks", this.Name));
        }
       public DomesticMammal(string name, int age, string favoriteToy) : base(age)
        {
            this.Init(name, favoriteToy);
        }
        public DomesticMammal(string name, int age, string favoriteToy, bool isPregnant) : base(age, isPregnant)
        {
            this.Init(name, favoriteToy);
        }

    }
}
