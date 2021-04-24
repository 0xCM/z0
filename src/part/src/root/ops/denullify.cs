//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct root
    {
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static T denullify<T>(T? src, T @default = default)
            where T : struct
        {
            ref readonly var data = ref memory.@as<T?,byte>(src);
            ref readonly var test = ref @bool(data);
            return test ? @as<byte,T>(skip(data,1)) : @default;
        }
    }
}