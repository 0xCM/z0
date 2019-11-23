//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;

    /// <summary>
    /// Defines the vector api surface
    /// </summary>
    public static class Vector
    {        
        [MethodImpl(NotInline)]
        public static Vector<T> alloc<T>(int minlen)               
            where T : unmanaged  
            => new Vector<T>(new T[minlen]);

        [MethodImpl(Inline)]
        public static Vector<N,T> alloc<N,T>(N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => alloc<T>((int)n.NatValue);

        [MethodImpl(Inline)]
        public static Vector<T> load<T>(T[] src)
            where T : unmanaged
                => new Vector<T>(src);

        /// <summary>
        /// Loads a vector of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> load<N,T>(T[] src, N length = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Vector<N, T>(src);

        /// <summary>
        /// Loads a vector of natural length
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static Vector<N,T> load<N,T>(N length, params T[] src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new Vector<N, T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> zero<N,T>()
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Vector<N,T>.Zero;
 
        public static Vector<N,T> increasing<N,T>(N length = default, T first = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {            
            var components = range<N,T>(first).ToArray();
            return load<N,T>(components);
        }

        public static Vector<N,T> decreasing<N,T>(N length = default, T first = default)
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
        public static VBlock256<N,T> blockalloc<N,T>(N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                =>  VBlock256<N,T>.Load(DataBlocks.alloc<N,T>(n256));
        
        /// <summary>
        /// Allocates a block vector optionally filled with a specified value
        /// </summary>
        /// <param name="length">The (minimum) length</param>
        /// <param name="fill">The fill value, if any</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static VBlock256<T> blockalloc<T>(int length)               
            where T : unmanaged
                => DataBlocks.cellalloc<T>(n256,length);

        /// <summary>
        /// Loads a vector of natural length from a span that may not be aligned (Allocating if unaligned)
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static VBlock256<N,T> blockload<N,T>(Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => VBlock256<N,T>.Load(DataBlocks.safeload(n256,src));

        [MethodImpl(Inline)]
        public static VBlock256<N,T> blockload<N,T>(Block256<T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => VBlock256<N, T>.Load(src);

        [MethodImpl(Inline)]
        public static VBlock256<N,T> blockload<N,T>(NatSpan<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src;
 
    }

}