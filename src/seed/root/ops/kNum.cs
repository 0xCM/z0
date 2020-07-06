//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial class RootLegacy
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static NK<T> kNum<T>()
            where T : unmanaged
                => default;
    }
}