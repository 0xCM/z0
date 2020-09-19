//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.Xed
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

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
        public ParsedXedInstructions(WfStepId step, FS.FilePath source, Count count, CorrelationToken ct, FlairKind flair = Ran)
        {
            EventId = (EventName, step, ct);
            Source = source;
            Count = count;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Count, Source.ToUri());
    }
}