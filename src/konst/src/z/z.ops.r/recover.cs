//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static Span<T> recover<S,T>(Span<S> src)
            => memory.recover<S,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<S,T>(ReadOnlySpan<S> src)
            => memory.recover<S,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<sbyte> src)
            where T : struct
                => memory.recover<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<byte> src)
            where T : struct
                => memory.recover<byte,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<short> src)
            where T : struct
                => memory.recover<short,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<ushort> src)
            where T : struct
                => memory.recover<ushort,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<int> src)
            where T : struct
                 => memory.recover<int,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<uint> src)
            where T : struct
                => memory.recover<uint,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<long> src)
            where T : struct
                 => memory.recover<long,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<ulong> src)
            where T : struct
                 => memory.recover<ulong,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<float> src)
            where T : struct
                => memory.recover<float,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<double> src)
            where T : struct
                => memory.recover<double,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<T>(ReadOnlySpan<decimal> src)
            where T : struct
                => memory.recover<decimal,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<byte> src)
            where T : struct
                => memory.recover<byte,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<uint> src)
            where T : struct
                => memory.recover<uint,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<sbyte> src)
            where T : struct
                => memory.recover<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<short> src)
            where T : struct
                => memory.recover<short,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<ushort> src)
            where T : struct
                => memory.recover<ushort,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<int> src)
            where T : struct
                => memory.recover<int,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<long> src)
            where T : struct
                => memory.recover<long,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<ulong> src)
            where T : struct
                 => memory.recover<ulong,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<float> src)
            where T : struct
                 => memory.recover<float,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<double> src)
            where T : struct
                 => memory.recover<double,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> recover<T>(Span<decimal> src)
            where T : struct
                 => memory.recover<decimal,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> recover<S,T>(ReadOnlySpan<S> src, out ReadOnlySpan<S> rem)
            where T : struct
            where S : struct
                => memory.recover<S,T>(src, out rem);

        [MethodImpl(Inline)]
        public static Span<T> recover<S,T>(Span<S> src, out Span<S> rem)
            where T : struct
            where S : struct
                => memory.recover<S,T>(src, out rem);
    }
}