//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct root
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static Index<T> index<T>(params T[] src)
            => sys.array(src);
    }
}