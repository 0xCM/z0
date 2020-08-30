//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
//-----------------------------------------------------------------------------
namespace Z0.XedWf
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    public readonly struct ParsedInstructions : IWfEvent<ParsedInstructions>
    {
        public const string EventName = nameof(ParsedInstructions);

        /// <summary>
        /// The event identifier
        /// </summary>
        public WfEventId EventId {get;}

        /// <summary>
        /// The step that was executing when the event originated
        /// </summary>
        public WfStepId StepId {get;}

        /// <summary>
        /// The input file path
        /// </summary>
        public FS.FilePath Source {get;}

        /// <summary>
        /// The number of instructions parsed from the source
        /// </summary>
        public Count32 Count {get;}

        /// <summary>
        /// The message flair
        /// </summary>
        public MessageFlair Flair {get;}

        [MethodImpl(Inline)]
        public ParsedInstructions(WfStepId step, FS.FilePath source, Count32 count, CorrelationToken ct, MessageFlair flair = Ran)
        {
            EventId = (EventName, ct);
            StepId = step;
            Source = source;
            Count = count;
            Flair = flair;
        }

        public string Format()
            => Render.format(EventId, StepId, Count, Source);
    }
}