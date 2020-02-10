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

    public interface ICilFunctionEmitter : IFunctionEmitter
    {
        Option<Exception> EmitCil(IEnumerable<AsmFunction> functions, FilePath dst);
    }
}