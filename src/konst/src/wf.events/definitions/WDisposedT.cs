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
    using static z;

    [Event]
    public readonly struct WfDisposed<T> : IWfEvent<WfDisposed<T>>
    {
        public const string EventName = nameof(WfDisposed);

        public WfEventId EventId {get;}

        public WfPayload<T> Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfDisposed(WfStepId step, T content, CorrelationToken ct, FlairKind flair = Disposed)
        {
            EventId = (EventName, step, ct);
            Content = content;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Content);
    }
}