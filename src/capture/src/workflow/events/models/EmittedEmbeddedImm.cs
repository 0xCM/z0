//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class AsmEvents
    {        
        public readonly struct EmittedEmbeddedImm : IAppEvent<EmittedEmbeddedImm, ApiHostUri>
        {
            public ApiHostUri Payload {get;}

            public readonly bool Generic;

            public readonly ImmSourceKind ImmSource;

            public readonly Type Refinement;

            public readonly FilePath TargetFile;

            public static EmittedEmbeddedImm Empty => new EmittedEmbeddedImm(ApiHostUri.Empty, false, ImmSourceKind.Literal, typeof(void), FilePath.Empty);

            [MethodImpl(Inline)]
            public static EmittedEmbeddedImm Refined(ApiHostUri uri, bool generic, Type refinement, FilePath dst)
                => new EmittedEmbeddedImm(uri, generic, ImmSourceKind.Refinement, refinement, dst);

            [MethodImpl(Inline)]
            public static EmittedEmbeddedImm Literal(ApiHostUri uri, bool generic, FilePath dst)
                => new EmittedEmbeddedImm(uri, generic, ImmSourceKind.Literal, typeof(void), dst);

            [MethodImpl(Inline)]
            public static EmittedEmbeddedImm Create(ApiHostUri uri, bool generic, FilePath dst, Type refinement = null)
                => new EmittedEmbeddedImm(uri, generic, refinement != null ? ImmSourceKind.Refinement : ImmSourceKind.Literal, refinement, dst);

            [MethodImpl(Inline)]
            EmittedEmbeddedImm(ApiHostUri uri, bool generic, ImmSourceKind source, Type refinement, FilePath dst)
            {
                this.Payload = uri;
                this.Generic = generic;
                this.ImmSource = source;
                this.Refinement = refinement;
                this.TargetFile = dst;
            }
                        
            public string Description
            {
                get
                {                    
                    var description = 
                        (ImmSource == ImmSourceKind.Literal && Refinement != null)
                      ? $"Emitted {Payload}{(Generic ? " generic" : string.Empty)} literal imm specializations to {TargetFile}"
                      : $"Emitted {Payload}{(Generic ? " generic" : string.Empty)} imm {Refinement.DisplayName()} refinements to {TargetFile}";
                    return description;
                }
            }
            
            public EmittedEmbeddedImm Zero => Empty;

            public AppMsgColor Flair => AppMsgColor.DarkMagenta;
        }            
    }
}