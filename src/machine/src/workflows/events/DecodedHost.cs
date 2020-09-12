//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    using static RenderPatterns;
    using static Render;

    [Event]
    public readonly struct DecodedHost : IWfEvent<DecodedHost>
    {
        public const string EventName = nameof(DecodedHost);

        const string Pattern = "Decoded {0} instructions for {1}";

        public WfEventId EventId {get;}

        public string WorkerName {get;}

        public HostAsmFx Instructions {get;}

        public FlairKind Flair {get;}

        public string Description {get;}

        [MethodImpl(Inline)]
        public DecodedHost(string worker, HostAsmFx src, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = WfEventId.define(EventName, ct);
            WorkerName = worker;
            Instructions = src;
            Flair = flair;
            Description = text.format(Pattern, Instructions.InstructionCount, Instructions.Uri);
        }
        public string Format()
            => text.format(PSx3, EventId, WorkerName, Description);
    }
}