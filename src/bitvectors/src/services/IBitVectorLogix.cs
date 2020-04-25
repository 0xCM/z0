//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static LogicSig;

    using BLK = BinaryLogicKind;

    public interface IBitVectorLogix
    {
        BinaryOp<BitVector<T>> Lookup<T>(BLK kind)
            where T : unmanaged;

        BitVector<T> EvalDirect<T>(BLK kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged;

        BitVector<T> EvalRef<T>(BLK kind, BitVector<T> x, BitVector<T> y)
            where T : unmanaged;
    }    
}