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
        [MethodImpl(Inline), Op]
        public static string @string(in StringRef src)
            => sys.@string(view(src));

        [MethodImpl(Inline), Op]
        public static unsafe string @string(char* pSrc)
            => new string(pSrc);

        [MethodImpl(Inline), Op]
        public static unsafe string @string(ReadOnlySpan<byte> src)
            => new string(gptr(recover<sbyte>(src)));
    }
}