//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IAsmFunctionBuilder
    {

        AsmFunction BuildFunction(InstructionBlock src);

        AsmSpecs.AsmFunction BuildFunction(AsmSpecs.AsmInstructionBlock src);
    }
}