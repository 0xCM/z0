//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static RenderPatterns;

    public readonly struct EmittedEmbeddedImm : IWfEvent<EmittedEmbeddedImm>
    {
        public WfEventId EventId 
            => WfEventId.define(nameof(EmittedEmbeddedImm));

        public readonly ApiHostUri Host;

        public readonly bool Generic;

        public readonly ImmRefinementKind ImmSource;

        public readonly Type Refinement;

        public readonly FilePath TargetFile;

        [MethodImpl(Inline)]
        public EmittedEmbeddedImm Refined(ApiHostUri uri, bool generic, Type refinement, FilePath dst)
            => new EmittedEmbeddedImm(uri, generic, ImmRefinementKind.Refined, refinement, dst);

        [MethodImpl(Inline)]
        public EmittedEmbeddedImm Literal(ApiHostUri uri, bool generic, FilePath dst)
            => new EmittedEmbeddedImm(uri, generic, ImmRefinementKind.Unrefined, typeof(void), dst);

        [MethodImpl(Inline)]
        public EmittedEmbeddedImm Create(ApiHostUri uri, bool generic, FilePath dst, Type refinement = null)
            => new EmittedEmbeddedImm(uri, generic, refinement != null ? ImmRefinementKind.Refined : ImmRefinementKind.Unrefined, refinement, dst);

        [MethodImpl(Inline)]
        internal EmittedEmbeddedImm(ApiHostUri uri, bool generic, ImmRefinementKind source, Type refinement, FilePath dst)
        {
            Host = uri;
            Generic = generic;
            ImmSource = source;
            Refinement = refinement;
            TargetFile = dst;
        }
                    
        public string Format()
        {
            var description = 
                (ImmSource == ImmRefinementKind.Unrefined && Refinement != null)
                ? $"Emitted {Host}{(Generic ? " generic" : string.Empty)} literal imm specializations to {TargetFile}"
                : $"Emitted {Host}{(Generic ? " generic" : string.Empty)} imm {Refinement.DisplayName()} refinements to {TargetFile}";
            return description;            
        }

        public EmittedEmbeddedImm Zero 
            => Empty;

        public MessageFlair Flair 
            => MessageFlair.DarkMagenta;

        public static EmittedEmbeddedImm Empty 
            => default;
    }            
}