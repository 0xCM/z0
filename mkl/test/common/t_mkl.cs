//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static nfunc;
    
    using Z0.Test;

    public abstract class t_mkl<U> : UnitTest<U>
        where U : t_mkl<U>
    {
        const int DefaultVectorLength = Pow2.T08;

        [MethodImpl(Inline)]
        protected RowVector256<T> RVec<T>(int? len = null, T rep = default)
            where T : unmanaged
                => Random.VectorBlock<T>(len ?? DefaultVectorLength);

        [MethodImpl(Inline)]
        protected RowVector256<N,T> RVec<N,T>(N len = default, T rep = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => Random.VectorBlock<N,T>();

        /// <summary>
        /// Produces a random matrix of natural dimension
        /// </summary>
        /// <param name="m">The row cound</param>
        /// <param name="n">The column count</param>
        /// <param name="rep">A representative scalar value</param>
        /// <typeparam name="M">The row count type</typeparam>
        /// <typeparam name="N">The column count type</typeparam>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        protected Matrix256<M,N,T> RMat<M,N,T>(Interval<T> domain, M m = default, N n = default)
            where T : unmanaged
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
                => Random.MatrixBlock<M,N,T>(domain);

        [MethodImpl(Inline)]
        protected RowVector256<float> RVecF32(int len, int? min = null, int? max = null)
            => Random.VectorBlock<int,float>(len, domain(min ?? -25, max ?? 25));

        [MethodImpl(Inline)]
        protected RowVector256<double> RVecF64(int len, long? min = null, long? max = null)
            => Random.VectorBlock<long,double>(len, domain(min ?? -25L, max ?? 25L));

        [MethodImpl(Inline)]
        protected RowVector256<float> RVecF32<N>(N len = default, int? min = null, int? max = null)
            where N : unmanaged, ITypeNat
                => Random.VectorBlock<N,int,float>(domain(min ?? -25, max ?? 25));

        [MethodImpl(Inline)]
        protected RowVector256<double> RVecF64<N>(N len = default, long? min = null, long? max = null)
            where N : unmanaged, ITypeNat
                => Random.VectorBlock<N,long,double>(domain(min ?? -25L, max ?? 25L));
    }
}