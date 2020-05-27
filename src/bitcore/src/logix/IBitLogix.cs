//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using ULK = UnaryBitLogic;
    using BLK = BinaryLogicKind;
    using TLK = TernaryBitLogic;

    public interface IBitLogix : IService
    {
        UnaryOp<bit> Lookup(ULK kind);   

        BinaryOp<bit> Lookup(BLK kind);

        TernaryOp<bit> Lookup(TLK kind);

        bit Evaluate(ULK kind, bit a); 
        
        bit Evaluate(BLK kind, bit a, bit b);    

        bit Evaluate<F>(bit a, bit b, F kind = default)
            where F : unmanaged, IBitLogicKind;

        bit Evaluate(TLK kind, bit a, bit b, bit c);

        ReadOnlySpan<ULK> UnaryOpKinds {get;}

        ReadOnlySpan<BLK> BinaryOpKinds {get;}
        
        ReadOnlySpan<TLK> TernaryOpKinds {get;}
    }
}