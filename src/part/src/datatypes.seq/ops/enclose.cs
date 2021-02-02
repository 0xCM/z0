//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Seq
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EnclosedList<T> enclose<T>(ListEnclosureKind kind, char delimiter, params T[] src)
            where T : unmanaged
                => new EnclosedList<T>(src, kind, delimiter);

        [MethodImpl(Inline)]
        public static EnclosedList<T> enclose<T>(params T[] src)
            where T : unmanaged
                => enclose(ListEnclosureKind.Embraced, Chars.Comma, src);
   }
}