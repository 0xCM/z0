//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public readonly struct Token<K>
        where K : unmanaged
    {
        public uint Key {get;}

        public Sym<K> Symbol {get;}

        public string Expression {get;}

        [MethodImpl(Inline)]
        public Token(uint key, Sym<K> symbol, string expression)
        {
            Key = key;
            Symbol = symbol;
            Expression = expression;
        }

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => Symbol.Name;
        }

        public string Format()
            => string.Format("{0,-24} | {1,-5} | {2,-16} | '{3}'", Symbol.Type, Key, Symbol.Name, Expression);

        public override string ToString()
            => Format();

         [MethodImpl(Inline)]
       public static implicit operator Token(Token<K> src)
            => new Token(src.Key, src.Symbol, src.Expression);
    }
}