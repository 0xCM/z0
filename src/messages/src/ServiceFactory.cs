//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Threading;

    public static class ServiceFactory
    {
        public static IAppMsgSink MessageLog(this IAppEnv env)
            => AppMsgLog.Create(env);

        public static IAppMsgWriter AppMsgWriter(this IContext context, FilePath target, string devname = null, 
            FileWriteMode mode = FileWriteMode.Overwrite, bool display = false)
                => AppMessages.writer(target, devname, mode, display);
    }
}