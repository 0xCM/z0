//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    /// <summary>
    /// Defines a 256-bit argument
    /// </summary>
    public readonly struct Op256: IOperand<Op256,W256,Vector256<byte>>
    {
        public Vector256<byte> Data {get;}

        public OperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Op256(Vector256<byte> value, OperandKind kind)
        {
            Data = value;
            Kind = kind;
        }

        public DataWidth Width => DataWidth.W256;
    }
}