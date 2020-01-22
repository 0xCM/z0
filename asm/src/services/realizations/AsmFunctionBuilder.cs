//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    class AsmFunctionBuilder : IAsmFunctionBuilder
    {
        public static IAsmFunctionBuilder Create()
            => new AsmFunctionBuilder();

        private AsmFunctionBuilder()
        {
            
        }
        
        public AsmFunction BuildFunction(NativeMemberCapture src)
            => AsmFunctions.define(src);
            
        public AsmFunction BuildFunction(InstructionBlock src)
            => AsmFunctions.define(src);
    }
}