//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Root;

    partial struct root
    {

        [MethodImpl(Inline), Op]
        public static IndexedSeq<T> seq<T>(params T[] src)
            => new IndexedSeq<T>(src);
    }
}