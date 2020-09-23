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

    public readonly struct EmittedEmbeddedImm : IWfEvent<EmittedEmbeddedImm>
    {
        public const string EventName = nameof(EmittedEmbeddedImm);
        public WfEventId EventId {get;}

        readonly ApiHostUri Host;

        readonly bool Generic;

        readonly ImmRefinementKind ImmSource;

        readonly Type Refinement;

        readonly FS.FilePath TargetFile;

        public FlairKind Flair {get;}


        [MethodImpl(Inline)]
        public EmittedEmbeddedImm refined(WfStepId step, ApiHostUri uri, bool generic, Type refinement, FilePath dst, CorrelationToken ct)
            => new EmittedEmbeddedImm(step, uri, generic, ImmRefinementKind.Refined, refinement, dst, ct);

        [MethodImpl(Inline)]
        public EmittedEmbeddedImm literal(WfStepId step, ApiHostUri uri, bool generic, FilePath dst, CorrelationToken ct)
            => new EmittedEmbeddedImm(step, uri, generic, ImmRefinementKind.Unrefined, typeof(void), dst, ct);

        [MethodImpl(Inline)]
        public EmittedEmbeddedImm define(WfStepId step, ApiHostUri uri, bool generic, FilePath dst, Type refinement, CorrelationToken ct)
            => new EmittedEmbeddedImm(step, uri, generic,
                refinement != null ? ImmRefinementKind.Refined : ImmRefinementKind.Unrefined,
                refinement,
                dst, ct);
            //=> new EmittedEmbeddedImm(uri, generic, refinement != null ? ImmRefinementKind.Refined : ImmRefinementKind.Unrefined, refinement, dst);

        [MethodImpl(Inline)]
        public EmittedEmbeddedImm(WfStepId step, ApiHostUri uri, bool generic, ImmRefinementKind source, Type refinement, FilePath dst, CorrelationToken ct, FlairKind flair = Ran)
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

        public EmittedEmbeddedImm Zero
            => default;

        public static EmittedEmbeddedImm Empty
            => default;
    }
}