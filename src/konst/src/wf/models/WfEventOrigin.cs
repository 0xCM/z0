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

    public readonly struct WfEventOrigin : ITextual
    {
        public WfStepId StepId {get;}

        public WfEventId EventId {get;}

        public CallingMember Call {get;}

        [MethodImpl(Inline)]
        public WfEventOrigin(WfStepId step, WfEventId @event, CallingMember call)
        {
            StepId = step;
            EventId = @event;
            Call = call;
        }

        public string Format()
            => format(EventId, Call);
    }
}