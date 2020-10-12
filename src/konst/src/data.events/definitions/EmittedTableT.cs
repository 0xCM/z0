//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System;

    using static Konst;
    using static RP;

    [Event(EventName)]
    public readonly struct EmittedTableEvent<T> : IWfEvent<EmittedTableEvent<T>>
    {
        public const string EventName = nameof(GlobalEvents.EmittedTable);

        public WfEventId EventId {get;}

        public TableId TableId => typeof(T);

        public Count RowCount {get;}

        public FS.FilePath Target {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public EmittedTableEvent(WfStepId step, Count count, FS.FilePath target, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, step, ct);
            RowCount = count;
            Target = target;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, TableId, RowCount, Target.ToUri());

        public override string ToString()
            => Format();
    }
}