//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly partial struct ClrDynamic
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static MethodBase method(RuntimeMethodHandle src)
            => MethodBase.GetMethodFromHandle(src);
    }
}