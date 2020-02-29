//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;    
    using System.Collections.Generic;        

    using static zfunc;

    /// <summary>
    /// Defines the vector api surface
    /// </summary>
    public static class RowVector
    {        
        /// <summary>
        /// Loads an unsized 256-bit blocked span from a sized unblocked span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The span index at which to begin the load</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        internal static Block256<T> safeload<N,T>(N256 n, in NatSpan<N,T> src)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => blocks.safeload(n,src.Data);        

        [MethodImpl(NotInline)]
        public static RowVector<T> alloc<T>(int minlen)               
            where T : unmanaged  
            => new RowVector<T>(new T[minlen]);

        [MethodImpl(Inline)]
        public static RowVector<N,T> alloc<N,T>(N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => alloc<T>((int)n.NatValue);

        [MethodImpl(Inline)]
        public static RowVector<T> load<T>(T[] src)
            where T : unmanaged
                => new RowVector<T>(src);

        /// <summary>
        /// Loads a vector of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector<N,T> load<N,T>(T[] src, N length = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new RowVector<N, T>(src);

        /// <summary>
        /// Loads a vector of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector<N,T> load<N,T>(N length, params T[] src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new RowVector<N, T>(src);

        [MethodImpl(Inline)]
        public static RowVector<N,T> zero<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => RowVector<N,T>.Zero;

        /// <summary>
        /// Defines a scalar sequence [first, ..., (first + N)]
        /// </summary>
        /// <param name="first">The first value in the sequence</param>
        /// <typeparam name="N">The count type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> range<N,T>(T first, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => Numeric.range(first,convert<T>(n.NatValue));

        public static RowVector<N,T> increasing<N,T>(N length = default, T first = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {            
            var components = range<N,T>(first).ToArray();
            return load<N,T>(components);
        }

        public static RowVector<N,T> decreasing<N,T>(N length = default, T first = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {            
            var components = range<N,T>(first).ToArray();
            return load<N,T>(components);
        }


        /// <summary>
        /// Allocates a block vector of natural length
        /// </summary>
        /// <param name="n">The length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector256<N,T> blockalloc<N,T>(N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => RowVector256<N,T>.Load(blocks.taballoc<T>(n256, natval(n)));
        
        /// <summary>
        /// Allocates a block vector optionally filled with a specified value
        /// </summary>
        /// <param name="length">The (minimum) length</param>
        /// <param name="fill">The fill value, if any</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector256<T> blockalloc<T>(int length)               
            where T : unmanaged
                => blocks.cellalloc<T>(n256,length);

        /// <summary>
        /// Loads a vector of natural length from a span that may not be aligned (Allocating if unaligned)
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static RowVector256<N,T> blockload<N,T>(Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => RowVector256<N,T>.Load(blocks.safeload(n256,src));

        [MethodImpl(Inline)]
        public static RowVector256<N,T> blockload<N,T>(Block256<T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => RowVector256<N, T>.Load(src);

        [MethodImpl(Inline)]
        public static RowVector256<N,T> blockload<N,T>(NatSpan<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src; 
    }
}