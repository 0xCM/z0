//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Scripts
    {
        public struct Var : IScriptVar<Var>
        {
            public Symbol Symbol {get;}

            public VarValue Value {get;}

            [MethodImpl(Inline)]
            public Var(Symbol name, VarValue value)
            {
                Symbol = name;
                Value = value;
            }

            [MethodImpl(Inline)]
            public string Format()
                => format(this);

            public override string ToString()
                => Format();

            [MethodImpl(Inline)]
            public static implicit operator Var((Symbol symbol, VarValue value) src)
                => new Var(src.symbol, src.value);
        }
    }
}