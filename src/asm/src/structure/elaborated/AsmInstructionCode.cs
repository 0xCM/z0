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
        const string Sep = CharText.Space + CharText.Pipe + CharText.Pipe + CharText.Space;

        public readonly string Definition;

        public readonly string OpCode;

        [MethodImpl(Inline)]
        public static AsmInstructionCode Define(string def, string opcode)
            => new AsmInstructionCode(def,opcode);

        [MethodImpl(Inline)]
        AsmInstructionCode(string def, string opcode)
        {
            this.Definition = def;
            this.OpCode = opcode;
        }

        public string Format()
            => String.Concat(Definition, Sep, OpCode);
        
        public override string ToString()
            => Format();
    }
}