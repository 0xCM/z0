//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static System.Runtime.InteropServices.MemoryMarshal;

    using static Konst;

    partial class Root
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static unsafe Span<T> edit<T>(MemoryAddress src, int length)
            => CreateSpan(ref src.Ref<T>(), length);

        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> edit(MemoryAddress src, int length)
            => CreateSpan(ref src.Ref<byte>(), length);
    }
}