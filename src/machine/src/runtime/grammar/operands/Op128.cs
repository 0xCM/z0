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
    /// Defines a 128-bit argument
    /// </summary>
    public readonly struct Op128: IOperand<Op128,W128,Vector128<byte>>
    {
        public Vector128<byte> Data {get;}

        public OperandKind Kind {get;}

        [MethodImpl(Inline)]
        public Op128(Vector128<byte> value, OperandKind kind)
        {
            Data = value;
            Kind = kind;
        }

        public DataWidth Width => DataWidth.W128;
    }
}