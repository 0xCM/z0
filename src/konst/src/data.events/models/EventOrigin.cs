//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    public readonly struct EventOrigin : ITextual
    {
        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public CallingMember Call {get;}

        [MethodImpl(Inline)]
        public EventOrigin(WfEventId id, string actor, CallingMember call)
        {
            EventId = id;
            Actor = actor;
            Call = call;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Actor, Call);
    }
}