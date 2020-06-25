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

    public static class NatSpan
    {
        /// <summary>
        /// Loads a bytespan of natural length from a generic source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The source value type</typeparam>
        [MethodImpl(Inline)]
        public static NatSpan<N,byte> bytes<N,T>(Span<T> src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
                => NatSpan.load(MemoryMarshal.AsBytes(src),n);

        /// <summary>
        /// Allocates span of natural length
        /// </summary>
        /// <param name="n">The cell count representative</param>
        /// <param name="t">A cell type representative</param>
        /// <typeparam name="N">The cell count type</typeparam>
        /// <typeparam name="T">The cell data type</typeparam>
        public static NatSpan<N,T> alloc<N,T>(N n = default, T t = default) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatSpan<N,T>(new T[TypeNats.value<N>()]);

        /// <summary>
        /// Fills a target block with replicated cell data
        /// </summary>
        /// <param name="data">The data used to fill the block</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The cell type</typeparam>        
        [MethodImpl(Inline)]
        public static void broadcast<N,T>(T data, in NatSpan<N,T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged        
                => dst.data.Fill(data); 

        /// <summary>
        /// Verifies correct source span length prior to backing store assignment
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The cell type</typeparam>
        /// <typeparam name="N">The length type</typeparam>
        [MethodImpl(Inline)]
        public static NatSpan<N,T> load<N,T>(Span<T> src, N n = default)
            where T : unmanaged
            where N : unmanaged, ITypeNat
        {
            
            Require(src.Length >= (int)TypeNats.value<N>());
            return new NatSpan<N,T>(src);
        }

        /// <summary>
        /// Loads a natural block from a reference
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="n">The length representative</param>
        /// <typeparam name="N">The length type</typeparam>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]   
        public static NatSpan<N,T> load<N,T>(ref T src, N n = default)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {                
            var data = MemoryMarshal.CreateSpan(ref src, (int)TypeNats.value<N>());
            return new NatSpan<N,T>(data);
        }

        [MethodImpl(Inline)]   
        public static NatSpan<N,T> parts<N,T>(N n, params T[] cells) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<T> src = cells;
            return load(src,n);
        }
    }
}