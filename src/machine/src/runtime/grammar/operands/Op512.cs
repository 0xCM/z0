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
    /// Defines a 512-bit argument
    /// </summary>
    public readonly struct Op512: IOperand<Op512,W512,Vector512<byte>>
    {
        public Vector512<byte> Data {get;}

        public OperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Op512(Vector512<byte> value, OperandKind kind)
        {
            Data = value;
            Kind = kind;
        }

        public DataWidth Width => DataWidth.W512;
    }
}