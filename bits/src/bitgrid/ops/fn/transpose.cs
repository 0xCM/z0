//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;

    partial class BitGrid
    {        
        [MethodImpl(Inline)]
        public static BitGrid64<N8,N8,T> transpose<T>(BitGrid64<N8,N8,T> g)        
            where T : unmanaged
        {
            var dst = alloc64<N8,N8,byte>();            
            var src = dinx.vmov(n128,g);
            for(var i=7; i>= 0; i--)
            {
                dst[i] = (byte)dinx.vmovemask(v8u(src));
                src = dinx.vsll(src,1);
            }
            return dst.As<T>();
        }

        [MethodImpl(Inline)]
        internal static BitGrid128<P,Q,T> resize<M,N,P,Q,T>(in BitGrid128<M,N,T> src, P p = default, Q q = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where P : unmanaged, ITypeNat
            where Q : unmanaged, ITypeNat
            where T : unmanaged
                => src.Data;
    }

}