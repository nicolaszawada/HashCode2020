using System.Collections.Generic;
using System.Linq;

namespace PaulsBoutique.HashCode.Models
{
    public class Boutique
    {
        public Boutique()
        {

        }

        public int NumberOfWorkers { get; set; }
        public int NumberOfIngredients { get; set; }

        public List<Burger> Burgers { get; set; } = new List<Burger>();

        public Burger GetBestBurger()
        {
            return Burgers.SingleOrDefault(x => x.Prop1 == "Conan");
        }
    }
}
