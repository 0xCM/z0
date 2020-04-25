//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using ULK = UnaryLogicKind;
    using BLK = BinaryLogicKind;
    using TLK = TernaryLogicKind;

    public interface IBitLogix : IService
    {
        UnaryOp<bit> Lookup(ULK kind);   

        BinaryOp<bit> Lookup(BLK kind);

        TernaryOp<bit> Lookup(TLK kind);

        bit Evaluate(ULK kind, bit a); 

        bit Evaluate(BLK kind, bit a, bit b);    

        bit Evaluate(TLK kind, bit a, bit b, bit c);
    }
}