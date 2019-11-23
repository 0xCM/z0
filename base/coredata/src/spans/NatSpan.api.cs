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

    public static class NatSpan
    {

        [MethodImpl(Inline)]   
        public static NatSpan<N,T> alloc<N,T>(N n = default, T fill = default) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatSpan<N,T>(fill);

        [MethodImpl(Inline)]   
        public static NatSpan<M,N,T> alloc<M,N,T>(M m = default, N n = default, T fill = default) 
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatSpan<M,N,T>(fill);

        [MethodImpl(Inline)]   
        public static NatSpan<N,T> load<N,T>(ref T src, N n = default)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatSpan<N,T>(ref src);

        [MethodImpl(Inline)]   
        public static NatSpan<N,T> load<N,T>(Span<T> src, N n = default)    
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatSpan<N,T>.CheckedTransfer(src);

        [MethodImpl(Inline)]   
        public static NatSpan<M,N,T> load<M,N,T>(ref T src, M m = default, N n = default)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new NatSpan<M,N,T>(ref src);

        [MethodImpl(Inline)]   
        public static NatSpan<M,N,T> load<M,N,T>(Span<T> src, M m = default, N n = default)    
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatSpan<M,N,T>.CheckedTransfer(src);

        [MethodImpl(Inline)]   
        public static NatSpan<N,T> parts<N,T>(N n, params T[] cells) 
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => NatSpan<N,T>.CheckedTransfer(cells);
    }
}
