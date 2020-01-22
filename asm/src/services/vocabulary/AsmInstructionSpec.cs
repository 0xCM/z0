//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using static zfunc;

    public readonly struct AsmInstructionSpec
    {
        public static AsmInstructionSpec Define(string def, string opcode)
            => new AsmInstructionSpec(def,opcode);

        AsmInstructionSpec(string def, string opcode)
        {
            this.Definition = def;
            this.OpCode = opcode;
        }

        public readonly string Definition;

        public readonly string OpCode;
    }
}