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
        public static LiteralSeq<T> literals<T>(params NamedValue<T>[] src)
            => new LiteralSeq<T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NamedValue<T> literal<T>(string name, T value)
            => new NamedValue<T>(name,value);
    }
}