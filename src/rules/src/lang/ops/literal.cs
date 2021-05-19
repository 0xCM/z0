//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct lang
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<T> literal<T>(string name, Constant<T> value)
            => new Literal<T>(name, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<T> literal<T>(string name, T value)
            => new Literal<T>(name, constant(value));
    }
}