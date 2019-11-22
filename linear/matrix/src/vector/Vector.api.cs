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
        public static Vector<T> alloc<T>(int minlen, T? fill = null)               
            where T : unmanaged  
        {      
            var mem = new T[minlen];
            if(fill.HasValue)                
                mem.Fill(fill.Value);
            return new Vector<T>(mem);
        }

        [MethodImpl(Inline)]
        public static Vector<N,T> alloc<N,T>(N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                =>  alloc<T>((int)n.NatValue);

        [MethodImpl(Inline)]
        public static Vector<N,T> alloc<N,T>(N n, T fill)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                =>  alloc<T>((int)n.NatValue, fill);

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
        public static BlockVector<N,T> blockalloc<N,T>(N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                =>  BlockVector<N,T>.LoadAligned(Block256.allocu<N,T>());

        /// <summary>
        /// Allocates a block vector of natural length filled with a specified value
        /// </summary>
        /// <param name="n">The length</param>
        /// <param name="fill">The fill value</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> blockalloc<N,T>(N n, T fill)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                =>  BlockVector<N,T>.LoadAligned(Block256.allocu<N,T>(fill));
        
        /// <summary>
        /// Allocates a block vector optionally filled with a specified value
        /// </summary>
        /// <param name="n">The (minimum) length</param>
        /// <param name="fill">The fill value, if any</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<T> blockalloc<T>(int n, T? fill = null)               
            where T : unmanaged
                => Block256.allocu<T>(n, fill);

        /// <summary>
        /// Loads a vector of natural length from a span that may not be aligned (Allocating if unaligned)
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="n">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> blockload<N,T>(Span<T> src, N n = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BlockVector<N,T>.LoadAligned(Block256.load(src));

        /// <summary>
        /// Loads a vector of natural length from a parameter array.
        /// This method allocates if the source array is not 256-bit aligned
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="length">The natural length</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<N,T> blockload<N,T>(N length, params T[] src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BlockVector<N,T>.LoadAligned(Block256.load<T>(src));

        /// <summary>
        /// Loads a block vector from a source span, allocating if the span is not 256-bit aligned
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static BlockVector<T> blockload<T>(Span<T> src)
            where T : unmanaged
                => Block256.load(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> blockload<N,T>(Block256<T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => BlockVector<N, T>.LoadAligned(src);

        [MethodImpl(Inline)]
        public static BlockVector<N,T> blockload<N,T>(NatBlock<N,T> src)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => src;
 
    }

}