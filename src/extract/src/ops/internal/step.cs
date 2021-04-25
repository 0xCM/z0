//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct ApiExtracts
    {
        [Op, MethodImpl(Inline)]
        internal static unsafe byte step(Span<byte> dst, OpIdentity id, ref int offset, ref long location, ref byte* pSrc)
        {
            var code = Unsafe.Read<byte>(pSrc++);
            dst[offset++] = code;
            location = (long)pSrc;
            return code;
        }
    }
}
