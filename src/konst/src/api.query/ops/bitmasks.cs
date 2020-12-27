//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    partial struct ApiQuery
    {
        [Op]
        public static BitMaskInfo[] bitmasks(Type src)
            => BitMasks.rows(src);
    }
}