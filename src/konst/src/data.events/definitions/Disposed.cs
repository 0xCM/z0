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
    public readonly struct Disposed : IWfEvent<Disposed>
    {
        public const string EventName = nameof(GlobalEvents.Disposed);

        public WfEventId EventId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public Disposed(WfStepId step, CorrelationToken ct, FlairKind flair = Render.Disposed)
        {
            EventId = (EventName, step, ct);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}