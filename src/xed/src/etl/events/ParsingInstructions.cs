//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ParsingXedInstructions : IWfEvent<ParsingXedInstructions>
    {
        public static Type EventType => typeof(ParsingXedInstructions);

        /// <summary>
        /// The event identifier
        /// </summary>
        public WfEventId EventId {get;}

        /// <summary>
        /// The input file path
        /// </summary>
        public readonly FS.FilePath Source;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ParsingXedInstructions(WfStepId step, FS.FilePath source, CorrelationToken ct, FlairKind flair = FlairKind.Running)
        {
            EventId = (EventType, step, ct);
            Source = source;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, Source.ToUri());
    }
}