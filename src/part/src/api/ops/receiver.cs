//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    partial struct Api
    {
        [KindFactory, Closures(Closure)]
        public static ReceiverClass<T> receiver<T>()
            where T : unmanaged => default;
    }
}