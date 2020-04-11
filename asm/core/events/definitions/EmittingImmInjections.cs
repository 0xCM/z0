//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using E = AsmEvents.EmittingImmInjections;

    partial class AsmEvents
    {
        public readonly struct EmittingImmInjections : IAppEvent<E, ApiHostUri>
        {
            public ApiHostUri Payload {get;}

            public readonly bool Generic;

            public static E Empty => new E(ApiHostUri.Empty,false);

            [MethodImpl(Inline)]
            public static E Define(ApiHostUri imm, bool generic)
                => new E(imm,generic);

            [MethodImpl(Inline)]
            EmittingImmInjections(ApiHostUri imm, bool generic)
            {
                this.Payload = imm;
                this.Generic = generic;
            }
                        
            public string Description
                => $"Emitting {Payload.Format()} immediate specializations" + (Generic ? " (generic)" : string.Empty);
            
            public E Zero => Empty;

        }            
    }
}