//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    public interface IAsmFunctionBuilder
    {
        AsmFunction BuildFunction(NativeMemberCapture src);

        AsmFunction BuildFunction(InstructionBlock src);
    }
}