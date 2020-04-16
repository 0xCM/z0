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
        public readonly struct EmittedImmRefinements : IAppEvent<EmittedImmRefinements, ApiHostUri>
        {
            public ApiHostUri Payload {get;}

            public readonly bool Generic;

            public readonly Type Refined;

            public readonly FilePath TargetFile;

            public static EmittedImmRefinements Empty => new EmittedImmRefinements(ApiHostUri.Empty,false, typeof(void), FilePath.Empty);

            [MethodImpl(Inline)]
            public static EmittedImmRefinements Define(ApiHostUri uri, bool generic, Type refined, FilePath dst)
                => new EmittedImmRefinements(uri,generic, refined, dst);

            [MethodImpl(Inline)]
            EmittedImmRefinements(ApiHostUri uri, bool generic, Type refined, FilePath dst)
            {
                this.Payload = uri;
                this.Generic = generic;
                this.Refined = refined;
                this.TargetFile = dst;
            }
                        
            public string Description
                => $"Emitted {Payload}{(Generic ? " generic" : string.Empty)} imm {Refined.DisplayName()} refinements to {TargetFile}";
            
            public EmittedImmRefinements Zero => Empty;

        }            
    }
}