using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace piskvorky.Tridy
{
    public class Player
    {
        public string Name { get; }
        public Symbol Symbol { get; }

        public Player(string name, Symbol symbol)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Jméno hráče nesmí být prázdné.", "name");
            if (symbol == Symbol.None)
                throw new ArgumentException("Hráč musí mít symbol X nebo O.", "symbol");

            Name = name;
            Symbol = symbol;
        }
    }
}
