//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;

    using static Part;
    using static memory;

    public class t_getrf : t_mkl<t_getrf>
    {
        // Taken from https://www.ibm.com/support/knowledgecenter/en/SSFHY8_6.1/reference/am5gr_hsgetrf.html
        static Matrix256<N9,double> DGETRF_In
            => Matrix.blockload(new double[]{
            1.0,  1.2,  1.4,  1.6,  1.8,  2.0,  2.2,  2.4,  2.6,
            1.2,  1.0,  1.2,  1.4,  1.6,  1.8,  2.0,  2.2,  2.4,
            1.4,  1.2,  1.0,  1.2,  1.4,  1.6,  1.8,  2.0,  2.2,
            1.6,  1.4,  1.2,  1.0,  1.2,  1.4,  1.6,  1.8,  2.0,
            1.8,  1.6,  1.4,  1.2,  1.0,  1.2,  1.4,  1.6,  1.8,
            2.0,  1.8,  1.6,  1.4,  1.2,  1.0,  1.2,  1.4,  1.6,
            2.2,  2.0,  1.8,  1.6,  1.4,  1.2,  1.0,  1.2,  1.4,
            2.4,  2.2,  2.0,  1.8,  1.6,  1.4,  1.2,  1.0,  1.2,
            2.6,  2.4,  2.2,  2.0,  1.8,  1.6,  1.4,  1.2,  1.0
            }, n9);

        static Matrix256<N9,double> DGETRF_Out
            => Matrix.blockload(new double[]{
                2.6,   2.4,  2.2,  2.0,  1.8,  1.6,  1.4,  1.2,  1.0,
                0.4,   0.3,  0.6,  0.8,  1.1,  1.4,  1.7,  1.9,  2.2,
                0.5,  -0.4,  0.4,  0.8,  1.2,  1.6,  2.0,  2.4,  2.8,
                0.5,  -0.3,  0.0,  0.4,  0.8,  1.2,  1.6,  2.0,  2.4,
                0.6,  -0.3,  0.0,  0.0,  0.4,  0.8,  1.2,  1.6,  2.0,
                0.7,  -0.2,  0.0,  0.0,  0.0,  0.4,  0.8,  1.2,  1.6,
                0.8,  -0.2,  0.0,  0.0,  0.0,  0.0,  0.4,  0.8,  1.2,
                0.8,  -0.1,  0.0,  0.0,  0.0,  0.0,  0.0,  0.4,  0.8,
                0.9,  -0.1,  0.0,  0.0,  0.0,  0.0,  0.0,  0.0,  0.4
            },n9);


        public void Getrf32()
        {


        }

        public void Getrf64_A()
        {
            var A = DGETRF_In;
            var X = A.Replicate();
            Span<int> pivots = new int[18];
            mkl.getrf(A, pivots, ref X);
            X.Apply(x => x.Round(1));
            Claim.require(X == DGETRF_Out);
        }

        void Getrf64<M,N>()
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
        {
            var m = nat32i<M>();
            var n = nat32i<N>();
            var cells = m*n;


            Span<int> pivots = new int[math.max(m,n)*2];

            var A = RMat<M,N,double>(Interval.closed(1,250.0)).Apply(x => x.Truncate());
            var X = Matrix.blockalloc<M,N,double>();
            mkl.getrf(A, pivots, ref X);
            X.Apply(x => x.Round(4));

        }

        public void Getrf64()
        {
            Getrf64<N8,N8>();
        }
    }
}