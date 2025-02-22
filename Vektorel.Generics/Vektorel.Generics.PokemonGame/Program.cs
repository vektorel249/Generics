using System.Drawing;
using System.Security.Cryptography;
using Vektorel.Generics.PokemonGame.Abstractions;
using Vektorel.Generics.PokemonGame.Enums;
using Vektorel.Generics.PokemonGame.Types;

namespace Vektorel.Generics.PokemonGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var bag = new PokeBag<Pokemon>();
            bag.Catch(new Pikachu());
            bag.Catch(new Charmender());
            bag.Catch(new Raichu());

            var selected = bag.Find("Raichu");
        }
    }

    class PokeBag<T> where T: Pokemon
    {
        private Dictionary<PokemonType, List<Pokemon>> pokemons;
        public PokeBag()
        {
            pokemons = new Dictionary<PokemonType, List<Pokemon>>();
        }
        public void Catch(T pokemon)
        {
            if (pokemons.ContainsKey(pokemon.Type))
            {
                pokemons[pokemon.Type].Add(pokemon);
            }
            else
            {
                pokemons.Add(pokemon.Type, new List<Pokemon> { pokemon });
            }
        }

        public T Find(string name)
        {
            //Fragman
            var allPokemons = pokemons.Values.SelectMany(s => s);
            var selected = allPokemons.Where(f => f.Name == name).First();
            return (T)selected;
        }
    }
}
