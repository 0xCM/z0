//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static Seed;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    public interface ITracer : IConsoleNotifier
    {
        bool TraceEnabled => true;

        void trace(IAppMsg msg)        
        {
            if(TraceEnabled)
                NotifyConsole(msg);
        }


        void trace(object msg, [Caller] string caller = null);

        void trace(string title, object msg, AppMsgColor color, [Caller] string caller = null);

        void trace(string title, string msg, int? tpad = null, AppMsgKind? severity = null, [Caller] string caller = null);        
    }
}