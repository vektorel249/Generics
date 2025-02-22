using Vektorel.Generics.PokemonGame.Abstractions;

namespace Vektorel.Generics.PokemonGame.Types
{
    class Raichu : Pokemon
    {
        public Raichu()
        {
            Type = Enums.PokemonType.Electricty;
            Name = nameof(Raichu);
            Health = 150;
            HitPower = 20;
        }
        public override Pokemon Evolve()
        {
            return this;
        }
    }
}
