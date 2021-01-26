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
        public static Literal<T> literal<T>(Name name, T value)
            where T : IComparable<T>
                => new Literal<T>(identifier(name), value);
    }
}