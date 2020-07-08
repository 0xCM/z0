//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static System.Runtime.CompilerServices.Unsafe;
    using static System.Runtime.InteropServices.MemoryMarshal;

    [ApiHost]
    public readonly struct Enhanced
    {
        [MethodImpl(Inline)]
        internal static ref T add<T>(in T src, int count)
            => ref Add(ref edit(src), count);        

        [MethodImpl(Inline)]
        internal static ref T edit<T>(in T src)   
            => ref AsRef(src);

        [MethodImpl(Inline)]
        internal static ref T first<T>(Span<T> src)
            => ref GetReference<T>(src);

        [MethodImpl(Inline)]
        internal static ref readonly T first<T>(ReadOnlySpan<T> src)
            => ref GetReference<T>(src);

        [MethodImpl(Inline)]
        internal static ref readonly T skip<T>(ReadOnlySpan<T> src, uint count)
            => ref skip(in first(src), count);

        [MethodImpl(Inline)]
        internal static ref readonly T skip<T>(in T src, uint count)
            => ref Add(ref edit(in src), (int)count); 

        [MethodImpl(Inline)]
        internal static ref T seek<T>(Span<T> src, uint offset)
            => ref add(first(src), (int)offset);

    }

    public static partial class XTend
    {

    }    
}