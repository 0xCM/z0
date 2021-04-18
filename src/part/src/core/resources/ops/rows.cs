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

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static Index<StringResRow> rows(Index<StringRes> src)
            => src.Select(r => row(r));
    }
}