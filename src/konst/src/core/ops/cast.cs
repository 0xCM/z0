//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static System.Runtime.InteropServices.MemoryMarshal;

    partial struct core
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<sbyte> src)
            where T : struct
                => Cast<sbyte,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<byte> src)
            where T : struct
                => Cast<byte,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<short> src)
            where T : struct
                => Cast<short,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<ushort> src)
            where T : struct
                => Cast<ushort,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<int> src)
            where T : struct
                => Cast<int,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<uint> src)
            where T : struct
                => Cast<uint,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<long> src)
            where T : struct
                => Cast<long,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<ulong> src)
            where T : struct
                => Cast<ulong,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<float> src)
            where T : struct
                => Cast<float,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<double> src)
            where T : struct
                => Cast<double,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<decimal> src)
            where T : struct
                => Cast<decimal,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<bool> src)
            where T : struct
                => Cast<bool,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> cast<T>(Span<char> src)
            where T : struct
                => Cast<char,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<sbyte> src)
            where T : struct
                => Cast<sbyte,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : struct
                => Cast<byte,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<short> src)
            where T : struct
                => Cast<short,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<ushort> src)
            where T : struct
                => Cast<ushort,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<int> src)
            where T : struct
                => Cast<int,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<uint> src)
            where T : struct
                => Cast<uint,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<long> src)
            where T : struct
                => Cast<long,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<ulong> src)
            where T : struct
                => Cast<ulong,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<float> src)
            where T : struct
                => Cast<float,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<double> src)
            where T : struct
                => Cast<double,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<decimal> src)
            where T : struct
                => Cast<decimal,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<bool> src)
            where T : struct
                => Cast<bool,T>(src);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<char> src)
            where T : struct
                => Cast<char,T>(src);
    }
}