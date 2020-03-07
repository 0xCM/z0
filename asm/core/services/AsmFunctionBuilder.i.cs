//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    using Z0.Asm;    

    public interface IAsmFunctionBuilder : IAsmService
    {
        /// <summary>
        /// Builds a function from an instruction block
        /// </summary>
        /// <param name="op">The source operation</param>
        /// <param name="src">The instructions that comprise the function</param>
        AsmFunction BuildFunction(MemberDescriptor op, AsmInstructionBlock src);   
    }
}