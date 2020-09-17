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
    public readonly struct WfTermEvent<T> : IWfEvent<WfTermEvent<T>,Textual<T>>
    {
        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public WfStepId StepId {get;}

        public FlairKind Flair {get;}

        public Textual<T> Content {get;}

        [MethodImpl(Inline)]
        public WfTermEvent(WfEventId e, WfActor actor, WfStepId step, Textual<T> body,  FlairKind flair)
        {
            EventId = e;
            Actor = actor;
            StepId = step;
            Content = body;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Actor, StepId, Content);
    }
}