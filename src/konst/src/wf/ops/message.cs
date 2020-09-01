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

    partial struct AB
    {
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static AppMsg<T> message<T>(T content, string pattern, MessageKind kind, MessageFlair flair, AppMsgSource origin)
            => new AppMsgData<T>(content, pattern ?? "{0}", kind, flair, origin);
    }
}