//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;
    using System.Reflection.Emit;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly partial struct ClrDynamic
    {
        const NumericKind Closure = UnsignedInts;

        [MethodImpl(Inline), Op]
        public static MethodBase method(RuntimeMethodHandle src)
            => MethodBase.GetMethodFromHandle(src);
    }
}