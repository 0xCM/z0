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
    public readonly struct OpValue32 : IOperand<OpValue32,W32,uint>
    {
        public uint Data {get;}

        public OperandKind Kind {get;}

        [MethodImpl(Inline)]
        public OpValue32(uint value, OperandKind kind)
        {
            Data = value;
            Kind = kind;
        }

        public DataWidth Width => DataWidth.W32;
    }
}