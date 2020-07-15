//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static List<T> list<T>(params T[] src)
            => sys.list(src);    
    }
}