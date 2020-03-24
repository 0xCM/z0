//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Collections.Generic;
    using System.Linq;

    using static CastInternals;

    partial class Cast
    {
        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in ulong src)
            => new Span<byte>(refs.constptr(in src), 8);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in long src)
            => new Span<byte>(refs.constptr(in src), 8);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in double src)
            => new Span<byte>(refs.constptr(in src), 8);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in uint src)
            => new Span<byte>(refs.constptr(in src), 4);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in int src)
            => new Span<byte>(refs.constptr(in src), 4);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in float src)
            => new Span<byte>(refs.constptr(in src), 4);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in ushort src)
            => new Span<byte>(refs.constptr(in src), 2);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in short src)
            => new Span<byte>(refs.constptr(in src), 2);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<sbyte> src)
            => src.Select(to<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<byte> src)
            => src.Select(to<T>);
        
        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<short> src)
            => src.Select(to<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<ushort> src)
            => src.Select(to<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<int> src)
            => src.Select(to<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<uint> src)
            => src.Select(to<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<long> src)
            => src.Select(to<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<ulong> src)
            => src.Select(to<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<float> src)
            => src.Select(to<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<double> src)
            => src.Select(to<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<char> src)
            => src.Select(to<T>);

        /// <summary>
        /// If possible, applies the conversion S -> T for each element of a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<T> to<S,T>(Span<S> src)
        {
            Span<T> dst = new T[src.Length];
            for(var i=0; i< src.Length; i++)
                dst[i] = to<S,T>(src[i]);
            return dst;
        }

        /// <summary>
        /// Converts values in the source to values of the target type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> to<S,T>(ReadOnlySpan<S> src)
        {
            Span<T> dst = new T[src.Length];
            for(var i=0; i<src.Length; i++)
                dst[i] = to<S,T>(src[i]);
            return dst;
        }

        /// <summary>
        /// If possible, applies the conversion S -> T for each element of an array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T[] to<S,T>(S[] src)
        {
            var dst = new T[src.Length];
            for(var i=0; i< src.Length; i++)
                dst[i] = to<S,T>(src[i]);
            return dst;
        }
    }
}