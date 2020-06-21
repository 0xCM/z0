//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;
    using static Root;
    using static SymbolKonst;

    public readonly struct Digits
    {
        public static IEnumerable<MemRef> HexRefs
            => seq(
                memref(UpperHexSymbolData),
                memref(LowerHexSymbolData), 
                memref(UpperHexCodes), 
                memref(LowerHexCodes)
                );

    }
}