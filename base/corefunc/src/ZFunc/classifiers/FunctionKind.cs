//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    [Flags]
    public enum FunctionKind : ulong
    {
        Action = Pow2.T03,

        Function = Pow2.T04,

        UnaryFunc = Pow2.T04 | Function,

        BinaryFunc = Pow2.T05 | Function,

        TernaryFunc = Pow2.T06 | Function,

        Operator = Pow2.T11 | Function,

        Emitter = Pow2.T12 | Function,

        UnaryOp = Pow2.T13 | UnaryFunc,

        BinaryOp = Pow2.T13 | BinaryFunc,

        TernaryOp = Pow2.T14 | TernaryFunc,

        PartiallyVectorized = Pow2.T59,

        TotallyVectorized = Pow2.T60,

        Vectorized = PartiallyVectorized | TotallyVectorized
    }
}