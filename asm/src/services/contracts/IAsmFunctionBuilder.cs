//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    public interface IAsmFunctionBuilder
    {
        AsmFunction BuildFunction(NativeMemberCapture src);

        AsmFunction BuildFunction(MethodDisassembly src);

        AsmFunction BuildFunction(InstructionBlock src);

        AsmFunction BuildFunction(InstructionBlock src, CilFunction cil);

        IEnumerable<AsmFunction> BuildFunctions(IEnumerable<NativeMemberCapture> src);

        IEnumerable<AsmFunction> BuildFunctions(IEnumerable<MethodDisassembly> src);
    }

}