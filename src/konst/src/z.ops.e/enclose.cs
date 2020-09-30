//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static EnclosedList<T> enclose<T>(T[] src,  ListEnclosureKind kind = ListEnclosureKind.Embraced, char delimiter = Chars.Comma)
            where T : unmanaged
                => new EnclosedList<T>(src, kind, delimiter);
    }
}