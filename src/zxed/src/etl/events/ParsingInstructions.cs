//-----------------------------------------------------------------------------
// Copyright   : (c) 2019 Intel Corporation
// Copyright   : (c) Chris Moore, 2020
// License     : Apache
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
        public readonly FilePath Source;

        [MethodImpl(Inline)]
        public ParsingXedInstructions(WfStepId step, FilePath source, CorrelationToken ct)
        {
            EventId = (EventType, step, ct);
            Source = source;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, Source);
    }
}