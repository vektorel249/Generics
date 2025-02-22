using Vektorel.Generics.PokemonGame.Abstractions;

namespace Vektorel.Generics.PokemonGame.Types
{
    class Charmeleon : Pokemon
    {
        public Charmeleon()
        {
            Type = Enums.PokemonType.Fire;
            Name = nameof(Charmeleon);
        }
        public override Pokemon Evolve()
        {
            return new Charizard();
        }
    }
}
