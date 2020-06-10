//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    /// <summary>
    /// Captures an asm opcode together with an instruction string
    /// </summary>
    public readonly struct AsmInstructionCode : ITextual
    {    
        public readonly string OpCode;

        public readonly string Expression;
        
        [MethodImpl(Inline)]
        public static AsmInstructionCode Define(string opcode, string expr)
            => new AsmInstructionCode(opcode,expr);

        [MethodImpl(Inline)]
        AsmInstructionCode(string opcode, string expr)
        {
            Expression = expr;
            OpCode = opcode;
        }

        const string Sep = CharText.Space + CharText.Pipe + CharText.Pipe + CharText.Space;

        public string Format()
            => String.Concat(Expression, Sep, OpCode);
        
        public override string ToString()
            => Format();
    }
}