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

    public readonly struct SpecializedImm : IWfEvent<SpecializedImm>
    {
        public const string EventName = nameof(SpecializedImm);
        public WfEventId EventId {get;}

        readonly ApiHostUri Host;

        readonly bool Generic;

        readonly ScalarRefinementKind ImmSource;

        readonly Type Refinement;

        readonly FS.FilePath TargetFile;

        public FlairKind Flair {get;}

        [MethodImpl(Inline)]
        public SpecializedImm refined(WfStepId step, ApiHostUri uri, bool generic, Type refinement, FilePath dst, CorrelationToken ct)
            => new SpecializedImm(step, uri, generic, ScalarRefinementKind.Refined, refinement, dst, ct);

        [MethodImpl(Inline)]
        public SpecializedImm literal(WfStepId step, ApiHostUri uri, bool generic, FilePath dst, CorrelationToken ct)
            => new SpecializedImm(step, uri, generic, ScalarRefinementKind.Unrefined, typeof(void), dst, ct);

        [MethodImpl(Inline)]
        public SpecializedImm define(WfStepId step, ApiHostUri uri, bool generic, FilePath dst, Type refinement, CorrelationToken ct)
            => new SpecializedImm(step, uri, generic,
                refinement != null ? ScalarRefinementKind.Refined : ScalarRefinementKind.Unrefined,
                refinement,
                dst, ct);

        [MethodImpl(Inline)]
        public SpecializedImm(WfStepId step, ApiHostUri uri, bool generic, ScalarRefinementKind source, Type refinement, FilePath dst, CorrelationToken ct, FlairKind flair = Ran)
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

        public SpecializedImm Zero
            => default;

        public static SpecializedImm Empty
            => default;
    }
}