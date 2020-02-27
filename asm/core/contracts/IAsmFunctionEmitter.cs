//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Collections.Generic;

    using Z0.Asm;
    
    public interface IFunctionEmitter
    {
        
    }

    public interface IAsmFunctionEmitter : IFunctionEmitter
    {
        Option<Exception> EmitAsm(IEnumerable<AsmFunction> disassembly, FilePath file);
    }
}