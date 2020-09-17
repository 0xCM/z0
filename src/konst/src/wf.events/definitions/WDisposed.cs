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
    public readonly struct WfDisposed : IWfEvent<WfDisposed>
    {
        public const string EventName = nameof(WfDisposed);

        public WfEventId EventId {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public WfDisposed(WfStepId step, CorrelationToken ct, FlairKind flair = Disposed)
        {
            EventId = (EventName, step, ct);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => EventId.Format();
    }
}