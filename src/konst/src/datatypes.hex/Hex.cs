//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;
    using static z;

    using H = HexSymData;

    [ApiHost(ApiNames.SymbolicHex, true)]
    public partial class Hex
    {
        public static MemorySegment[] HexRefs
            => sys.array(segment(H.UpperSymData), segment(H.LowerSymData), segment(H.UpperCodes), segment(H.LowerCodes));

        const NumericKind Closure = UnsignedInts;
    }
}