//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class HexMapper
    {
        public readonly struct EncoderInput
        {
            [MethodImpl(Inline)]
            public EncoderInput(OpCodeExpression expression, Operand[] operands)
            {
                this.Expression = expression;
                this.Operands = operands;
            }
            
            public readonly OpCodeExpression Expression;

            public readonly Operand[] Operands;
        }
    }    
}