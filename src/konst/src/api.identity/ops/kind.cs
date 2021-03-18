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

        public static OpIdentity kind<K,T>(K kind, T t = default)
            where K : unmanaged
            where T : unmanaged
                => build(kind.ToString().ToLower(), (TypeWidth)memory.width<T>(), Numeric.kind<T>(), true);
    }
}