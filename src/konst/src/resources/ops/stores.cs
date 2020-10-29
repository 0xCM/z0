//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Resources
    {
        [MethodImpl(Inline), Op]
        public static ConstBytesReader stores(N256 n)
            => new ConstBytesReader(new ConstBytes256());
    }
}