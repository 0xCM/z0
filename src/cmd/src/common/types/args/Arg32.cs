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
    /// Defines a 32-bit argument
    /// </summary>
    public readonly struct Arg32 : IOperand<Arg32,W32,uint>
    {
        public uint Value {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Arg32(uint value, OperandKind kind)
        {
            Value = value;
            ArgKind = kind;
        }

        public OperandSize Width => OperandSize.W32;
    }
}