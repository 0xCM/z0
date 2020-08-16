//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public interface IAsmFunctionBuilder : IService
    {
        /// <summary>
        /// Builds a function from an instruction block
        /// </summary>
        /// <param name="uri">The operation uri</param>
        /// <param name="src">The instructions that comprise the function</param>
        AsmFunction BuildFunction(OpUri uri, string sig, AsmInstructionBlock src);   
    }
}