//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines an 8-bit argument
    /// </summary>
    public readonly struct Op8 : IOperand<Op8,W8,byte>
    {
        public byte Data {get;}

        public OperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Op8(byte value, OperandKind kind)
        {
            Data = value;
            Kind = kind;
        }

        public DataWidth Width => DataWidth.W8;
    }
}