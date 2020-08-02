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

        public readonly string Message;

        [MethodImpl(Inline)]
        public WfStatus(string msg, CorrelationToken? ct = null)
        {
            Id = WfEventId.define(msg, ct ?? CorrelationToken.create(), now());
            Message = msg;
        }

        public AppMsgColor Flair 
            => AppMsgColor.Magenta;

        [MethodImpl(Inline)]
        public string Format()
            => text.format(Pattern, Id, Message);


        public override string ToString()
            => Format();
    }
}