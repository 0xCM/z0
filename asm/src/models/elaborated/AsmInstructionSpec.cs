//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.AsmSpecs
{        
    using System;
    using static zfunc;

    public readonly struct AsmInstructionCode
    {
        public static AsmInstructionCode Define(string def, string opcode)
            => new AsmInstructionCode(def,opcode);

        AsmInstructionCode(string def, string opcode)
        {
            this.Definition = def;
            this.OpCode = opcode;
        }

        public readonly string Definition;

        public readonly string OpCode;
    }
}