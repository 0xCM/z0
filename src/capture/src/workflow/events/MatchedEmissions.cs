//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MatchedCapturedEmissions : IWfEvent<MatchedCapturedEmissions>
    {
        public const string EventName = nameof(MatchedCapturedEmissions);

        public WfEventId EventId {get;}

        readonly ApiHostUri Host;

        readonly Count32 Count;

        readonly FS.FilePath TargetPath;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public MatchedCapturedEmissions(WfStepId step, ApiHostUri host, uint count, FilePath path, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, step, ct);
            Host = host;
            Count = count;
            TargetPath = FS.path(path.Name);
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public MatchedCapturedEmissions(WfStepId step, ApiHostUri host, uint count, FS.FilePath path, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, step, ct);
            Host = host;
            Count = count;
            TargetPath = path;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Host, Count, TargetPath);
    }
}