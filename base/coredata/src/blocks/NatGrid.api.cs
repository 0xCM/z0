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
    
    public static class NatGrid
    {        
        [MethodImpl(Inline)]   
        public static NatGrid<M,N,T> alloc<M,N,T>(T fill = default(T), M m = default, N n = default) 
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatGrid<M,N,T>(fill);

        [MethodImpl(Inline)]   
        public static NatGrid<M,N,T> alloc<M,N,T>(M m, N n, T fill = default) 
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatGrid<M,N,T>(fill);

        /// <summary>
        /// Loads a natural span from a reference
        /// </summary>
        /// <param name="src"></param>
        /// <typeparam name="N">The natural length of the loaded span</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]   
        public static NatGrid<M,N,T> load<M,N,T>(M m, N n, ref T src)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatGrid<M,N,T>(ref src);

        [MethodImpl(Inline)]   
        public static NatGrid<M,N,T> load<M,N,T>(M m, N n, Span<T> src)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatGrid<M,N,T>.CheckedTransfer(src);

        [MethodImpl(Inline)]   
        public static NatGrid<M,N,T> load<M,N,T>(ReadOnlySpan<T> src, M m = default, N n = default)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatGrid<M,N,T>(src);

        [MethodImpl(Inline)]   
        public static NatGrid<M,N,T> load<M,N,T>(Span<T> src, M m = default, N n = default)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatGrid<M,N,T>(src);
    }

}