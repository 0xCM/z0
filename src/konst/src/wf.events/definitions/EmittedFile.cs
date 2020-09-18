// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    partial struct WfEvents
    {
        public readonly struct EmittedFile : IWfEvent<EmittedFile, FS.FilePath>, IWfFileEmission<EmittedFile>
        {
            public const string EventName = nameof(EmittedFile);

            public WfEventId EventId {get;}

            public WfStepId StepId {get;}

            public FS.FilePath Path {get;}

            public FlairKind Flair {get;}

            [MethodImpl(Inline)]
            public EmittedFile(WfStepId step, FS.FilePath path, CorrelationToken ct, FlairKind flair = Ran)
            {
                EventId = (EventName, step, ct);
                StepId = step;
                Path = path;
                Flair = flair;
            }

            public WfPayload<FS.FilePath> Content
                => Path;

            [MethodImpl(Inline)]
            public string Format()
                => format(EventId, Path.ToUri());
        }
    }
}