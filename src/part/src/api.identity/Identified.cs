//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct Identified
    {
        [MethodImpl(Inline)]
        public static int compare<T>(in T a, in T b)
            where T : IIdentified
                => text.denullify(a.Identifier).CompareTo(b.Identifier);

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, object b)
            where T : IIdentified
                => text.equals(a.Identifier, b is T x ? x.Identifier : EmptyString, NoCase);

        [MethodImpl(Inline)]
        public static bool equals<T>(in T a, in T b)
            where T : IIdentified
                => text.equals(a.Identifier, b.Identifier, NoCase);

        [MethodImpl(Inline)]
        public static int hash<T>(in T src)
            where T : IIdentified
                => text.denullify(src.Identifier).GetHashCode();
    }
}