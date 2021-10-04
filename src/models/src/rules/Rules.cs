//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly partial struct Rules
    {

        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Binding<T> bind<T>(Var var, T val)
            => var.Bind(val);

        public static Grammar grammar(Label name)
            => new Grammar(name);
    }
}