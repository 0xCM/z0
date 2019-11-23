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
        public static ref VBlock256<N,T> or<N,T>(VBlock256<N,T> x, VBlock256<N,T> y, ref VBlock256<N,T> dst)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            vblock.or(x.Data,y.Data,dst.Data);
            return ref dst;
        }

        [MethodImpl(Inline)]
        public static VBlock256<T> or<T>(VBlock256<T> lhs, VBlock256<T> rhs)
            where T : unmanaged
        {
            var dst = lhs.Replicate(true);
            vblock.or(lhs.Data, rhs.Data, dst.Data);
            return dst;
        }


        [MethodImpl(Inline)]
        public static VBlock256<N,T> or<N,T>(VBlock256<N,T> x, VBlock256<N,T> y)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            var dst = x.Replicate(true);
            return or(x,y,ref dst);
        }


    }

}