//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;
            
    [Event]
    public readonly struct WfError : IWfEvent<WfError, string>
    {                
        public const string EventName = nameof(WfError);
        
        public WfEventId Id {get;}
        
        public string ActorName {get;}

        public string Body {get;}
        
        public AppMsgColor Flair {get;}
        
        public AppMsg Description {get;}
        
        [MethodImpl(Inline)]
        public WfError(AppMsg description, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            Body = EmptyString;
            ActorName = EmptyString;
            Flair = AppMsgColor.Red;
            Description = description;
        }

        [MethodImpl(Inline)]
        public WfError(string worker, Exception e, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            Body = e.ToString();
            ActorName = worker;
            Flair = AppMsgColor.Red;
            Description = AppMsg.NoCaller(Body, AppMsgKind.Error);
        }

        [MethodImpl(Inline)]
        public WfError(string worker, object body, CorrelationToken ct)
        {
            Id = wfid(EventName, ct);
            ActorName = worker;
            Body = $"{body}";
            Flair = AppMsgColor.Red;
            Description = AppMsg.NoCaller(Body, AppMsgKind.Error);
        }
                
        public string Format()
            => text.format(PSx3, Id, ActorName, Description);
    }
}