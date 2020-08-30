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

    [Event]
    public readonly struct EmittedEnumCatalog : IWfEvent<EmittedEnumCatalog>
    {
        public const string EventName = nameof(EmittedEnumCatalog);

        public WfEventId EventId {get;}

        public readonly FilePath TargetPath;

        public readonly Count32 Count;

        [MethodImpl(Inline)]
        public EmittedEnumCatalog(FilePath target, uint count, CorrelationToken ct)
        {
            EventId = WfEventId.define(EventName, ct);
            TargetPath = target;
            Count = count;
        }

        public string Format()
            => text.format(PSx3, EventId, Count, TargetPath);
    }
}