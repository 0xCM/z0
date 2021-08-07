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
        public K Kind {get;}

        public string Expression {get;}

        [MethodImpl(Inline)]
        public Token(K kind, string expression)
        {
            Kind = kind;
            Expression = expression;
        }

        public string Identifier
        {
            [MethodImpl(Inline)]
            get => Kind.ToString();
        }

        public uint Key
        {
            [MethodImpl(Inline)]
            get => bw32(Kind);
        }

        public string Format()
            => string.Format("{0,-2} => {1} => '{2}'", Key, Identifier, Expression);

        public override string ToString()
            => Format();

        [MethodImpl(Inline)]
        public static implicit operator Token<K>((K kind, string expr) src)
            => new Token<K>(src.kind, src.expr);

        [MethodImpl(Inline)]
        public static implicit operator Token(Token<K> src)
            => new Token(src.Key, src.Identifier, src.Expression);
    }
}