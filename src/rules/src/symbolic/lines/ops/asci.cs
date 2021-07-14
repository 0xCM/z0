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

    partial struct Lines
    {
        [MethodImpl(Inline), Op]
        public static AsciLine asci(ReadOnlySpan<byte> src, uint number, uint offset, uint length)
            => new AsciLine(number, offset, recover<AsciSymbol>(slice(src, offset, length)));
    }
}