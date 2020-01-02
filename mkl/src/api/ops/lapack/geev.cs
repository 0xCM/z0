//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
 
    using static zfunc;
    using static nfunc;

    partial class mkl
    {
        public static EigenResult<N,double> geev<N>(Matrix256<N,double> A)
            where N : unmanaged, ITypeNat
        {
            var n = nati<N>();
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
                        
            exitcode = LAPACK.LAPACKE_dgeev(RowMajor, v, v, n, ref head(A), lda, ref head(wr), ref head(wi), 
                ref head(lVec), ldvl, ref head(rVec), ldvr);

            if(exitcode != 0)
                MklException.Throw(exitcode);

            return EigenResult.Define(ComplexNumber.FromPaired<N,double>(wr, wi), lVec, rVec);

        }

    }


}