//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public interface IAsmFormatter
    {
        string FormatDetail(AsmSpecs.AsmFunction src);        

    }

}


