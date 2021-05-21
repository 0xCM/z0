//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct ApiExtracts
    {
        [MethodImpl(Inline), Op]
        internal static unsafe int extract(MemoryAddress src, Span<byte> dst)
        {
            var pSrc = src.Pointer<byte>();
            var limit = dst.Length;
            return read(ref pSrc, limit, dst);
        }
    }
}