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
        public static IAppMsgWriter OpenAppMsgLog(this IContext context, FilePath target, string devname = null, 
            FileWriteMode mode = FileWriteMode.Overwrite, bool display = false)
                => AppMsgWriter.Open(context, target, devname, mode, display);
    }
}