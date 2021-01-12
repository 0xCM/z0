//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    partial struct ApiIdentify
    {
        [MethodImpl(Inline), Op]
        public static ApiClass kind(MethodInfo src)
        {
            if(src.Tag<OpKindAttribute>(out var dst))
                return dst.Id;
            else
                return 0;
        }
    }
}