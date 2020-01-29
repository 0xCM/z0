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

    public interface ICilWriter
    {
        FilePath Target {get;}        
        
        Option<Exception> WriteCil(IEnumerable<AsmFunction> functions);     

        Option<Exception> WriteCil(AsmFunctionGroup src);           
    }
}