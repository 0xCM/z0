//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static memory;

    partial struct Unicodes
    {
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<Unicode> whitespace()
            => recover<Unicode>(WhitespaceBytes);

        static ReadOnlySpan<byte> WhitespaceBytes => new byte[]{
            (byte)Hi.Tab, (byte)Lo.Tab,
            (byte)Hi.LF, (byte)Lo.LF,
            (byte)Hi.FF, (byte)Lo.FF,
            (byte)Hi.CR, (byte)Lo.CR,
            (byte)Hi.Space, (byte)Lo.Space,
            (byte)Hi.NextLine, (byte)Lo.NextLine,
            (byte)Hi.NoBreakSpace, (byte)Lo.NoBreakSpace,
        };
    }
}