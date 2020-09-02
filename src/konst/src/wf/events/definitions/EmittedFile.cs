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
            public WfEventId EventId {get;}

            public WfStepId StepId {get;}

            public FS.FilePath Path {get;}

            public MessageFlair Flair {get;}

            [MethodImpl(Inline)]
            public EmittedFile(WfStepId step, FS.FilePath path, CorrelationToken ct, MessageFlair flair = Ran)
            {
                StepId = step;
                EventId = id<EmittedFile>(step,ct);
                Path = path;
                Flair = flair;
            }

            [MethodImpl(Inline)]
            public EmittedFile(WfFunc fx, FS.FilePath path, CorrelationToken ct, MessageFlair flair = Ran)
            {
                StepId = fx.StepId;
                EventId = id<EmittedFile>(fx, ct);
                Path = path;
                Flair = flair;
            }

            public WfPayload<FS.FilePath> Content
                => Path;

            [MethodImpl(Inline)]
            public string Format()
                => format(EventId, Content);
        }
    }
}