using Vektorel.Generics.PokemonGame.Abstractions;

namespace Vektorel.Generics.PokemonGame.Types
{
    class Charmender : Pokemon
    {
        public Charmender()
        {
            Type = Enums.PokemonType.Fire;
            Name = nameof(Charmender);
        }
        public override Pokemon Evolve()
        {
            return new Charmeleon();
        }
    }
}
