//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Symbols
    {
        [MethodImpl(Inline)]
        public static Symbols<E> index<E>()
            where E : unmanaged, Enum
                => SymCache<E>.get();

        public static SymIndex untyped(Type src)
        {
            var factory = typeof(Symbols).Method("index").MakeGenericMethod(src);
            var index = (ISymIndex)factory.Invoke(null, core.array<object>());
            return index.Untyped();
        }
    }
}