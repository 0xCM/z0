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
    using static Render;

    [Event]
    public readonly struct ProcessedParts : IWfEvent<ProcessedParts>
    {
        public const string EventName = nameof(ProcessedParts);

        public WfEventId EventId {get;}

        public PartId[] Source {get;}

        public AsmRowSets<Mnemonic> Output {get;}

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ProcessedParts(WfStepId step, PartId[] parts, AsmRowSets<Mnemonic> data,  CorrelationToken ct, FlairKind flair = Running)
        {
            EventId = (EventName, step, ct);
            Output = data;
            Source = parts;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => string.Format(RP.PSx3, EventId, Source.Length, Output.Count);
    }
}