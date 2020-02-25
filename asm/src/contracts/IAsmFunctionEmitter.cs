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
    
    public interface IFunctionEmitter
    {
        
    }

    public interface IAsmFunctionEmitter : IFunctionEmitter
    {
        Option<Exception> EmitAsm(IEnumerable<AsmFunction> disassembly, FilePath file);
    }
}