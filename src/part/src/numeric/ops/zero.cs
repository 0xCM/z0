//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Numeric
    {
        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : unmanaged
                => default(T);
    }
}