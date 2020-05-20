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
    public readonly struct Op8 : IOperand<Op8,W8,byte>
    {
        public byte Value {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Op8(byte value, OperandKind kind)
        {
            Value = value;
            ArgKind = kind;
        }

        public DataWidth Width => DataWidth.W8;
    }
}