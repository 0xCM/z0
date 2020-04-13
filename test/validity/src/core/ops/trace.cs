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

        int CasePadding
            => Reports.width(TestCaseField.Case);

        IAppMsg TraceMsg(object title, object msg, string caller, AppMsgColor color = AppMsgColor.Magenta)
            => AppMsg.NoCaller(text.concat(text.concat(CaseName(caller), Chars.Space, title, Chars.Colon).PadRight(CasePadding), msg, color));

        IAppMsg TraceMsg(object msg, string caller, AppMsgColor color = AppMsgColor.Magenta)
            => AppMsg.NoCaller(text.concat(text.concat(CaseName(caller)).PadRight(CasePadding), msg, color));

        protected void trace(IAppMsg msg)
        {
            if(TraceEnabled)
                NotifyConsole(msg);
        }

        protected void trace(object msg, [Caller] string caller = null)
            => trace(TraceMsg(msg, caller));

        protected void trace(string title, object msg, AppMsgColor color, [Caller] string caller = null)
            => trace(TraceMsg(title, msg, caller, color));

        protected void trace(string title, string msg, int? tpad = null, AppMsgKind? severity = null, [Caller] string caller = null)
            => trace(TraceMsg(title, msg, caller));        
    }
}