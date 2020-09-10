//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Iced = Iced.Intel;

    partial class IceExtractors
    {
        public static AsmFxCode FxCode(Iced.Instruction src)
        {
            var opcode = Iced.EncoderCodeExtensions.ToOpCode(src.Code);
            return new AsmFxCode(opcode.ToInstructionString(), opcode.ToOpCodeString());
        }
    }
}