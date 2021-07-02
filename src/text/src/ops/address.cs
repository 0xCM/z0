//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class text
    {
        [MethodImpl(Inline), Op]
        public static StringAddress address(string src)
            => TextTools.address(src);

        [MethodImpl(Inline), Op, Closures(UInt8x16k)]
        public static StringAddress address<T>(ReadOnlySpan<T> src)
            where T : unmanaged
                => TextTools.address(src);

        [MethodImpl(Inline)]
        public static StringAddress address(ReadOnlySpan<char> src)
            => TextTools.address(src);
    }
}