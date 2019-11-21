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
    
    public static class NatBlock
    {        

        [MethodImpl(Inline)]   
        public static NatBlock<N,T> alloc<N,T>(T fill = default(T), N n = default) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatBlock<N,T>(fill);

        [MethodImpl(Inline)]   
        public static NatBlock<N,T> alloc<N,T>(N n, T fill = default) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatBlock<N,T>(fill);

        [MethodImpl(Inline)]   
        public static NatBlock<N,T> load<N,T>(N n, T[] src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatBlock<N,T>.CheckedTransfer(src);

        /// <summary>
        /// Creates a copy of the source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="N">The natural length</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static NatBlock<N,T> load<N,T>(N n, ReadOnlySpan<T> src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatBlock<N,T>.CheckedTransfer(src);

        /// <summary>
        /// Loads a natural span from a reference
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="N">The natural length of the loaded span</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static NatBlock<N,T> load<N,T>(N n, ref T src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatBlock<N,T>(ref src);

        [MethodImpl(Inline)]   
        public static NatBlock<N,T> load<N,T>(N n, Span<T> src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatBlock<N,T>.CheckedTransfer(src);


        [MethodImpl(Inline)]   
        public static NatBlock<N,T> load<N,T>(NatBlock<N,T> src)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatBlock<N,T>(src);


        [MethodImpl(Inline)]   
        public static NatBlock<N,T> parts<N,T>(N n, params T[] elements) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatBlock<N,T>.CheckedTransfer(elements);
    }
}