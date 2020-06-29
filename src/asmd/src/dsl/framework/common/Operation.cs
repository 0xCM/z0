//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    
    public readonly struct Operation
    {
        public readonly OpCodeIdentifier Id;
        
        public readonly OpCodeExpression Expression;

        public readonly InstructionExpression Instruction;

        [MethodImpl(Inline)]
        public Operation(OpCodeIdentifier id, OpCodeExpression cx, InstructionExpression ix)
        {
            Id = id;
            Expression = cx;
            Instruction = ix;
        }    
    }
}