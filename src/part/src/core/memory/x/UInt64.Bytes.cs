//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class XMem
    {
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> Bytes(this ulong src)
            => core.bytes(src);
    }
}