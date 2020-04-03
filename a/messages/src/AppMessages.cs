//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public static class AppMessages
    {
        public static IAppMsgWriter writer(FilePath target, string devname = null, 
            FileWriteMode mode = FileWriteMode.Overwrite, bool display = false)
                => AppMsgWriter.Open(target, devname, mode, display);

        public static IAppMsgExchange exchange(IAppMsgQueue dst)
            => AppMsgExchange.From(dst);

        public static IAppMsgExchange exchange()
            => AppMsgExchange.New();

        public static IAppMsgQueue queue(params AppMsg[] src)
            => AppMsgQueue.Create(src);
    }
}