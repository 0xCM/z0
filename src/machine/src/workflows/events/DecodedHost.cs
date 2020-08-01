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
    
    public readonly struct DecodedHost : IWorkflowEvent<DecodedHost>
    {
        const string Pattern = "{0}: {1} {2} instructions decoded";
        
        public readonly HostInstructions Instructions;

        public readonly uint InxsCount;

        public readonly Timestamp Timestamp;

        [MethodImpl(Inline)]
        public DecodedHost(HostInstructions inxs)
        {
            Instructions = inxs;
            InxsCount = (uint)inxs.TotalCount;
            Timestamp = z.now();
        }

        public AppMsgColor Flair 
            => AppMsgColor.Cyan;

        public string Format()
            => text.format(Pattern, Timestamp, InxsCount, Instructions.Host);

        public string Description
            => Format();
    }        
}