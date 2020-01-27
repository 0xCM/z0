//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

    using Z0.AsmSpecs;

    public interface IAsmFunctionFormatter
    {
        AsmFormatConfig Config {get;}        
        
        string FormatDetail(AsmFunction src);        

    }

}


