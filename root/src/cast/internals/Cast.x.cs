//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static Root;

    public static class ConvertExtensions
    {
        [MethodImpl(Inline)]
        public static byte[] ToBytes(this int src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static byte[] ToBytes(this ulong src)
            => BitConverter.GetBytes(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in ulong src)
            => Cast.bytes(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in long src)
            => Cast.bytes(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in double src)
            => Cast.bytes(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in uint src)
            => Cast.bytes(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in int src)
            => Cast.bytes(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in float src)
            => Cast.bytes(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in ushort src)
            => Cast.bytes(src);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in short src)
            => Cast.bytes(src);

        public static IEnumerable<T> Convert<T>(this IEnumerable<sbyte> src)
            where T : unmanaged
                => Cast.to<T>(src);

        public static IEnumerable<T> Convert<T>(this IEnumerable<byte> src)
            where T : unmanaged
                => Cast.to<T>(src);
        
        public static IEnumerable<T> Convert<T>(this IEnumerable<short> src)
            where T : unmanaged
                => Cast.to<T>(src);

        public static IEnumerable<T> Convert<T>(this IEnumerable<ushort> src)
            where T : unmanaged
                => Cast.to<T>(src);

        public static IEnumerable<T> Convert<T>(this IEnumerable<int> src)
            where T : unmanaged
                => Cast.to<T>(src);

        public static IEnumerable<T> Convert<T>(this IEnumerable<uint> src)
            where T : unmanaged
                => Cast.to<T>(src);

        public static IEnumerable<T> Convert<T>(this IEnumerable<long> src)
            where T : unmanaged
                => Cast.to<T>(src);

        public static IEnumerable<T> Convert<T>(this IEnumerable<ulong> src)
            where T : unmanaged            
                => Cast.to<T>(src);

        public static IEnumerable<T> Convert<T>(this IEnumerable<float> src)
            where T : unmanaged            
                => Cast.to<T>(src);

        public static IEnumerable<T> Convert<T>(this IEnumerable<double> src)
            where T : unmanaged            
                => Cast.to<T>(src);

        public static IEnumerable<T> Convert<T>(this IEnumerable<char> src)
            where T : unmanaged            
                => Cast.to<T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<sbyte> src)
            where T : unmanaged
                => Cast.to<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<byte> src)
            where T : unmanaged
                => Cast.to<byte,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<short> src)
            where T : unmanaged
                => Cast.to<short,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<ushort> src)
            where T : unmanaged
                => Cast.to<ushort,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<int> src)
            where T : unmanaged
                => Cast.to<int,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<uint> src)
            where T : unmanaged
                => Cast.to<uint,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<long> src)
            where T : unmanaged
                => Cast.to<long,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<ulong> src)
            where T : unmanaged
                => Cast.to<ulong,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<float> src)
            where T : unmanaged
                => Cast.to<float,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<double> src)
            where T : unmanaged
                => Cast.to<double,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<sbyte> src)
            where T : unmanaged
                => Cast.to<sbyte,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<byte> src)
            where T : unmanaged
                => Cast.to<byte,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<short> src)
            where T : unmanaged
                => Cast.to<short,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<ushort> src)
            where T : unmanaged
                => Cast.to<ushort,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<int> src)
            where T : unmanaged
                => Cast.to<int,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<uint> src)
            where T : unmanaged
                => Cast.to<uint,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<long> src)
            where T : unmanaged
                => Cast.to<long,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<ulong> src)
            where T : unmanaged
                => Cast.to<ulong,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<float> src)
            where T : unmanaged
                => Cast.to<float,T>(src);

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<double> src)
            where T : unmanaged
                 => Cast.to<double,T>(src);
    }
}