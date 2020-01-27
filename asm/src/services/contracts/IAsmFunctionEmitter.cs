//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using AsmSpecs;

    using static zfunc;
    
    public interface IAsmFunctionEmitter
    {
        void EmitCil(IEnumerable<AsmFunction> functions, FileName file);            

        void EmitAsm(IEnumerable<AsmFunction> disassembly, FileName file);        
    }
}