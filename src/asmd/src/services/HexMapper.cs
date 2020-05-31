//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public partial class HexMapper
    {
        public static Encoded encode(OpCodeExpression expression, params Operand[] operands)
            => encode(new EncoderInput(expression, operands));

        public static Encoded encode(EncoderInput input)
            => default;
        
        public static Decoded decode(byte[] src)
            => decode(new DecoderInput(src));

        public static Decoded decode(DecoderInput input)
            => default;
    }
}
