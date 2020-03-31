//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Components;

    partial class Core
    {
        [MethodImpl(Inline)]
        public static T zero<T>()
            where T : unmanaged
                => default(T);

        [MethodImpl(Inline)]
        public static T zero<T>(T t)
            where T : unmanaged
                => default(T);
    }
}