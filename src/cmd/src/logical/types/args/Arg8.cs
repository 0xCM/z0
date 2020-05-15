//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Logical
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    /// <summary>
    /// Defines an 8-bit argument
    /// </summary>
    public readonly struct Arg8 : IOperand<Arg8,W8,byte>
    {
        public byte Value {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Arg8(byte value, OperandKind kind)
        {
            Value = value;
            ArgKind = kind;
        }

        public OperandSize Width => OperandSize.W8;
    }

}