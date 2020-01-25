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

    using static zfunc;                
    using Z0.AsmSpecs;

    using Iced = Iced.Intel;

    public interface IAsmSpecBuilder
    {
        
        OpCodeInfo OpCodeInfo(Iced.OpCodeInfo src);        

        Instruction Instruction(Iced.Instruction src, string formatted);        

        AsmInstructionCode InstructionCode(Iced.Instruction src);        
    }

}