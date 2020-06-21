//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static System.Runtime.InteropServices.MemoryMarshal;
    using static System.Runtime.CompilerServices.Unsafe;

    readonly partial struct Imagine
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<byte> bytes<T>(in T src)
            where T : struct
                => AsBytes(CreateSpan(ref edit(src), 1));

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<byte> bytes<T>(Span<T> src)
            where T : struct
                => AsBytes(src);        

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static ReadOnlySpan<byte> bytes<T>(ReadOnlySpan<T> src)
            where T : struct
                => cover<byte>(cast<T,byte>(first(src)), src.Length*SizeOf<T>());
    }
}