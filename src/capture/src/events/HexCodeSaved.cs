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

    public readonly struct HexCodeSaved : IWfEvent<HexCodeSaved>
    {
        public const string EventName = nameof(HexCodeSaved);
        
        public WfEventId EventId {get;}
    
        public WfActor Actor {get;}

        public readonly ApiHostUri Host;
        
        public readonly IdentifiedCode[] Code;

        public readonly CellCount MemberCount;
        
        public readonly FilePath Target;

        public AppMsgColor Flair {get;}

        [MethodImpl(Inline)]
        public HexCodeSaved(string actor, ApiHostUri host, IdentifiedCode[] code, FilePath dst, CorrelationToken ct, AppMsgColor flair = RanFlair)
        {
            EventId = z.evid(EventName, ct);
            Actor = z.actor(actor);
            Host = host;
            MemberCount = code.Length;
            Code = code;
            Target = dst;
            Flair = flair;
        }
        
        [MethodImpl(Inline)]
        public string Format()
            => Flow.format(EventId, Host, MemberCount, Target);                   
    }    
}