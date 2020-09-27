//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using ULK = UnaryBitLogicKind;
    using BLK = BinaryBitLogicKind;
    using TLK = TernaryBitLogicKind;

    public interface IBitLogix
    {
        UnaryOp<Bit32> Lookup(ULK kind);

        BinaryOp<Bit32> Lookup(BLK kind);

        TernaryOp<Bit32> Lookup(TLK kind);

        Bit32 Evaluate(ULK kind, Bit32 a);

        Bit32 Evaluate(BLK kind, Bit32 a, Bit32 b);

        Bit32 Evaluate<F>(Bit32 a, Bit32 b, F kind = default)
            where F : unmanaged, IBitLogicKind;

        Bit32 Evaluate(TLK kind, Bit32 a, Bit32 b, Bit32 c);

        ReadOnlySpan<ULK> UnaryOpKinds {get;}

        ReadOnlySpan<BLK> BinaryOpKinds {get;}

        ReadOnlySpan<TLK> TernaryOpKinds {get;}
    }
}