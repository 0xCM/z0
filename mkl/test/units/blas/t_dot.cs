//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;
    
    public class t_dot : t_mkl<t_dot>
    {
        [MethodImpl(Inline)]
        internal static T dot<T>(in RowVector256<T> lhs, in RowVector256<T> rhs)
            where T : unmanaged
                => mathspan.dot<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        internal static T dot<N,T>(in RowVector256<N,T> lhs, in RowVector256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => mathspan.dot<T>(lhs.Unsized,rhs.Unsized);

        public void dot32f()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF32(DefaultSampleSize);
                var y = RVecF32(DefaultSampleSize);
                Claim.eq(mkl.dot(x,y),dot(x,y));
            }
        }

        public void dot32fn()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF32(DefaultSampleNat);
                var y = RVecF32(DefaultSampleNat);
                Claim.eq(mkl.dot(x,y),dot(x,y));
            }
        }

        public void dot64f()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF64(DefaultSampleSize);
                var y = RVecF64(DefaultSampleSize);
                Claim.eq(mkl.dot(x,y),dot(x,y));
            }
        }

        public void dot64fn()
        {
            for(var i=0; i< DefaltCycleCount; i++)
            {
                var x = RVecF64(DefaultSampleNat);
                var y = RVecF64(DefaultSampleNat);                
                Claim.eq(mkl.dot(x,y),dot(x,y));
            }
        }
    }
}