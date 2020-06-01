//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    /// <summary>
    /// Defines the content of a 512-bit argument
    /// </summary>
    public readonly struct OpValue256: IOperand<OpValue256,W256,Vector256<byte>>
    {
        public Vector256<byte> Data {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public OpValue256(Vector256<byte> value, OperandKind kind)
        {
            Data = value;
            OpKind = kind;
        }

        public DataWidth Width => DataWidth.W256;
    }
}