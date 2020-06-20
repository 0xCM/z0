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
        public static Span<byte> bytes<T>(Span<T> src)
            where T : struct
                => Imagine.bytes(src);        

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<byte> bytes<T>(in T src)
            where T : struct
                => Imagine.bytes(src);        

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
            where T : struct
                => Imagine.bytes(src);
    }
}