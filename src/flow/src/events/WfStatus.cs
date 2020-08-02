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
    using static z;

    public readonly struct WfStatus : IWfEvent<WfStatus>
    {        
        const string Pattern = "{0}: {1}";

        public WfEventId Id {get;}

        public AppMsgColor Flair {get;}

        public readonly string Message;

        [MethodImpl(Inline)]
        public WfStatus(string msg, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(msg, ct ?? CorrelationToken.create(), now());
            Flair =  AppMsgColor.Green;
            Message = msg;
        }

        [MethodImpl(Inline)]
        public WfStatus(string msg, AppMsgColor flair, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(msg, ct ?? CorrelationToken.create(), now());
            Flair = flair;
            Message = msg;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, Message);
    }
}