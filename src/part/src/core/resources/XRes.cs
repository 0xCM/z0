//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public static partial class XRes
    {
        [MethodImpl(Inline), Op]
        public static string Utf8(this Asset src)
            => Resources.utf8(src);

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> Bytes(this Asset src)
            => memory.view(src.Address, src.Size);
    }
}