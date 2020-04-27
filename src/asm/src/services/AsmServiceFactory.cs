//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    using Z0.Asm;

    public interface IAsmServiceFactory : IAsmStateless, IServiceFactory<IAsmContext>
    {

    }
    
    readonly struct AsmServiceFactory : IAsmServiceFactory
    {
        [MethodImpl(Inline)]
        public static IAsmServiceFactory Create(IAsmContext context)
            => new AsmServiceFactory(context);
        
        [MethodImpl(Inline)]
        public AsmServiceFactory(IAsmContext context)
        {
            this.Context = context;
        }

        public IAsmContext Context {get;}
    }
}