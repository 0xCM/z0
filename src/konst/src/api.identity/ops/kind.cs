//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Root;

    partial struct ApiIdentity
    {
        [MethodImpl(Inline), Op]
        public static ApiClass kind(MethodInfo src)
        {
            if(src.Tag<OpKindAttribute>(out var dst))
                return dst.ClassId;
            else
                return 0;
        }
    }
}