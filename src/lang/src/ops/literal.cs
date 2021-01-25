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
        [MethodImpl(Inline)]
        public static Literal<I,T> literal<I,T>(I id, T value)
            where I : IComparable<I>
                => new Literal<I,T>(id,value);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Literal<Name,T> literal<T>(string id, T value)
            where T : IComparable<T>
                => new Literal<Name,T>(identifier(id), value);
    }
}