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
        public static ReadOnlySpan<char> chars<E>(ReadOnlySpan<E> src)
            where E : unmanaged, Enum
                => recover<E,char>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<char> chars(string src)
                => src;
    }
}