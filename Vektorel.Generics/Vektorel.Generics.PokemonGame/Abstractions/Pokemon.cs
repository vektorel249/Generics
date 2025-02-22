using Vektorel.Generics.PokemonGame.Enums;

namespace Vektorel.Generics.PokemonGame.Abstractions
{
    abstract class Pokemon
    {
        protected Pokemon()
        {
            HitPower = 10;
            Health = 100;
        }
        public string Name { get; set; }
        public PokemonType Type { get; set; }
        public abstract Pokemon Evolve();
        public decimal HitPower { get; set; }
        public decimal Health { get; set; }
    }
}
