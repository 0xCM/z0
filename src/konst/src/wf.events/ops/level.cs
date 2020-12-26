//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct WfEvents
    {
        [MethodImpl(Inline), Op]
        public static EventLevel level(FlairKind flair)
            => flair;

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static EventLevel level<T>(IWfEvent<T> src)
            where T : struct, IWfEvent<T>
                => src.Flair;
    }
}