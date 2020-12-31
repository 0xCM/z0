//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ParsedXedInstructions : IWfEvent<ParsedXedInstructions>
    {
        public const string EventName = nameof(ParsedXedInstructions);

        /// <summary>
        /// The event identifier
        /// </summary>
        public WfEventId EventId {get;}

        /// <summary>
        /// The input file path
        /// </summary>
        public FS.FilePath Source {get;}

        /// <summary>
        /// The number of instructions parsed from the source
        /// </summary>
        public Count Count {get;}

        /// <summary>
        /// The message flair
        /// </summary>
        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public ParsedXedInstructions(WfStepId step, FS.FilePath source, Count count, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, step, ct);
            Source = source;
            Count = count;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => TextFormatter.format(EventId, Count, Source.ToUri());
    }
}