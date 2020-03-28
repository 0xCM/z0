//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    
    using static root;

    public readonly struct AsmInstructionCode
    {
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
    }
}