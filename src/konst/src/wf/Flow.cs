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

    [ApiHost]
    public readonly partial struct Flow
    {
        [MethodImpl(Inline), Op]
        public static bool eq(WfType a, WfType b)
            => a.Source == b.Source && a.Target == b.Target;
    }
}