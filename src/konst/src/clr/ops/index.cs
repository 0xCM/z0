//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static TypeCodeIndex index(in ClrTypeCodes src)
            => new TypeCodeIndex(src.Types);
    }
}