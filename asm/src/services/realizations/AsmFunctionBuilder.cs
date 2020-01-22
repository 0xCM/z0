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

    class AsmFunctionBuilder : IAsmFunctionBuilder
    {
        public static IAsmFunctionBuilder Create()
            => new AsmFunctionBuilder();

        private AsmFunctionBuilder()
        {
            
        }
        public AsmFunction BuildFunction(NativeMemberCapture src)
            => AsmFunctions.define(src);

        public AsmFunction BuildFunction(MethodDisassembly src)
            => AsmFunctions.define(src);
            
        public AsmFunction BuildFunction(InstructionBlock src)
            => AsmFunctions.define(src);

        public AsmFunction BuildFunction(InstructionBlock src, CilFunction cil)
            => AsmFunctions.define(src,cil);        

        public IEnumerable<AsmFunction> BuildFunctions(IEnumerable<MethodDisassembly> src)        
            => AsmFunctions.define(src);

        public IEnumerable<AsmFunction> BuildFunctions(IEnumerable<NativeMemberCapture> src)
            => src.Select(AsmFunctions.define);
    }
}