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
    using static Render;
    using static RenderPatterns;
    using static z;

    [Event]
    public readonly struct WfStepRan<T> : IWfEvent<WfStepRan<T>, T>
    {
        public const string EventName = nameof(WfStepRan<T>);

        public WfEventId EventId {get;}
                        
        public WfActor Actor {get;}

        public T Body {get;}

        public MessageFlair Flair {get;}
        
        [MethodImpl(Inline)]
        public WfStepRan(string actor, T body, CorrelationToken ct, MessageFlair flair = Ran)
        {            
            EventId = evid(EventName, ct);
            Actor = actor;
            Body = body;
            Flair = flair;        
        }

        [MethodImpl(Inline)]
        public WfStepRan(in WfActor actor, T body, CorrelationToken ct, MessageFlair flair = Ran)
        {            
            EventId = evid(EventName, ct);
            Actor = actor;
            Body = body;
            Flair = flair;        
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx3, EventId, Actor, Body);          
    }   
}