//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
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
        public Vector128<byte> Value {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Op128(Vector128<byte> value, OperandKind kind)
        {
            Value = value;
            ArgKind = kind;
        }

        public DataWidth Width => DataWidth.W128;
    }
}