//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static RP;

    [Event]
    public readonly struct ParsedAsmFile : IWfEvent<ParsedAsmFile>
    {
        public const string EventName = nameof(ParsedAsmFile);

        public WfEventId EventId {get;}

        public WfStepId StepId {get;}

        public FS.FilePath SourcePath {get;}

        public Count LineCount {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ParsedAsmFile(WfStepId step, Count lines, FS.FilePath src, CorrelationToken ct, FlairKind flair =  FlairKind.Ran)
        {
            EventId = (typeof(ParsedAsmFile), step, ct);
            StepId = step;
            LineCount = lines;
            SourcePath = src;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, StepId, LineCount, SourcePath);
    }
}