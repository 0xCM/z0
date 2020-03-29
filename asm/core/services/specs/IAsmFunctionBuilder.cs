//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using System;

    public interface IAsmFunctionBuilder : IAsmService
    {
        /// <summary>
        /// Builds a function from an instruction block
        /// </summary>
        /// <param name="op">The source operation</param>
        /// <param name="src">The instructions that comprise the function</param>
        AsmFunction BuildFunction(ApiMemberInfo op, AsmInstructionBlock src);   
    }
}