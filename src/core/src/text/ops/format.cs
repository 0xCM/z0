//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static unsafe string format(StringAddress src)
            => new string(gptr(firstchar(src)));

        [Op]
        public static string format(ReadOnlySpan<char> src, uint length)
            => new string(core.slice(src,0, length));

        [Op]
        public static string format(ReadOnlySpan<char> src)
            => new string(src);
    }
}