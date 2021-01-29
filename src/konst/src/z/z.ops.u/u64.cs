//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static ulong u64(bool src)
            => memory.u64(src);

        [MethodImpl(Inline)]
        public static ref ulong u64<T>(in T src)
            => ref memory.u64(src);

        [MethodImpl(Inline), Op]
        public static ulong u64(ReadOnlySpan<byte> src, int offset = 0)
            => memory.cell<ulong>(src, offset);
    }
}