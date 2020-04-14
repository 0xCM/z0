//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;
    
    public class t_dot : t_mkl<t_dot>
    {
        [MethodImpl(Inline)]
        internal static T dot<T>(in RowVector256<T> lhs, in RowVector256<T> rhs)
            where T : unmanaged
                => gspan.dot<T>(lhs.Unblocked, rhs.Unblocked);

        [MethodImpl(Inline)]
        internal static T dot<N,T>(in RowVector256<N,T> lhs, in RowVector256<N,T> rhs)
            where N : unmanaged, ITypeNat
            where T : unmanaged    
                => gspan.dot<T>(lhs.Unsized,rhs.Unsized);

        public void dot32f()
        {
            for(var i=0; i< CycleCount; i++)
            {
                var x = RVecF32(RepCount);
                var y = RVecF32(RepCount);
                Claim.almost(mkl.dot(x,y),dot(x,y));
            }
        }

        public void dot32fn()
        {
            for(var i=0; i< CycleCount; i++)
            {
                var x = RVecF32(n256);
                var y = RVecF32(n256);
                Claim.almost(mkl.dot(x,y),dot(x,y));
            }
        }

        public void dot64f()
        {
            for(var i=0; i< CycleCount; i++)
            {
                var x = RVecF64(RepCount);
                var y = RVecF64(RepCount);
                Claim.almost(mkl.dot(x,y),dot(x,y));
            }
        }

        public void dot64fn()
        {
            for(var i=0; i< CycleCount; i++)
            {
                var x = RVecF64(n256);
                var y = RVecF64(n256);                
                Claim.almost(mkl.dot(x,y),dot(x,y));
            }
        }
    }
}