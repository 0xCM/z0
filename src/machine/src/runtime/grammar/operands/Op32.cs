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
    /// Defines a 32-bit argument
    /// </summary>
    public readonly struct Op32 : IOperand<Op32,W32,uint>
    {
        public uint Data {get;}

        public OperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Op32(uint value, OperandKind kind)
        {
            Data = value;
            Kind = kind;
        }

        public DataWidth Width => DataWidth.W32;
    }
}