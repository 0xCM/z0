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
    /// Defines a 32-bit argument
    /// </summary>
    public readonly struct Op32 : IOperand<Op32,W32,uint>
    {
        public uint Value {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Op32(uint value, OperandKind kind)
        {
            Value = value;
            ArgKind = kind;
        }

        public DataWidth Width => DataWidth.W32;
    }
}