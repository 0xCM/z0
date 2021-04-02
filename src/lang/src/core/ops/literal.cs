//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Lang
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct lang
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<T> literal<T>(Identifier name, Constant<T> value)
            => new Literal<T>(name, value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<T> literal<T>(Name name, T value)
            => new Literal<T>(name, constant(value));
    }
}