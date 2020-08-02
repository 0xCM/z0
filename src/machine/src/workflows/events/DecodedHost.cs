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
    
    public readonly struct DecodedHost : IWfEvent<DecodedHost>
    {
        const string Pattern = "{0}: {1} {2} instructions decoded";

        public WfEventId Id {get;}

        public readonly HostInstructions Instructions;

        [MethodImpl(Inline)]
        public DecodedHost(HostInstructions inxs)
        {
            Id = WfEventId.define(nameof(DecodedHost));
            Instructions = inxs;            
        }

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;

        public int TotalCount 
            => Instructions.TotalCount;

        public string Format()
            => text.format(Pattern, Id, TotalCount, Instructions.Host);
    }        
}