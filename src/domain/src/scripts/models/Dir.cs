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
        public struct Dir : IScriptVar<Var>
        {
            public Symbol Symbol {get;}

            public VarValue Value {get;}

            [MethodImpl(Inline)]
            public Dir(Symbol name, VarValue value)
            {
                Symbol = name;
                Value = value;
            }

            [MethodImpl(Inline)]
            public static implicit operator Dir((Symbol symbol, VarValue value) src)
                => new Dir(src.symbol, src.value);

            [MethodImpl(Inline)]
            public static implicit operator Var(Dir src)
                => new Dir(src.Symbol, src.Value);

            [MethodImpl(Inline)]
            public static Dir operator + (Dir a, Dir b)
                => combine(a,b);
        }
    }
}