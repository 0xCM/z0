//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Event]
    public readonly struct WfTermEvent : IWfEvent<WfTermEvent,Textual<string>>
    {
        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public WfStepId StepId {get;}

        public MessageFlair Flair {get;}

        public Textual<string> Content {get;}

        [MethodImpl(Inline)]
        public WfTermEvent(WfEventId e, WfActor actor, WfStepId step, string body, MessageFlair flair)
        {
            EventId = e;
            Actor = actor;
            StepId = step;
            Flair = flair;
            Content = new Textual<string>(body, body);
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Actor, StepId, Content);
    }
}