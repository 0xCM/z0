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
    /// Defines a 16-bit argument
    /// </summary>
    public readonly struct Op16 : IOperand<Op16,W16,ushort>
    {
        public ushort Value {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Op16(ushort value, OperandKind kind)
        {
            Value = value;
            ArgKind = kind;
        }

        public DataWidth Width => DataWidth.W16;
    }
}