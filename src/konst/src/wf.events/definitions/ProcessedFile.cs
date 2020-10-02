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

    partial struct WfEvents
    {
        [Event]
        public readonly struct ProcessedFile : IWfEvent<ProcessedFile>
        {
            public const string EventName = nameof(ProcessedFile);

            public WfEventId EventId {get;}

            public FS.FileUri File {get;}

            public Count ProcessedSize {get;}

            public FlairKind Flair {get;}

            [MethodImpl (Inline)]
            public ProcessedFile(WfStepId step, FS.FilePath file, uint size, CorrelationToken ct, FlairKind flair = Ran)
            {
                EventId = (EventName, step, ct);
                File = file;
                ProcessedSize = size;
                Flair = flair;
            }

            [MethodImpl (Inline)]
            public string Format()
                => Render.format(EventId, File, ProcessedSize);
        }
    }
}