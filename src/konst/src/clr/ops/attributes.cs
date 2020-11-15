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

    partial struct ClrQuery
    {
        [MethodImpl(Inline), Op]
        public static Index<object> attributes(Type src)
            => src.GetCustomAttributes(false);
    }
}