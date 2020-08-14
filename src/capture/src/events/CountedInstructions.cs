//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static FormatLiterals;

    using static z;

    public readonly struct CountedInstructions : IWfEvent<CountedInstructions>
    {            
        public WfEventId EventId {get;}

        public string ActorName {get;}

        public readonly ApiHostUri Host;

        public readonly uint Count;

        [MethodImpl(Inline)]
        public CountedInstructions(string worker, ApiHostUri host, uint count, CorrelationToken ct)
        {
            EventId = evid(nameof(CountedInstructions), ct);
            ActorName = worker;
            Count = count;
            Host = host;
        }
        public string Format() 
            => text.format(PSx4, EventId, ActorName, Host, Count);
    }    

}