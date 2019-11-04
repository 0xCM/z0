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

    public static class IntMatrix
    {
        [MethodImpl(Inline)]
        public static ref Matrix<N,T> add<N,T>(Matrix<N,T> A, Matrix<N,T> B, ref Matrix<N,T> C)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            mathspan.add(A.Span, B.Span, C.Span);
            return ref C;
        }

        [MethodImpl(Inline)]
        public static ref Matrix<N,T> sub<N,T>(Matrix<N,T> A, Matrix<N,T> B, ref Matrix<N,T> C)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            mathspan.sub(A.Span, B.Span, C.Span);
            return ref C;
        }

        public static ref Matrix<N,T> mul<N,T>(Matrix<N,T> A, Matrix<N,T> B, ref Matrix<N,T> C)
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var tB = B.Transpose();
            for(var i=0; i<A.RowCount; i++)
            for(var j=0; j<B.ColCount; j++)
                C[i,j] = A[i] * tB[j];
            return ref C;
        }

        public static ref Matrix<M,N,T> mul<M,P,N,T>(Matrix<M,P,T> A, Matrix<P,N,T> B, ref Matrix<M,N,T> C)
            where M : unmanaged, ITypeNat
            where P : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            var tB = B.Transpose();
            for(var i=0; i<A.RowCount; i++)
            for(var j=0; j<B.ColCount; j++)
                C[i,j] = A[i] * tB[j];
            return ref C;
        }

    }
}