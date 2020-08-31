//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static z;

    partial struct ApiQuery
    {
        [MethodImpl(Inline), Op]
        public static ApiSet apiset(params IPart[] parts)
            => new ApiSet(new ApiPart(parts));

        [MethodImpl(Inline), Op]
        public static IApiSet apiset(IResolvedApi resolved)
            => new ApiSet(resolved);
   }
}