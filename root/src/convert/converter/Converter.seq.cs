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

    using static Refs;    
    using static Root;

    partial class Converter
    {
        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in ulong src)
            => new Span<byte>(constptr(in src), 8);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in long src)
            => new Span<byte>(constptr(in src), 8);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in double src)
            => new Span<byte>(constptr(in src), 8);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in uint src)
            => new Span<byte>(constptr(in src), 4);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in int src)
            => new Span<byte>(constptr(in src), 4);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in float src)
            => new Span<byte>(constptr(in src), 4);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in ushort src)
            => new Span<byte>(constptr(in src), 2);

        [MethodImpl(Inline)]
        public static unsafe Span<byte> bytes(in short src)
            => new Span<byte>(constptr(in src), 2);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<sbyte> src)
            where T : unmanaged
                => src.Select(convert<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<byte> src)
            where T : unmanaged
                => src.Select(convert<T>);
        
        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<short> src)
            where T : unmanaged
                => src.Select(convert<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<ushort> src)
            where T : unmanaged
                => src.Select(convert<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<int> src)
            where T : unmanaged
                => src.Select(convert<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<uint> src)
            where T : unmanaged
                => src.Select(convert<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<long> src)
            where T : unmanaged
                => src.Select(convert<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<ulong> src)
            where T : unmanaged            
                => src.Select(convert<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<float> src)
            where T : unmanaged            
                => src.Select(convert<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<double> src)
            where T : unmanaged            
                => src.Select(convert<T>);

        /// <summary>
        /// Unconditionally converts the sources value to the target type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The target type</typeparam>
        public static IEnumerable<T> convert<T>(IEnumerable<char> src)
            where T : unmanaged            
                => src.Select(convert<T>);

        /// <summary>
        /// If possible, applies the conversion S -> T for each element of a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<T> convert<S,T>(Span<S> src)
            where T : unmanaged
            where S : unmanaged
        {
            Span<T> dst = new T[src.Length];
            for(var i=0; i< src.Length; i++)
                dst[i] = convert<S,T>(src[i]);
            return dst;
        }

        /// <summary>
        /// Converts values in the source to values of the target type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> convert<S,T>(ReadOnlySpan<S> src)
            where S : unmanaged
            where T : unmanaged
        {
            Span<T> dst = new T[src.Length];
            for(var i=0; i<src.Length; i++)
                dst[i] = convert<S,T>(src[i]);
            return dst;
        }

        /// <summary>
        /// If possible, applies the conversion S -> T for each element of an array
        /// </summary>
        /// <param name="src">The source array</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static T[] convert<S,T>(S[] src)
            where T : unmanaged
            where S : unmanaged
        {
            var dst = new T[src.Length];
            for(var i=0; i< src.Length; i++)
                dst[i] = convert<S,T>(src[i]);
            return dst;
        }
    }
}