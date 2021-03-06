//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Mkl
{
    using System;
    using System.Linq;

    public static class EigenResult
    {
        public static EigenResult<N,T> Define<N,T>(in NatSpan<N,Complex<T>> values, in SpanBlock256<T> lv = default,  in SpanBlock256<T> rv = default)
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
        public EigenResult(in NatSpan<N,Complex<T>> values, in SpanBlock256<T> lv = default,  in SpanBlock256<T> rv = default)
        {
            this.Values = values;
            this.LeftVectors  = lv;
            this.RightVectors = rv;
        }

        public readonly NatSpan<N,Complex<T>> Values;

        public readonly SpanBlock256<T> LeftVectors;

        public readonly SpanBlock256<T> RightVectors;
    }
}