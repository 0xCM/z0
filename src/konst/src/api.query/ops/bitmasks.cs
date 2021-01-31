//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    partial struct ApiQuery
    {
        [Op]
        public static Index<BitMaskInfo> bitmasks(Type src)
            => BitMasks.rows(src);
    }
}