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
    using static Flow;
    
    public readonly struct DecodedHost : IWfEvent<DecodedHost, HostInstructions>
    {
        public const string EventName = nameof(DecodedHost);
        
        public WfEventId EventId {get;}

        public string WorkerName {get;}
        
        public HostInstructions Instructions {get;}

        public AppMsgColor Flair {get;}

        public AppMsg Description {get;}
        
        [MethodImpl(Inline)]
        public DecodedHost(string worker, HostInstructions inxs, CorrelationToken ct, AppMsgColor flair = AppMsgColor.Cyan)
        {
            EventId = WfEventId.define(EventName, ct);
            WorkerName = worker;
            Instructions = inxs;            
            Flair = flair;
            Description = AppMsg.Colorize($"Decoded {Instructions.TotalCount} instructions for {Instructions.Host}", Flair);
        }

        public HostInstructions Body
            => Instructions;        

        public string Format()
            => text.format(PSx3, EventId, WorkerName, Description);
    }        
}