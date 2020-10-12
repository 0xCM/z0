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

        public CallingMember Call {get;}

        [MethodImpl(Inline)]
        public EventOrigin(WfEventId id, CallingMember call)
        {
            EventId = id;
            Call = call;
        }

        [MethodImpl(Inline)]
        public string Format()
            => format(EventId, Call);
    }
}