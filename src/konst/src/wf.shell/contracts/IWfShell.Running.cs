//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Reflection;

    using static z;
    using static WfShellUtility;
    using static WfEvents;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;
    using File = System.Runtime.CompilerServices.CallerFilePathAttribute;
    using Line = System.Runtime.CompilerServices.CallerLineNumberAttribute;

    partial interface IWfShell
    {
        WfExecFlow Running()
        {
            SignalRunning();
            return Flow();
        }

        WfExecFlow Running<T>(T content)
        {
            SignalRunning(content);
            return Flow();
        }

        void SignalRunning()
            => Raise(running(Host, Ct));

        void SignalRunning<T>(T src)
            => Raise(running(Host, src, Ct));
    }
}