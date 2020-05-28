//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    partial class Control
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<byte> bytes<T>(in T src)
            where T : unmanaged
                => MemoryMarshal.AsBytes(MemoryMarshal.CreateReadOnlySpan(ref edit(src), 1));
    }
}