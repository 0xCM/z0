//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Seed;    
    using static Control;
    using static Symbolic;
    using static SymbolKonst;

    partial class SymbolicData
    {
        public static IEnumerable<MemRef> Refs
            => seq(memref(UpperHexSymbolData),
                memref(LowerHexSymbolData), 
                memref(UpperHexCodes), 
                memref(LowerHexCodes));
    }
}