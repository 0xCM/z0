//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [Event]
    public readonly struct EmittedEnumCatalog : IWfEvent<EmittedEnumCatalog>
    {
        public const string EventName = nameof(EmittedEnumCatalog);

        public WfEventId EventId {get;}

        public readonly FS.FilePath TargetPath;

        public readonly Count Count;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public EmittedEnumCatalog(WfStepId step, FS.FilePath target, uint count, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, step, ct);
            TargetPath = target;
            Count = count;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Count, TargetPath);
    }
}