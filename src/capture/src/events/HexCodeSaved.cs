//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static Flairs;

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
        public HexCodeSaved(string actor, ApiHostUri host, IdentifiedCode[] code, FilePath dst, CorrelationToken ct, AppMsgColor flair = Ran)
        {
            EventId = Flow.evid(EventName, ct);
            Actor = Flow.actor(actor);
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