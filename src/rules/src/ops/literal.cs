//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Rules
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<T> literal<T>(string name, Constant<T> value)
            => new Literal<T>(name, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<T> literal2<T>(string name, T value)
            => new Literal<T>(name, constant(value));
    }
}