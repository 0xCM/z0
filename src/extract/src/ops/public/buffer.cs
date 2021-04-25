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
        [Op]
        public static byte[] buffer(ByteSize? size = null)
            => alloc<byte>(size ?? DefaultBufferLength);
    }
}
