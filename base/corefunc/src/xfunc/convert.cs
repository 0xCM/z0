//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.Intrinsics;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    partial class xfunc
    {

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in ulong src)
            => new Span<byte>(constptr(in src), 8);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in long src)
            => new Span<byte>(constptr(in src), 8);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in double src)
            => new Span<byte>(constptr(in src), 8);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in uint src)
            => new Span<byte>(constptr(in src), 4);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in int src)
            => new Span<byte>(constptr(in src), 4);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in float src)
            => new Span<byte>(constptr(in src), 4);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in ushort src)
            => new Span<byte>(constptr(in src), 2);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> AsBytes(this in short src)
            => new Span<byte>(constptr(in src), 2);

        /// <summary>
        /// Converts a bool to a byte quickly
        /// </summary>
        /// <param name="src"></param>
        /// <remarks>Taken from https://stackoverflow.com/questions/4980881/what-is-fastest-way-to-convert-bool-to-byte</remarks>
        [MethodImpl(Inline)]
        public static unsafe byte ToByte(this bool src)
            =>  *((byte*)(&src));

        /// <summary>
        /// Converts a bit to an unsinged integral type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this bit src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this sbyte src)
            where T : unmanaged
                => convert<T>(src);
        
        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this byte src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this short src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this ushort src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this int src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this uint src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this long src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this ulong src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this float src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this double src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the source value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static T Convert<T>(this char src)
            where T : unmanaged
                => convert<T>(src);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<sbyte> src)
            where T : unmanaged
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<byte> src)
            where T : unmanaged
                => from item in src select convert<T>(item);
        
        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<short> src)
            where T : unmanaged
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<ushort> src)
            where T : unmanaged
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<int> src)
            where T : unmanaged
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<uint> src)
            where T : unmanaged
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<long> src)
            where T : unmanaged
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<ulong> src)
            where T : unmanaged            
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<float> src)
            where T : unmanaged            
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<double> src)
            where T : unmanaged            
                => from item in src select convert<T>(item);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> Convert<T>(this IEnumerable<char> src)
            where T : unmanaged            
                => from item in src select convert<T>(item);

        /// <summary>
        /// Converts values in the source to values of the target type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The target type</typeparam>
        static Span<T> Convert<S,T>(this ReadOnlySpan<S> src)
            where S : unmanaged
            where T : unmanaged
        {
            Span<T> dst = new T[src.Length];
            for(var i=0; i<src.Length; i++)
                convert(src[i], out dst[i]);
            return dst;
        }

        static T[] Convert<S,T>(this S[] src)
            where S : unmanaged
            where T : unmanaged
        {
            var dst = new T[src.Length];
            for(var i=0; i<src.Length; i++)
                convert(src[i], out dst[i]);
            return dst;
        }

        static Span<T> Convert<S,T>(this Span<S> src)
            where S : unmanaged
            where T : unmanaged
                => src.ReadOnly().Convert<S,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<sbyte> src)
            where T : unmanaged
                => src.Convert<sbyte,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<byte> src)
            where T : unmanaged
                => src.Convert<byte,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<short> src)
            where T : unmanaged
                => src.Convert<short,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<ushort> src)
            where T : unmanaged
                => src.Convert<ushort,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<int> src)
            where T : unmanaged
                => src.Convert<int,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<uint> src)
            where T : unmanaged
                => src.Convert<uint,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<long> src)
            where T : unmanaged
                => src.Convert<long,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<ulong> src)
            where T : unmanaged
                => src.Convert<ulong,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<float> src)
            where T : unmanaged
                => src.Convert<float,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this ReadOnlySpan<double> src)
            where T : unmanaged
                => src.Convert<double,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<sbyte> src)
            where T : unmanaged
                => src.Convert<sbyte,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<byte> src)
            where T : unmanaged
                => src.Convert<byte,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<short> src)
            where T : unmanaged
                => src.Convert<short,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<ushort> src)
            where T : unmanaged
                => src.Convert<ushort,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<int> src)
            where T : unmanaged
                => src.Convert<int,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<uint> src)
            where T : unmanaged
                => src.Convert<uint,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<long> src)
            where T : unmanaged
                => src.Convert<long,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<ulong> src)
            where T : unmanaged
                => src.Convert<ulong,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<float> src)
            where T : unmanaged
                => src.Convert<float,T>();

        [MethodImpl(Inline)]
        public static Span<T> Convert<T>(this Span<double> src)
            where T : unmanaged
                => src.Convert<double,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this sbyte[] src)
            where T : unmanaged
                => src.Convert<sbyte,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this byte[] src)
            where T : unmanaged
                => src.Convert<byte,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this short[] src)
            where T : unmanaged
                => src.Convert<short,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this ushort[] src)
            where T : unmanaged
                => src.Convert<ushort,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this int[] src)
            where T : unmanaged
                => src.Convert<int,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this uint[] src)
            where T : unmanaged
                => src.Convert<uint,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this long[] src)
            where T : unmanaged
                => src.Convert<long,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this ulong[] src)
            where T : unmanaged
                => src.Convert<ulong,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this float[] src)
            where T : unmanaged
                => src.Convert<float,T>();

        [MethodImpl(Inline)]
        public static T[] Convert<T>(this double[] src)
            where T : unmanaged
                => src.Convert<double,T>();

    }
}