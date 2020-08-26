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
    public readonly struct WfEmitting : IWfEvent<WfEmitting>
    {
        public const string EventName = nameof(WfEmitting);

        public WfEventId EventId {get;}

        public string ActorName {get;}

        public string DatasetName {get;}

        public string TargetPath {get;}

        [MethodImpl(Inline)]
        public WfEmitting(string actor, string dataset, FilePath target, CorrelationToken ct)
        {
            ActorName = actor;
            EventId = z.evid(EventName, ct);
            DatasetName = dataset;
            TargetPath = target.Name;
        }

        [MethodImpl(Inline)]
        public string Format()
            => text.format(PSx4, EventId, ActorName, DatasetName, TargetPath);
    }
}