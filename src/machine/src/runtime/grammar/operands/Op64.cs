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
    /// Defines a 64-bit argument
    /// </summary>
    public readonly struct Op64 : IOperand<Op64,W64,ulong>
    {
        public ulong Value {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Op64(ulong value, OperandKind kind)
        {
            Value = value;
            ArgKind = kind;
        }

        public DataWidth Width => DataWidth.W64;
    }
}