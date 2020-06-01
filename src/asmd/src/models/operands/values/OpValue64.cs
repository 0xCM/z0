//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines the content of a 64-bit argument
    /// </summary>
    public readonly struct OpValue64 : IOperand<OpValue64,W64,ulong>
    {
        public ulong Data {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public OpValue64(ulong value, OperandKind kind)
        {
            Data = value;
            OpKind = kind;
        }

        public DataWidth Width => DataWidth.W64;
    }
}