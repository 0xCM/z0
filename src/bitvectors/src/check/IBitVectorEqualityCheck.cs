//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Seed;

    public interface IBitVectorEqualityCheck : IValidator
    {
        [MethodImpl(Inline)]
        void eq(BitVector8 x, BitVector8 y, string caller, string file, int? line)
            => CheckNumeric.eq(x.Scalar, y.Scalar, caller, file, line);

        [MethodImpl(Inline)]
        void eq(BitVector16 x, BitVector16 y, string caller, string file, int? line)
            => CheckNumeric.eq(x.Scalar, y.Scalar, caller, file, line);

        [MethodImpl(Inline)]
        void eq(BitVector32 x, BitVector32 y, string caller, string file, int? line)
            => CheckNumeric.eq(x.Scalar, y.Scalar, caller, file, line);

        [MethodImpl(Inline)]
        void eq(BitVector64 x, BitVector64 y, string caller, string file, int? line)
            => CheckNumeric.eq(x.Scalar, y.Scalar, caller, file, line);
    }
}