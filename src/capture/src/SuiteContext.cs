//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    using Z0.Asm;

    public readonly struct ClientContext : IClientContext
    {
        public IAsmContext AsmContext {get;}

        [MethodImpl(Inline)]
        public ClientContext(IAsmContext asm)
        {
            AsmContext = asm;            
        }
    }
}