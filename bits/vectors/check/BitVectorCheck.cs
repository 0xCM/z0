//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Components;

    public readonly struct BitVectorCheck : IBitVectorCheck
    {

    }

    public interface IBitVectorCheck : IBitVectorEqualityCheck, ICheckNumeric
    {
        static new IBitVectorCheck Checker => default(BitVectorCheck);
    }

    public interface IBitVectorEqualityCheck : 
        IEqualCheck<BitVector8>, 
        IEqualCheck<BitVector16>, 
        IEqualCheck<BitVector32>, 
        IEqualCheck<BitVector64>
    {
        [MethodImpl(Inline)]
        void IEqualCheck<BitVector8>.eq(BitVector8 x, BitVector8 y)
            => CheckNumeric.eq(x.Scalar, y.Scalar);

        [MethodImpl(Inline)]
        void IEqualCheck<BitVector16>.eq(BitVector16 x, BitVector16 y)
            => CheckNumeric.eq(x.Scalar, y.Scalar);

        [MethodImpl(Inline)]
        void IEqualCheck<BitVector32>.eq(BitVector32 x, BitVector32 y)
            => CheckNumeric.eq(x.Scalar, y.Scalar);

        [MethodImpl(Inline)]
        void IEqualCheck<BitVector64>.eq(BitVector64 x, BitVector64 y)
            => CheckNumeric.eq(x.Scalar, y.Scalar);
    }
}