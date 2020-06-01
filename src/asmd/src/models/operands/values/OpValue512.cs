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
    /// Defines the content of a 512-bit argument
    /// </summary>
    public readonly struct OpValue512: IOperand<OpValue512,W512,Vector512<byte>>
    {
        public Vector512<byte> Data {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public OpValue512(Vector512<byte> value, OperandKind kind)
        {
            Data = value;
            OpKind = kind;
        }

        public DataWidth Width => DataWidth.W512;
    }
}