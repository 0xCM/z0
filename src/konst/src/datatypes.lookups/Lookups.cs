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

    [ApiHost(ApiNames.Lookups)]
    public partial struct Lookups
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static StringLookup strings(ReadOnlySpan<StringRef> src)
            => new StringLookup(src);
    }
}