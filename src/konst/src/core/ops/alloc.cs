//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] alloc<T>(uint count)
            => sys.alloc<T>(count);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T[] alloc<T>(long count)
            => sys.alloc<T>((int)count);
    }
}