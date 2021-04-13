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
        public static string Utf8(this ResDescriptor src)
            => text.utf8(src.Bytes());

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<byte> Bytes(this ResDescriptor src)
            => memory.view(src.Address, src.Size);
    }
}