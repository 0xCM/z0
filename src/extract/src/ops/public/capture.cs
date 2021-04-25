//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ApiExtracts
    {
        [Op]
        public static unsafe ApiCaptureResult capture(OpIdentity id, MemoryAddress src, Span<byte> dst)
            => divine(dst, id, src.Pointer<byte>());
    }
}