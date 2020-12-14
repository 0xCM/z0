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
        [MethodImpl(Inline)]
        public static EnclosedList<T> enclose<T>(params T[] src)
            where T : unmanaged
                => Seq.enclose(ListEnclosureKind.Embraced, Chars.Comma, src);

        [MethodImpl(Inline)]
        public static EnclosedList<T> enclose<T>(ListEnclosureKind kind, params T[] src)
            where T : unmanaged
                => Seq.enclose(kind, Chars.Comma, src);

        [MethodImpl(Inline)]
        public static EnclosedList<T> enclose<T>(ListEnclosureKind kind, char delimiter, params T[] src)
            where T : unmanaged
                => Seq.enclose(kind, delimiter, src);
    }
}