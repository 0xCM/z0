//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Numerics;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;    
        
    using static zfunc;
    using static nfunc;

    /// <summary>
    /// Defines the vector api surface
    /// </summary>
    public static class Vector
    {        
        [MethodImpl(Inline)]
        public static Vector<T> alloc<T>(int minlen, T? fill = null)               
            where T : unmanaged        
                => new Vector<T>(MemorySpan.Alloc<T>(minlen, fill));

        [MethodImpl(Inline)]
        public static Vector<N,T> alloc<N,T>(N n = default)
            where N : ITypeNat, new()
            where T : unmanaged
                =>  alloc<T>((int)n.value);

        [MethodImpl(Inline)]
        public static Vector<N,T> alloc<N,T>(N n, T fill)
            where N : ITypeNat, new()
            where T : unmanaged
                =>  alloc<T>((int)n.value, fill);

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
            where N : ITypeNat, new()
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
            where N : ITypeNat, new()
            where T : unmanaged
                => new Vector<N, T>(src);

        [MethodImpl(Inline)]
        public static Vector<N,T> zero<N,T>()
            where N : ITypeNat, new()
            where T : unmanaged
                => Vector<N,T>.Zero;
 
        public static Vector<N,T> increasing<N,T>(N length = default, T first = default)
            where N : ITypeNat, new()
            where T : unmanaged
        {            
            var components = range<N,T>(first).ToArray();
            return load<N,T>(components);
        }

        public static Vector<N,T> decreasing<N,T>(N length = default, T first = default)
            where N : ITypeNat, new()
            where T : unmanaged
        {            
            var components = range<N,T>(first).ToArray();
            return load<N,T>(components);
        }

    }

}