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

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static ResCacheReader stores(N256 n)
            => new ResCacheReader(new ResStore256());
    }
}