//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;
    
    public readonly struct DecodedHost : IAppEvent<DecodedHost>
    {
        public readonly HostInstructions Instructions;

        [MethodImpl(Inline)]
        public DecodedHost(HostInstructions inxs)
            => Instructions = inxs;

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;
                
        public string Description
            => $"{Instructions.TotalCount}  {Instructions.Host} instructions decoded";
    }        
}