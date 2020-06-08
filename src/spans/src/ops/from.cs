//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class Spans
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<sbyte> src)
            where T : unmanaged
                => cast<sbyte,T>(src.Span);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<byte> src)
            where T : unmanaged
                => cast<byte,T>(src.Span);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<short> src)
            where T : unmanaged
                => cast<short,T>(src.Span);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<ushort> src)
            where T : unmanaged
                => cast<ushort,T>(src.Span);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<int> src)
            where T : unmanaged
                => cast<int,T>(src.Span);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<uint> src)
            where T : unmanaged
                => cast<uint,T>(src.Span);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> generic<T>(in ReadOnlyMemory<long> src)
            where T : unmanaged
                => cast<long,T>(src.Span);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<ulong> src)
            where T : unmanaged
                => cast<ulong,T>(src.Span);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> from<T>(in ReadOnlyMemory<float> src)
            where T : unmanaged
                => cast<float,T>(src.Span);
    }
}