//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Root;

    partial struct Symbolic
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars<E>(ReadOnlySpan<E> src)
            where E : unmanaged, Enum
                => cast<E,char>(src);
    }

}
