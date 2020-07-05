//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using static Root;

    using H = HexSymData;

    public readonly struct Digits
    {
        public static MemRef[] HexRefs
            => array(
                memref(H.UpperSymData),
                memref(H.LowerSymData), 
                memref(H.UpperCodes), 
                memref(H.LowerCodes)
                );

    }
}