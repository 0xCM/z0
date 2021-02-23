//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct SpecializedImmEvent : IWfEvent<SpecializedImmEvent>
    {
        public const string EventName = "SpecializedImm";

        public WfEventId EventId {get;}

        readonly ApiHostUri Host;

        readonly bool Generic;

        readonly RefinementClass ImmSource;

        readonly Type Refinement;

        readonly FS.FilePath TargetFile;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public static SpecializedImmEvent refined(WfStepId step, ApiHostUri uri, bool generic, Type refinement, FS.FilePath dst, CorrelationToken ct)
            => new SpecializedImmEvent(step, uri, generic, RefinementClass.Refined, refinement, dst, ct);

        [MethodImpl(Inline)]
        public static SpecializedImmEvent literal(WfStepId step, ApiHostUri uri, bool generic, FS.FilePath dst, CorrelationToken ct)
            => new SpecializedImmEvent(step, uri, generic, RefinementClass.Unrefined, typeof(void), dst, ct);

        [MethodImpl(Inline)]
        public static SpecializedImmEvent define(WfStepId step, ApiHostUri uri, bool generic, FS.FilePath dst, Type refinement, CorrelationToken ct)
            => new SpecializedImmEvent(step, uri, generic,
                refinement != null ? RefinementClass.Refined : RefinementClass.Unrefined,
                refinement,
                dst, ct);

        [MethodImpl(Inline)]
        public SpecializedImmEvent(WfStepId step, ApiHostUri uri, bool generic, RefinementClass source, Type refinement, FS.FilePath dst, CorrelationToken ct, FlairKind flair = FlairKind.Ran)
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