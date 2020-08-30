//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    using static z;

    partial struct Table
    {
        [MethodImpl(Inline)]
        public static T init<T>()
            where T : struct
                => new T();
    }
}