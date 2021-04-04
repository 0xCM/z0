//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using H = HexCharData;

    [ApiHost]
    public partial class Hex
    {
        public static MemorySegment[] HexRefs
            => sys.array(memseg(H.UpperSymData), memseg(H.LowerSymData), memseg(H.UpperCodes), memseg(H.LowerCodes));

        const NumericKind Closure = UnsignedInts;
    }
}