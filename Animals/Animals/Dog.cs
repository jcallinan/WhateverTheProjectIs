using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog: DomesticMammal
    {
        protected override int NumberOfLegs { get { return 4; } }
        public virtual string Breed { get { return "Just a dog"; } }
        public virtual string BreedFamily { get { return "Dog"; } }

        private void Init()
        {
            Console.WriteLine("Dog created");
        }
        public Dog(string name, int age, string favoriteToy, bool isPregnant): base(name,age,favoriteToy,isPregnant)
        {
            this.Init();
        }
        public Dog(string name, int age, string favoriteToy) : base(name, age, favoriteToy)
        {
            this.Init();
        }
        public void PrintBreed()
        {
            Console.WriteLine(this.Breed);

        }
        public void PrintBreedFamily()
        {
            Console.WriteLine(this.BreedFamily);

        }
        public override void Talk()
        {
            this.Bark();
        }
        public void Bark()
        {
            PrintBark(1, null, false);
        }
        private void PrintBark(int times, DomesticMammal otherDomesticMammal,bool isAngry)
        {

        }
    }
}
