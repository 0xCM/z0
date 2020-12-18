//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    using System.Collections.Generic;

    using static Part;

    partial struct memory
    {
        [Op, MethodImpl(NotInline), Closures(Closure)]
        public static T[] array<T>(IEnumerable<T> src)
            => src.Array();
    }
}