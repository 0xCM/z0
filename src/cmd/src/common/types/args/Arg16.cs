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
    /// Defines a 16-bit argument
    /// </summary>
    public readonly struct Arg16 : IOperand<Arg16,W16,ushort>
    {
        public ushort Value {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Arg16(ushort value, OperandKind kind)
        {
            Value = value;
            ArgKind = kind;
        }

        public OperandSize Width => OperandSize.W16;

    }
}