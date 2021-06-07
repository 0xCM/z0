//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct TextTools
    {
        [MethodImpl(Inline), Op]
        public static AsciLine line(ReadOnlySpan<byte> src, uint number, uint start, uint length)
            => new AsciLine(number, start, core.recover<AsciCharCode>(core.slice(src, start, length)));

        [MethodImpl(Inline), Op]
        public static AsciLine line(ReadOnlySpan<AsciCharCode> src, uint number, uint start, uint length)
            => new AsciLine(number, start, core.slice(src, start, length));
    }
}