//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<byte> bytespan<T>(in T src)
            where T : struct
                => MemoryMarshal.AsBytes(MemoryMarshal.CreateReadOnlySpan(ref edit(src), 1));
    }
}