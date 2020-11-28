//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;
    using static z;

    partial struct Records
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static DynamicRow<T> row<T>(uint cells)
            where T : struct
                => new DynamicRow<T>(0, default(T), sys.alloc<dynamic>(cells));
    }
}
