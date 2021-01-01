//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;
    using System;

    using static Part;

    [Event(Kind)]
    public readonly struct EmittingTableEvent<T> : IWfEvent<EmittingTableEvent<T>>
    {
        public const EventKind Kind = EventKind.EmittingTable;

        public WfEventId EventId {get;}

        public TableId TableId => typeof(T);

        public FS.FilePath Target {get;}

        public FlairKind Flair => FlairKind.Running;

        [MethodImpl(Inline)]
        public EmittingTableEvent(WfStepId step, FS.FilePath target, CorrelationToken ct)
        {
            EventId = (Kind, step, ct);
            Target = target;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, TableId, Target.ToUri());

        public override string ToString()
            => Format();
    }
}