//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public static partial class XTend
    {
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> Bytes(this short src)
            => ByteReader.ReadAll(src);
    }
}