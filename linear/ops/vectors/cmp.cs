//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static nfunc;
    using static zfunc;

    partial class Linear
    {

        [MethodImpl(Inline)]
        public static NatBlock<N,bool> eq<N,T>(VBlock256<N,T> lhs, VBlock256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => mathspan.eq<T>(lhs.Unsized, rhs.Unsized).NatLoad<N,bool>();            

        [MethodImpl(Inline)]
        public static Span<bool> eq<T>(VBlock256<T> lhs, in VBlock256<T> rhs)
            where T : unmanaged
                => mathspan.eq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> gt<T>(in VBlock256<T> lhs, in VBlock256<T> rhs)
            where T : unmanaged
            => mathspan.gt<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> gteq<T>(in VBlock256<T> lhs, in VBlock256<T> rhs)
            where T : unmanaged
            => mathspan.gteq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static Span<bool> lt<T>(in VBlock256<T> lhs, in VBlock256<T> rhs)
            where T : unmanaged
                => mathspan.lt<T>(lhs.Unblocked, rhs.Unblocked);            

        [MethodImpl(Inline)]
        public static Span<bool> lteq<T>(in VBlock256<T> lhs, in VBlock256<T> rhs)
            where T : unmanaged
                => mathspan.lteq<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        public static NatBlock<N,bool> neq<N,T>(in VBlock256<N,T> lhs, in VBlock256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged           
                => mathspan.neq<T>(lhs.Unsized, rhs.Unsized).NatLoad<N,bool>();                   

        [MethodImpl(Inline)]
        public static NatBlock<N,bool> gt<N,T>(in VBlock256<N,T> lhs, in VBlock256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged            
                => mathspan.gt<T>(lhs.Unsized, rhs.Unsized).NatLoad<N,bool>();            
        
        [MethodImpl(Inline)]
        public static NatBlock<N,bool> gteq<N,T>(in VBlock256<N,T> lhs, in VBlock256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => mathspan.gteq<T>(lhs.Unsized, rhs.Unsized).NatLoad<N,bool>();            

        [MethodImpl(Inline)]
        public static NatBlock<N,bool> lt<N,T>(in VBlock256<N,T> lhs, in VBlock256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => mathspan.lt<T>(lhs.Unsized, rhs.Unsized).NatLoad<N,bool>();            

        [MethodImpl(Inline)]
        public static NatBlock<N,bool> lteq<N,T>(in VBlock256<N,T> lhs, in VBlock256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => mathspan.lteq<T>(lhs.Unsized, rhs.Unsized).NatLoad<N,bool>();


    }

}