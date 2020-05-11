//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Models
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    /// <summary>
    /// Defines a 256-bit argument
    /// </summary>
    public readonly struct Arg256: IOperand<Arg256,W256,Vector256<byte>>
    {
        public Vector256<byte> Value {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Arg256(Vector256<byte> value, OperandKind kind)
        {
            Value = value;
            ArgKind = kind;
        }

        public OperandSize Width => OperandSize.W256;

    }
 
}