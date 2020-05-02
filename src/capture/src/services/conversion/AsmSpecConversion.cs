//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    using Iced = Iced.Intel;

    static partial class AsmSpecConversion
    {
        public static AsmInstructionCode ToInstructionCode(this Iced.Instruction src)
        {
            var opcode = Iced.EncoderCodeExtensions.ToOpCode(src.Code);
            return AsmInstructionCode.Define(opcode.ToInstructionString(), opcode.ToOpCodeString());
        }
   }
}