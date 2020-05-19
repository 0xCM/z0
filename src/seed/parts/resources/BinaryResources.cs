//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Seed;

    public class BinaryResources
    {
        // [MethodImpl(Inline)]
        // public static ref T edit<T>(in T src)
        //     => ref Unsafe.AsRef(in src);

        // [MethodImpl(Inline)]
        // public static ref readonly T skip<T>(in T src, int count)
        //     => ref Unsafe.Add(ref edit(in src), count); 

        // [MethodImpl(Inline)]
        // public static ref readonly T head<T>(ReadOnlySpan<T> src)
        //     => ref MemoryMarshal.GetReference<T>(src);

        // [MethodImpl(Inline)]
        // public static ref readonly T skip<T>(ReadOnlySpan<T> src, int count)
        //     => ref skip(in head(src), count);

        // [MethodImpl(Inline)]
        // public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
        //     where T : unmanaged
        //         => MemoryMarshal.Cast<byte,T>(src);

        // [MethodImpl(Inline)]
        // public static ref T seek<T>(ref T src, int count)
        //     => ref Unsafe.Add(ref src, count);

        // [MethodImpl(Inline)]
        // public static ref T head<T>(Span<T> src)
        //     => ref MemoryMarshal.GetReference<T>(src);

        // [MethodImpl(Inline)]
        // public static ref T seek<T>(Span<T> src, int count)
        //     => ref seek(ref head(src), count); 
    }
}