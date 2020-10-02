//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [Event]
    public readonly struct WfWarn<T> : IWfEvent<WfWarn<T>,T>
    {
        public const string EventName = nameof(WfWarn<T>);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public WfPayload<T> Payload {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfWarn(WfStepId step, T content, CorrelationToken ct)
        {
            EventId = (EventName, step, ct);
            Payload = content;
            StepId = step;
            Flair = FlairKind.Warning;
        }
        public string Format()
            => Render.format(EventId, StepId, Payload);
    }
}