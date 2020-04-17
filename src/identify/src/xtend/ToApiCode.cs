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

    using static Seed;

    partial class XTend
    {
        [MethodImpl(Inline)]
        public static IdentifiedCode ToApiCode(this LocatedBits src)
            => IdentifiedCode.Define(src.Id, src.Encoded.Bytes);
    }
}