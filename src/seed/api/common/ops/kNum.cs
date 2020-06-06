//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Seed;

    partial class Seed
    {
        [MethodImpl(Inline)]
        public static NK<T> kNum<T>()
            where T : unmanaged
                => default;
    }
}