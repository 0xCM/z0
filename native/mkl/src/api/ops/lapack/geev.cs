//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class mkl
    {
        static NatSpan<N,Complex<T>> FromPaired<N,T>(NatSpan<N,T> re, NatSpan<N,T> im)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            Span<Complex<T>> dst = new Complex<T>[nat32i<N>()];
            for(var i=0; i< dst.Length; i++)
                dst[i] = (re[i], im[i]);
            return dst;
        }

        public static EigenResult<N,double> geev<N>(Matrix256<N,double> A)
            where N : unmanaged, ITypeNat
        {
            var n = nat32i<N>();
            var lda = n;
            var ldvl = n;
            var ldvr = n;
            var wslen = n*n;
            var exitcode = 0;
            var v = 'V';
            var wr = NatSpan.alloc<N,double>();
            var wi = NatSpan.alloc<N,double>();
            var lVec = A.Replicate();
            var rVec = A.Replicate();

            exitcode = LAPACK.LAPACKE_dgeev(RowMajor, v, v, n, ref head(A), lda, ref wr.First, ref wi.First,
                ref head(lVec), ldvl, ref head(rVec), ldvr);

            if(exitcode != 0)
                MklException.Throw(exitcode);

            return EigenResult.Define(FromPaired<N,double>(wr, wi), lVec, rVec);
        }
    }
}