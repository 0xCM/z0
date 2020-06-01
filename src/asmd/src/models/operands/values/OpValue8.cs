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
    /// Defines an 8-bit argument
    /// </summary>
    public readonly struct OpValue8 : IOperand<OpValue8,W8,byte>
    {
        public byte Data {get;}

        public OperandKind OpKind {get;}

        [MethodImpl(Inline)]
        public OpValue8(byte value, OperandKind kind)
        {
            Data = value;
            OpKind = kind;
        }

        public DataWidth Width => DataWidth.W8;
    }
}