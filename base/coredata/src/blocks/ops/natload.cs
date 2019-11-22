//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.InteropServices;    
        
    using static zfunc;

    partial class DataBlocks
    {

        /// <summary>
        /// Loads a natural span from a reference
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="N">The natural length of the loaded span</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static NatBlock<N,T> natload<N,T>(N n, ref T src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatBlock<N,T>(ref src);

        [MethodImpl(Inline)]   
        public static NatBlock<N,T> natload<N,T>(N n, Span<T> src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatBlock<N,T>.CheckedTransfer(src);


        [MethodImpl(Inline)]   
        public static NatBlock<N,T> natload<N,T>(NatBlock<N,T> src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatBlock<N,T>(src);


        [MethodImpl(Inline)]   
        public static NatBlock<N,T> natparts<N,T>(N n, params T[] cells) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatBlock<N,T>.CheckedTransfer(cells);

    }

}