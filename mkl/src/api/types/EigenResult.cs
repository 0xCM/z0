//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;
 
    using static zfunc;
    using static nfunc;

    public static class EigenResult
    {
        public static EigenResult<N,T> Define<N,T>(in NatBlock<N,Complex<T>> values, in Block256<T> lv = default,  in Block256<T> rv = default)
            where N : unmanaged, ITypeNat
            where T : unmanaged
                => new EigenResult<N, T>(values, lv, rv);
    }

    /// <summary>
    /// Encapsulates eigenvalues and possibly eigenvectors
    /// </summary>
    public readonly ref struct EigenResult<N,T>
        where N : unmanaged, ITypeNat
        where T : unmanaged
    {
        public EigenResult(in NatBlock<N,Complex<T>> values, in Block256<T> lv = default,  in Block256<T> rv = default)
        {
            this.Values = values;
            this.LeftVectors  = lv;
            this.RightVectors = rv;
        }
        
        public readonly NatBlock<N,Complex<T>> Values;

        public readonly Block256<T> LeftVectors;

        public readonly Block256<T> RightVectors;

    }

}