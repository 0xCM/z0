//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    /// <summary>
    /// Defines a 512-bit argument
    /// </summary>
    public readonly struct Op512: IOperand<Op512,W512,Vector512<byte>>
    {
        public Vector512<byte> Value {get;}

        public OperandKind ArgKind {get;}

        [MethodImpl(Inline)]
        public Op512(Vector512<byte> value, OperandKind kind)
        {
            Value = value;
            ArgKind = kind;
        }

        public DataWidth Width => DataWidth.W512;
    }
}