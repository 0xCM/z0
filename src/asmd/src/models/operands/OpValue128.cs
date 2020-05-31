//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;

    /// <summary>
    /// Defines the content of a 128-bit argument
    /// </summary>
    public readonly struct OpValue128: IOperand<OpValue128,W128,Vector128<byte>>
    {
        public Vector128<byte> Data {get;}

        public OperandKind Kind {get;}

        [MethodImpl(Inline)]
        public OpValue128(Vector128<byte> value, OperandKind kind)
        {
            Data = value;
            Kind = kind;
        }

        public DataWidth Width => DataWidth.W128;
    }
}