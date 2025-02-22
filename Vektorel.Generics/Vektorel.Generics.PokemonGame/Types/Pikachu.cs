using Vektorel.Generics.PokemonGame.Abstractions;

namespace Vektorel.Generics.PokemonGame.Types
{
    class Pikachu : Pokemon
    {
        public Pikachu()
        {
            Type = Enums.PokemonType.Electricty;
            Name = nameof(Pikachu);
        }
        public override Pokemon Evolve()
        {
            return new Raichu();
        }
    }
}
