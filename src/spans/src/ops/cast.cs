//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    

    using static Konst;

    partial class Spans
    {
        /// <summary>
        /// Reimagines a readonly span of one element type as a readonly span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<S,T>(ReadOnlySpan<S> src)                
            where S : unmanaged
            where T : unmanaged
                => MemoryMarshal.Cast<S,T>(src);

        /// <summary>
        /// Reimagines a span of one element type as a span of another element type
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="S">The source element type</typeparam>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> cast<S,T>(Span<S> src)                
            where S : unmanaged
            where T : unmanaged
                => MemoryMarshal.Cast<S,T>(src);

        [MethodImpl(Inline)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src, int offset, int length)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, length * Unsafe.SizeOf<T>()));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> cast<T>(Span<byte> src, int offset, int length)
            where T : unmanaged
                => MemoryMarshal.Cast<byte,T>(src.Slice(offset, length * Unsafe.SizeOf<T>()));
        
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static ReadOnlySpan<T> cast<T>(ReadOnlySpan<byte> src)
            where T : unmanaged
                => cast<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> cast<T>(Span<byte> src)
            where T : unmanaged        
                => cast<T>(src, 0, src.Length/Unsafe.SizeOf<T>());

        /// <summary>
        /// Produces a target T-span from a source bytespan populated with a maximal
        /// number of elemements obtainable from the source bytes; remaining bytes, if
        /// any, are deposited into a remainder bytespan
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="rem">The span populated with left-over bytes, if any</param>
        /// <typeparam name="T">The target element type</typeparam>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Span<T> cast<T>(Span<byte> src, out Span<byte> rem)
            where T : unmanaged        
        {
            var z = Unsafe.SizeOf<T>();
            var n = src.Length;
            var q = n/z;            
            var r = n%z;
            var dst = cast<T>(src.Slice(0, q));            
            rem = r != 0 ? src.Slice(q) : Span<byte>.Empty;
            return dst;
        }            
    }
}