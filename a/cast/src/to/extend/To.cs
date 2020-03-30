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
    
    using static Components;
    using static ToNumeric;

    partial class XTend
    {
        /// <summary>
        /// Convers a source value, which is hopefully a supported kind, to a target kind
        /// </summary>
        /// <param name="k">The primal kind</param>
        [MethodImpl(Inline)]
        public static object To(this NumericKind dst, object src)
            => Cast.to(src,dst);            

        /// <summary>
        /// Transforms values from a source stream to a target stream of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        public static IEnumerable<T> To<T>(this IEnumerable<sbyte> src)
            where T : unmanaged
                => to<T>(src);

        /// <summary>
        /// Transforms values from a source stream to a target stream of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        public static IEnumerable<T> To<T>(this IEnumerable<byte> src)
            where T : unmanaged
                => to<T>(src);
        
        /// <summary>
        /// Transforms values from a source stream to a target stream of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        public static IEnumerable<T> To<T>(this IEnumerable<short> src)
            where T : unmanaged
                => to<T>(src);

        /// <summary>
        /// Transforms values from a source stream to a target stream of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        public static IEnumerable<T> To<T>(this IEnumerable<ushort> src)
            where T : unmanaged
                => to<T>(src);

        /// <summary>
        /// Transforms values from a source stream to a target stream of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        public static IEnumerable<T> To<T>(this IEnumerable<int> src)
            where T : unmanaged
                => to<T>(src);

        /// <summary>
        /// Transforms values from a source stream to a target stream of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        public static IEnumerable<T> To<T>(this IEnumerable<uint> src)
            where T : unmanaged
                => to<T>(src);

        /// <summary>
        /// Transforms values from a source stream to a target stream of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        public static IEnumerable<T> To<T>(this IEnumerable<long> src)
            where T : unmanaged
                => to<T>(src);

        /// <summary>
        /// Transforms values from a source stream to a target stream of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        public static IEnumerable<T> To<T>(this IEnumerable<ulong> src)
            where T : unmanaged            
                => to<T>(src);

        /// <summary>
        /// Transforms values from a source stream to a target stream of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        public static IEnumerable<T> To<T>(this IEnumerable<float> src)
            where T : unmanaged            
                => to<T>(src);

        /// <summary>
        /// Transforms values from a source stream to a target stream of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        public static IEnumerable<T> To<T>(this IEnumerable<double> src)
            where T : unmanaged            
                => to<T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<sbyte> src)
            where T : unmanaged
                => Cast.to<sbyte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<byte> src)
            where T : unmanaged
                => Cast.to<byte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<short> src)
            where T : unmanaged
                => Cast.to<short,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<ushort> src)
            where T : unmanaged
                => Cast.to<ushort,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<int> src)
            where T : unmanaged
                => Cast.to<int,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<uint> src)
            where T : unmanaged
                => Cast.to<uint,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<long> src)
            where T : unmanaged
                => Cast.to<long,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<ulong> src)
            where T : unmanaged
                => Cast.to<ulong,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<float> src)
            where T : unmanaged
                => Cast.to<float,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this ReadOnlySpan<double> src)
            where T : unmanaged
                => Cast.to<double,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<sbyte> src)
            where T : unmanaged
                => Cast.to<sbyte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<byte> src)
            where T : unmanaged
                => Cast.to<byte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<short> src)
            where T : unmanaged
                => Cast.to<short,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<ushort> src)
            where T : unmanaged
                => Cast.to<ushort,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<int> src)
            where T : unmanaged
                => Cast.to<int,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<uint> src)
            where T : unmanaged
                => Cast.to<uint,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<long> src)
            where T : unmanaged
                => Cast.to<long,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<ulong> src)
            where T : unmanaged
                => Cast.to<ulong,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<float> src)
            where T : unmanaged
                => Cast.to<float,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> To<T>(this Span<double> src)
            where T : unmanaged
                 => Cast.to<double,T>(src);
    }
}