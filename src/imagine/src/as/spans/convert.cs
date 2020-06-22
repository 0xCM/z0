//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static System.Runtime.CompilerServices.Unsafe;

    using static Konst;
    using static AsInternal;

    partial struct As
    {
        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<sbyte> src, Span<T> dst)
            where T : unmanaged
                => convert<sbyte,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<byte> src, Span<T> dst)
            where T : unmanaged
                => convert<byte,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<short> src, Span<T> dst)
            where T : unmanaged
                => convert<short,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<ushort> src, Span<T> dst)
            where T : unmanaged
                => convert<ushort,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<int> src, Span<T> dst)
            where T : unmanaged
                => convert<int,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<uint> src, Span<T> dst)
            where T : unmanaged
                => convert<uint,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<long> src, Span<T> dst)
            where T : unmanaged            
                => convert<long,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<float> src, Span<T> dst)
            where T : unmanaged
                => convert<float,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<double> src, Span<T> dst)
            where T : unmanaged
                => convert<double,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<sbyte> src)
            where T : unmanaged
                => convert<sbyte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => convert<byte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<short> src)
            where T : unmanaged
                => convert<short,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<ushort> src)
            where T : unmanaged
                => convert<ushort,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> transform<T>(ReadOnlySpan<int> src)
            where T : unmanaged
                => convert<int,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<uint> src)
            where T : unmanaged
                => convert<uint,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<long> src)
            where T : unmanaged
                => convert<long,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<ulong> src)
            where T : unmanaged
                => convert<ulong,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<float> src)
            where T : unmanaged
                => convert<float,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(ReadOnlySpan<double> src)
            where T : unmanaged
                => convert<double,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(Span<sbyte> src)
            where T : unmanaged
                => convert<sbyte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(Span<byte> src)
            where T : unmanaged
                => convert<byte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(Span<short> src)
            where T : unmanaged
                => convert<short,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(Span<ushort> src)
            where T : unmanaged
                => convert<ushort,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(Span<int> src)
            where T : unmanaged
                => convert<int,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(Span<uint> src)
            where T : unmanaged
                => convert<uint,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> transform<T>(Span<long> src)
            where T : unmanaged
                => convert<long,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(Span<ulong> src)
            where T : unmanaged
                => convert<ulong,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(Span<float> src)
            where T : unmanaged
                => convert<float,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Span<T> convert<T>(Span<double> src)
            where T : unmanaged
                 => convert<double,T>(src);        

        /// <summary>
        /// Applies the unconditional numeric conversion S -> T for each source element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static ref readonly Span<T> convert<S,T>(in ReadOnlySpan<S> src, in Span<T> dst)
        {
            for(var i=0; i<src.Length; i++)
                seek(dst,i) = As<S,T>(ref edit(skip(src,i)));
            return ref dst;
        }

        /// <summary>
        /// Applies the unconditional conversion S -> T for each source element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<T> convert<S,T>(Span<S> src)
        {
            var dst = alloc<T>(src.Length).ToSpan();
            convert<S,T>(src,dst);
            return dst;
        }

        /// <summary>
        /// Converts values in the source to values of the target type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> convert<S,T>(ReadOnlySpan<S> src)
        {
            var dst = alloc<T>(src.Length);
            convert<S,T>(src,dst);
            return dst;
        }
    }
}