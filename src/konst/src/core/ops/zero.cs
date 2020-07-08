//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct core
    {
        [MethodImpl(Inline)]
        public static T zero<T>(T t = default)
            where T : unmanaged
                => default(T);
    }
}