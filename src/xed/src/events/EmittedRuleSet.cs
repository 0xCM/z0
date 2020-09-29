//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct EmittedRuleSet : IWfEvent<EmittedRuleSet>
    {
        public static Type EventType => typeof(EmittedRuleSet);

        /// <summary>
        /// The event identifier
        /// </summary>
        public WfEventId EventId {get;}

        public Count LineCount {get;}

        /// <summary>
        /// The input file path
        /// </summary>
        public readonly FS.FileUri Target;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public EmittedRuleSet(WfStepId step, Count lines, FS.FileUri dst, CorrelationToken ct, FlairKind flair = FlairKind.Running)
        {
            EventId = (EventType, step, ct);
            LineCount = lines;
            Target = dst;
            Flair = flair;
        }

        [MethodImpl(Inline)]
        public string Format()
            => Render.format(EventId, LineCount, Target);
    }
}