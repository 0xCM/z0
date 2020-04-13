//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static Seed;

    using Caller = System.Runtime.CompilerServices.CallerMemberNameAttribute;

    partial class TestContext<U>
    {
        protected virtual bool TraceEnabled
            => true;

        protected void trace(object msg, [Caller] string caller = null)
        {
            if(TraceEnabled)
                NotifyConsole(AppMsg.NoCaller($"{CaseName(caller)}: {msg}"));
        }

        protected void trace(object title, object msg, [Caller] string caller = null)
        {
            if(TraceEnabled)
                NotifyConsole(AppMsg.NoCaller($"{CaseName(caller)} {title} - {msg}"));
        }

        protected void trace(string title, string msg, int? tpad = null, AppMsgKind? severity = null, [Caller] string caller = null)
        {
            if(TraceEnabled)
            {
                var titleFmt = tpad.Map(pad => title.PadRight(pad), () => title.PadRight(20));        
                NotifyConsole(AppMsg.NoCaller($"{CaseName(caller)} {titleFmt}: {msg}", severity ?? AppMsgKind.Babble));
            }
        }

        protected void trace(AppMsg msg)
        {
            if(TraceEnabled)
                NotifyConsole(msg);
        }

        protected void trace(object msg, AppMsgColor color, [Caller] string caller = null)
        {
            if(TraceEnabled)
                NotifyConsole(AppMsg.Colorize($"{CaseName(caller)} {msg}", color));
        }
        
        protected void trace(string title, object msg, AppMsgColor color, [Caller] string caller = null)
        {
            if(TraceEnabled)
                NotifyConsole(AppMsg.Colorize($"{CaseName(caller)}  {title}: {msg}", color));
        }
    }
}