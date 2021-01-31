//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    public class AsmSpecAttribute : Attribute
    {
        public string OpCode {get;}

        public string Sig {get;}

        public string Description {get;}

        public AsmSpecAttribute(string opcode, string sig, string desc = "")
        {
            OpCode = opcode;
            Sig = sig;
            Description = desc;
        }
    }
}