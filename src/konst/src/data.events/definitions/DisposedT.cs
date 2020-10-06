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
    public readonly struct Disposed<T> : IWfEvent<Disposed<T>>
    {
        public const string EventName = nameof(Disposed);

        public WfEventId EventId {get;}

        public WfPayload<T> Content {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public Disposed(WfStepId step, T content, CorrelationToken ct, FlairKind flair = Render.Disposed)
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