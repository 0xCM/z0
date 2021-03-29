//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct Symbols
    {
        const string UntypedPattern = "{0,-8} | {1,-32} | {2}";

        const string TypedPattern = "{0,-8} | {1,-32} | {2,-32} | {3}";

        public static string format(Sym8 src)
            => string.Format(UntypedPattern, src.Key, src.Name, src.Expression);

        public static string format(Sym16 src)
            => string.Format(UntypedPattern, src.Key, src.Name, src.Expression);

        public static string format<E>(Sym8<E> src)
            where E : unmanaged
                => string.Format(TypedPattern, src.Key, typeof(E).Name, src.Name, src.Expression);

        public static string format<E>(Sym16<E> src)
            where E : unmanaged
                => string.Format(TypedPattern, src.Key, typeof(E).Name, src.Name, src.Expression);
    }
}