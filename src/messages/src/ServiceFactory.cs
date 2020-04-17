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
        public static IAppMsgLog MessageLog(this IAppEnv env)
            => AppMsgLog.Create(env);        
    }
}