//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;
    using static z;

    [Event]
    public readonly struct WfWarn<T> : IWfEvent<WfWarn<T>,T>
    {
        public const string EventName = nameof(WfWarn<T>);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public T Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfWarn(WfStepId step, T content, CorrelationToken ct)
        {
            EventId = evid(EventName, ct);
            Content = content;
            StepId = step;
            Flair = FlairKind.Warning;
        }
        public string Format()
            => text.format(PSx3, EventId, StepId, Content);
    }
}