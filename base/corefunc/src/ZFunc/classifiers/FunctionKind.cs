//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    /// <summary>
    /// Defines function classification scheme
    /// </summary>
    [Flags]
    public enum FunctionKind : ulong
    {
        None = 0,

        Function = Pow2.T04,

        UnaryFunc = Pow2.T04 | Function,

        BinaryFunc = Pow2.T05 | Function,

        TernaryFunc = Pow2.T06 | Function,

        Operator = Pow2.T11 | Function,

        Emitter = Pow2.T12 | Function,

        UnaryOp = Pow2.T13 | UnaryFunc,

        BinaryOp = Pow2.T13 | BinaryFunc,

        TernaryOp = Pow2.T14 | TernaryFunc,

    }
}