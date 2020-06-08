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

    partial class Spans
    {
        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static unsafe ReadOnlySpan<T> read<T>(MemoryAddress src, int length)
        //     where T : unmanaged
        //         => new ReadOnlySpan<T>(src.ToPointer<T>(), length);

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<byte> read(MemoryAddress src, int length)
            => MemoryMarshal.CreateReadOnlySpan(ref src.ToRef<byte>(), length);

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<T> read<T>(MemoryAddress src, int length)
            => MemoryMarshal.CreateReadOnlySpan(ref src.ToRef<T>(), length);


        // [MethodImpl(Inline), Op]
        // public static unsafe ReadOnlySpan<byte> read(MemoryAddress src, int length)
        //     => new ReadOnlySpan<byte>(src.ToPointer<byte>(), length);
    }
}

