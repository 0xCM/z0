//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.IO;
    using System.Runtime.CompilerServices;
        
    using static Konst;
    using static Flow;
    using static z;

    [Event]
    public readonly struct WfStatus : IWfEvent<WfStatus>
    {        
        const string Pattern = IdMarker + "{1}";

        public WfEventId Id {get;}

        public AppMsgColor Flair {get;}

        public readonly string Message;

        [MethodImpl(Inline)]
        public WfStatus(string msg, CorrelationToken? ct = null)
        {
            Id = wfid(msg, ct);
            Flair =  AppMsgColor.Green;
            Message = msg;
        }

        [MethodImpl(Inline)]
        public WfStatus(string msg, AppMsgColor flair, CorrelationToken? ct = null)
        {
            Id = wfid(msg, ct);
            Flair = flair;
            Message = msg;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, Message);
    }
}