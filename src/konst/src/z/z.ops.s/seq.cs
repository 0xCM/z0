//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct z
    {
        [MethodImpl(Inline), Op]
        public static IndexedSeq<T> seq<T>(params T[] src)
            => new IndexedSeq<T>(src);
    }
}