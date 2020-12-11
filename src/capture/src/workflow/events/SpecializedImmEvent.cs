//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Render;

    public readonly struct SpecializedImmEvent : IWfEvent<SpecializedImmEvent>
    {
        public const string EventName = nameof(SpecializedImmEvent);
        public WfEventId EventId {get;}

        readonly ApiHostUri Host;

        readonly bool Generic;

        readonly ScalarRefinementKind ImmSource;

        readonly Type Refinement;

        readonly FS.FilePath TargetFile;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public SpecializedImmEvent refined(WfStepId step, ApiHostUri uri, bool generic, Type refinement, FilePath dst, CorrelationToken ct)
            => new SpecializedImmEvent(step, uri, generic, ScalarRefinementKind.Refined, refinement, dst, ct);

        [MethodImpl(Inline)]
        public SpecializedImmEvent literal(WfStepId step, ApiHostUri uri, bool generic, FilePath dst, CorrelationToken ct)
            => new SpecializedImmEvent(step, uri, generic, ScalarRefinementKind.Unrefined, typeof(void), dst, ct);

        [MethodImpl(Inline)]
        public SpecializedImmEvent define(WfStepId step, ApiHostUri uri, bool generic, FilePath dst, Type refinement, CorrelationToken ct)
            => new SpecializedImmEvent(step, uri, generic,
                refinement != null ? ScalarRefinementKind.Refined : ScalarRefinementKind.Unrefined,
                refinement,
                dst, ct);

        [MethodImpl(Inline)]
        public SpecializedImmEvent(WfStepId step, ApiHostUri uri, bool generic, ScalarRefinementKind source, Type refinement, FilePath dst, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
        {
            EventId = (EventName, step, ct);
            Host = uri;
            Generic = generic;
            ImmSource = source;
            Refinement = refinement ?? typeof(void);
            TargetFile = FS.path(dst.Name);
            Flair = flair;
        }

        public string Format()
            => text.format(RP.PSx6, EventId, Host, Generic, ImmSource, Refinement, TargetFile);

        public SpecializedImmEvent Zero
            => default;

        public static SpecializedImmEvent Empty
            => default;
    }
}