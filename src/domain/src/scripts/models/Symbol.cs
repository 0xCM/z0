//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial struct Scripts
    {
        public readonly struct Symbol
        {
            public string Name {get;}

            [MethodImpl(Inline)]
            public Symbol(string name)
                => Name = name;

            [MethodImpl(Inline)]
            public Symbol(char name)
                => Name = name.ToString();

            [MethodImpl(Inline)]
            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Symbol(string name)
                => new Symbol(name);

            [MethodImpl(Inline)]
            public static implicit operator Symbol(char name)
                => new Symbol(name);

            [MethodImpl(Inline)]
            public static Symbol operator + (Symbol a, Symbol b)
                => combine(a,b);
        }
    }
}