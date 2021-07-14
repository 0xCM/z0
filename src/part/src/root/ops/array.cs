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
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] array<T>(IEnumerable<T> src)
            => sys.array(src);


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] array<T>(params T[] src)
            => sys.array(src);
    }
}