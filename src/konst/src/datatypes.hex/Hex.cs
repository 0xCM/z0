//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;
    using static z;

    using H = HexSymData;

    [ApiHost(ApiNames.SymbolicHex, true)]
    public partial class Hex
    {
        public static MemorySegment[] HexRefs
            => sys.array(memref(H.UpperSymData), memref(H.LowerSymData), memref(H.UpperCodes), memref(H.LowerCodes));

        const NumericKind Closure = UnsignedInts;
    }
}