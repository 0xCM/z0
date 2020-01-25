//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.AsmSpecs;
    using Iced = Iced.Intel;

    using static zfunc;                

    readonly struct AsmSpecBuilder : IAsmSpecBuilder
    {
        public OpCodeInfo OpCodeInfo(Iced.OpCodeInfo src)
            => src.ToSpec();

        public Instruction Instruction(Iced.Instruction src, string formatted)
            => src.ToSpec(formatted);

        public AsmInstructionCode InstructionCode(Iced.Instruction src)
            => src.InstructionCode();        
    }
}