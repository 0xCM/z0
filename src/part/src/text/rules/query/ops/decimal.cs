//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct TextQuery
    {
        [MethodImpl(Inline), Op]
        public static bit @decimal(char c)
            => (DecimalSymFacet)c >= DecimalSymFacet.First && (DecimalSymFacet)c <= DecimalSymFacet.Last;
    }
}