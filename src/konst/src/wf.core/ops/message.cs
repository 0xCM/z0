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

    partial struct Workflow
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static AppMsg<T> message<T>(T content, string pattern, LogLevel kind, FlairKind flair, AppMsgSource origin)
            => new AppMsgData<T>(content, pattern ?? "{0}", kind, flair, origin);
    }
}