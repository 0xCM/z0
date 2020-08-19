//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;

    /// <summary>
    /// Captures an asm opcode together with an instruction string
    /// </summary>
    public readonly struct AsmFxCode : ITextual
    {    
        public readonly string OpCode;

        public readonly string Expression;
        
        [MethodImpl(Inline)]
        public AsmFxCode(string opcode, string expr)
        {
            Expression = expr;
            OpCode = opcode;
        }

        public string Format()
            => String.Concat(Expression, SpacePipe, OpCode);
        
        public override string ToString()
            => Format();
    }
}