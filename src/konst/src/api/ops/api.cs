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

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        [MethodImpl(Inline), Op]
        public static ApiParts api(params IPart[] parts)
            => new ApiParts(parts);

        [MethodImpl(Inline), Op]
        public static ApiParts api(IEnumerable<IPart> parts)
            => new ApiParts(parts.ToArray());
    }
}