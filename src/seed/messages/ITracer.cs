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

    public interface IAppMsgTrace
    {
        void trace(IAppMsg msg);        

        void trace(object msg, [Caller] string caller = null);

        void trace(string title, object msg, AppMsgColor color, [Caller] string caller = null);

        void trace(string title, string msg, int? tpad = null, AppMsgKind? severity = null, [Caller] string caller = null);        
    }
}