//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct root
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static T zero<T>()
            where T : unmanaged
                => default(T);
    }
}