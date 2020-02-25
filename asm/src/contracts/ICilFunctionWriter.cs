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

    /// <summary>
    /// Defines service contract for persistent emission of cil functions that accompany asm functions
    /// </summary>
    public interface ICilFunctionWriter : IAsmService
    {
        /// <summary>
        /// The writer's destintation path
        /// </summary>
        FilePath Target {get;}        
        
        Option<Exception> WriteCil(IEnumerable<AsmFunction> functions);     

        Option<Exception> WriteCil(AsmFunctionGroup src);           
    }
}