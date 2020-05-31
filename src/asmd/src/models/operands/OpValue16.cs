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
    /// Defines a 16-bit argument
    /// </summary>
    public readonly struct OpValue16 : IOperand<OpValue16,W16,ushort>
    {
        public ushort Data {get;}

        public OperandKind Kind {get;}

        [MethodImpl(Inline)]
        public OpValue16(ushort value, OperandKind kind)
        {
            Data = value;
            Kind = kind;
        }

        public DataWidth Width => DataWidth.W16;
    }
}