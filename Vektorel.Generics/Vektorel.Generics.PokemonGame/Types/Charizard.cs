using Vektorel.Generics.PokemonGame.Abstractions;

namespace Vektorel.Generics.PokemonGame.Types
{
    class Charizard : Pokemon
    {
        public Charizard()
        {
            Type = Enums.PokemonType.Fire | Enums.PokemonType.Flying;
            Name = nameof(Charizard);
        }
        public override Pokemon Evolve()
        {
            return this;
        }
    }
}
