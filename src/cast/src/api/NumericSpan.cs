//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static Konst;
    using static Control;

    [ApiHost("numeric.span")]
    public readonly struct NumericSpan : IApiHost<NumericSpan>
    {
        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(ReadOnlySpan<sbyte> src, Span<T> dst)
            where T : unmanaged
                => NumericSpan.to<sbyte,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(ReadOnlySpan<byte> src, Span<T> dst)
            where T : unmanaged
                => NumericSpan.to<byte,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(ReadOnlySpan<short> src, Span<T> dst)
            where T : unmanaged
                => NumericSpan.to<short,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(ReadOnlySpan<ushort> src, Span<T> dst)
            where T : unmanaged
                => NumericSpan.to<ushort,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(ReadOnlySpan<int> src, Span<T> dst)
            where T : unmanaged
                => NumericSpan.to<int,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(ReadOnlySpan<uint> src, Span<T> dst)
            where T : unmanaged
                => NumericSpan.to<uint,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(ReadOnlySpan<long> src, Span<T> dst)
            where T : unmanaged            
                => NumericSpan.to<long,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(ReadOnlySpan<float> src, Span<T> dst)
            where T : unmanaged
                => NumericSpan.to<float,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static Span<T> to<T>(ReadOnlySpan<double> src, Span<T> dst)
            where T : unmanaged
                => NumericSpan.to<double,T>(src, dst);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(ReadOnlySpan<sbyte> src)
            where T : unmanaged
                => NumericSpan.to<sbyte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => NumericSpan.to<byte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(ReadOnlySpan<short> src)
            where T : unmanaged
                => NumericSpan.to<short,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(ReadOnlySpan<ushort> src)
            where T : unmanaged
                => NumericSpan.to<ushort,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(ReadOnlySpan<int> src)
            where T : unmanaged
                => NumericSpan.to<int,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(ReadOnlySpan<uint> src)
            where T : unmanaged
                => NumericSpan.to<uint,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(ReadOnlySpan<long> src)
            where T : unmanaged
                => NumericSpan.to<long,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(ReadOnlySpan<ulong> src)
            where T : unmanaged
                => NumericSpan.to<ulong,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(ReadOnlySpan<float> src)
            where T : unmanaged
                => NumericSpan.to<float,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(ReadOnlySpan<double> src)
            where T : unmanaged
                => NumericSpan.to<double,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(Span<sbyte> src)
            where T : unmanaged
                => NumericSpan.to<sbyte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(Span<byte> src)
            where T : unmanaged
                => NumericSpan.to<byte,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(Span<short> src)
            where T : unmanaged
                => NumericSpan.to<short,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(Span<ushort> src)
            where T : unmanaged
                => NumericSpan.to<ushort,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(Span<int> src)
            where T : unmanaged
                => NumericSpan.to<int,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(Span<uint> src)
            where T : unmanaged
                => NumericSpan.to<uint,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(Span<long> src)
            where T : unmanaged
                => NumericSpan.to<long,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(Span<ulong> src)
            where T : unmanaged
                => NumericSpan.to<ulong,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(Span<float> src)
            where T : unmanaged
                => NumericSpan.to<float,T>(src);

        /// <summary>
        /// Transforms values from a source span to an allocated target span with cells of parametric numeric kind
        /// </summary>
        /// <param name="src">The source stream</param>
        /// <typeparam name="T">The target numeric kind</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> to<T>(Span<double> src)
            where T : unmanaged
                 => NumericSpan.to<double,T>(src);        
        /// <summary>
        /// Applies the unconditional numeric conversion S -> T for each source element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static ref readonly Span<T> to<S,T>(in ReadOnlySpan<S> src, in Span<T> dst)
        {
            for(var i=0; i<src.Length; i++)
                seek(dst,i) = ToNumeric.to<S,T>(skip(src,i));
            return ref dst;
        }

        /// <summary>
        /// Applies the unconditional numeric conversion S -> T for each source element
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]   
        public static Span<T> to<S,T>(Span<S> src)
        {
            var dst = Control.alloc<T>(src.Length).ToSpan();
            to<S,T>(src,dst);
            return dst;
        }

        /// <summary>
        /// Converts values in the source to values of the target type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> to<S,T>(ReadOnlySpan<S> src)
        {
            var dst = Control.alloc<T>(src.Length);
            to<S,T>(src,dst);
            return dst;
        }
    }
}