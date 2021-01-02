//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    public abstract class t_bitmatrix<X> : t_bitgrids_base<X>
        where X : t_bitmatrix<X>, new()
    {
        protected override int RepCount => Pow2.T04;

        protected override int CycleCount => Pow2.T03;

        protected void bm_extract_check<M,N,T>(BitMatrix<M,N,T> src)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var row=0; row< src.RowCount; row++)
            {
                var vector = src.ReadRow(row);
                for(var col=0; col<vector.Width; col++)
                {
                    var x = vector[col];
                    var y = src[row,col];
                    ClaimPrimal.eq(vector[col], src[row,col]);
                }
            }
        }

        protected void bm_transpose_check<M,N,T>(M m = default, N n = default, T t = default)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged
        {
            for(var sample = 0; sample <RepCount; sample++)
            {
                var A = Random.BitMatrix(m,n,t);
                var B = A.Transpose();
                for(var i=0; i<B.RowCount; i++)
                for(var j=0; j<B.ColCount; j++)
                    ClaimNumeric.eq(B[i,j], A[j,i]);
            }
        }

         protected void bm_and_bench<T>(T t = default)
            where T : unmanaged
        {
            var clock = counter();
            var a = BitMatrix.alloc<T>();
            var b = BitMatrix.alloc<T>();
            var c = BitMatrix.alloc<T>();

            for(var i=0; i<OpCount; i++)
            {
                Random.BitMatrix<T>(ref a);
                Random.BitMatrix<T>(ref b);
                clock.Start();
                BitMatrix.and(a, b, c);
                clock.Stop();
            }

            var n = BitMatrix<T>.N;
            ReportBenchmark($"bmand_{n}x{n}g", OpCount, clock);
        }
    }
}