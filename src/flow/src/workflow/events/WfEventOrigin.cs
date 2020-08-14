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
            
    [Table]
    public readonly struct WfEventOrigin : ITextual
    {
        public WfEventId EventId {get;}

        public WfActor Actor {get;}

        public WfCaller Call {get;}
        
        [MethodImpl(Inline)]
        public WfEventOrigin(WfEventId id, string actor, WfCaller call)
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