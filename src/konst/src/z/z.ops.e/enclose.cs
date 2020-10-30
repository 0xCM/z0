//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static EnclosedList<T> enclose<T>(params T[] src)
            where T : unmanaged
                => Seq.enclosed(ListEnclosureKind.Embraced, Chars.Comma, src);

        [MethodImpl(Inline)]
        public static EnclosedList<T> enclose<T>(ListEnclosureKind kind, params T[] src)
            where T : unmanaged
                => Seq.enclosed(kind, Chars.Comma, src);

        [MethodImpl(Inline)]
        public static EnclosedList<T> enclose<T>(ListEnclosureKind kind, char delimiter, params T[] src)
            where T : unmanaged
                => Seq.enclosed(kind, delimiter, src);
    }
}