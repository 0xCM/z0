//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Token
    {
        public uint Key {get;}

        public Sym Symbol {get;}

        public string Expression {get;}

        [MethodImpl(Inline)]
        public Token(uint key, Sym symbol, string expression)
        {
            Key = key;
            Symbol = symbol;
            Expression = expression;
        }

        public string Format()
            => string.Format("{0,-24} | {1,-5} | {2,-16} | '{3}'", Symbol.Type, Key, Symbol.Name, Expression);

        public override string ToString()
            => Format();
    }
}