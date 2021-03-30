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
        const string SymFormatPattern = "{0,-8} | {1,-32} | {2,-32} | {3}";

        public static string header()
            => string.Format(SymFormatPattern, "Index", "Kind", "Name", "Expression");

        public static string format(Sym8 src)
            => string.Format(SymFormatPattern, src.Key, src.Kind, src.Name, src.Expression);

        public static string format(Sym16 src)
            => string.Format(SymFormatPattern, src.Key, src.Kind, src.Name, src.Expression);

        public static string format<E>(Sym8<E> src)
            where E : unmanaged
                => string.Format(SymFormatPattern, src.Key, src.Kind, src.Name, src.Expression);

        public static string format<E>(Sym16<E> src)
            where E : unmanaged
                => string.Format(SymFormatPattern, src.Key, src.Kind, src.Name, src.Expression);

        public static string format<E>(Sym<E> src)
            where E : unmanaged
                => string.Format(SymFormatPattern, src.Key, src.Kind, src.Name, src.Expression);

    }
}