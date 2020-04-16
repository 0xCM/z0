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
        public readonly struct EmittingImmTargets : IAppEvent<EmittingImmTargets, ApiHostUri>
        {
            public ApiHostUri Payload {get;}

            public readonly bool Generic;

            public static EmittingImmTargets Empty => new EmittingImmTargets(ApiHostUri.Empty,false);

            [MethodImpl(Inline)]
            public static EmittingImmTargets Define(ApiHostUri uri, bool generic)
                => new EmittingImmTargets(uri,generic);

            [MethodImpl(Inline)]
            EmittingImmTargets(ApiHostUri uri, bool generic)
            {
                this.Payload = uri;
                this.Generic = generic;
            }
                        
            public string Description
                => $"Emitting {Payload.Format()} immediate specializations" + (Generic ? " (generic)" : string.Empty);
            
            public EmittingImmTargets Zero => Empty;

        }            
    }
}