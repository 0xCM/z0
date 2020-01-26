//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using static zfunc;

    public static class NativeX
    {
        public static AsmCodeIndex ToIndex(IEnumerable<AsmCode> src)        
            => AsmCodeIndex.Create(src);
    }

}