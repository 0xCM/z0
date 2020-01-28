//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.IO;
    using AsmSpecs;
    using System.Runtime.CompilerServices;

    using static zfunc;

    public interface ICilWriter
    {
        Option<Exception> WriteCil(IEnumerable<AsmFunction> functions);     

        Option<Exception> WriteCil(AsmFunctionGroup src);           
    }

}