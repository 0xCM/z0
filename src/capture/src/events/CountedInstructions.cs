//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flow;

    using static z;

    public readonly struct CountedInstructions : IWfEvent<CountedInstructions>
    {            
        const string Pattern = IdMarker + "{1} | {2} | {3}";

        public WfEventId Id {get;}

        public string WorkerName {get;}
        public readonly ApiHostUri Host;

        public readonly uint Count;

        [MethodImpl(Inline)]
        public CountedInstructions(string worker, ApiHostUri host, uint count, CorrelationToken ct)
        {
            Id = wfid(nameof(CountedInstructions), ct);
            WorkerName = worker;
            Count = count;
            Host = host;
        }
        public string Format() 
            => text.format(Pattern, Id, WorkerName, Host, Count);
    }    

}